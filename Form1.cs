
namespace PSGuiAssignment

{
    using System.IO.Ports;
    using System.Runtime.Intrinsics.Arm;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            serialNumberLabel.Text = getInfo(0x01, 0x80, 1);
            deviceTypeLabel.Text = getInfo(0x00, 0x7F, 0);
            nominalVoltageLabel.Text = getData(0x02, 0x76).ToString();
            nominalCurrentlabel.Text = getData(0x03, 0x77).ToString();
            articleNumberLabel.Text = getInfo(0x06, 0x85, 6);
            manufacturerLabel.Text = getInfo(0x08, 0x87, 8);
            softwareVerLabel.Text = getInfo(0x09, 0x88, 9);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string volt = getData(0x02, 0x76).ToString();
            ShowVoltULabel.Text = volt;

        }

        private void showVoltageBtn_Click(object sender, EventArgs e)
        {
            string current = getData(0x03, 0x77).ToString();
            ShowCurrentILabel.Text = current;
        }

        private void SetVolt_Click(object sender, EventArgs e)
        {
            setData(setVoltTxtBox.Text, 0x32);
        }

        private void SetRemoteControlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            byte[] bytesToSendToTurnOnRC;

            if (SetRemoteControlCheckBox.Checked)
            {
                bytesToSendToTurnOnRC = new byte[] { 0xF1, 0x00, 0x36, 0x10, 0x10, 0x01, 0x47 }; // Turn on remote control

            }
            else
            {
                bytesToSendToTurnOnRC = new byte[] { 0xF1, 0x00, 0x36, 0x10, 0x00, 0x01, 0x37 }; // Turn of remote control

            }

            setRemoteControl(bytesToSendToTurnOnRC);
        }

        private void PowerOutputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            byte[] bytesToSendToTurnOnPO;

            if (PowerOutputCheckBox.Checked)
            {
                bytesToSendToTurnOnPO = new byte[] { 0xF1, 0x00, 0x36, 0x01, 0x01, 0x01, 0x29 }; //turn on Power output
            }
            else
            {
                bytesToSendToTurnOnPO = new byte[] { 0xF1, 0x00, 0x36, 0x01, 0x00, 0x01, 0x28 }; // turn off power output
            }

            setPowerOutputonoff(bytesToSendToTurnOnPO);
        }

        /*
        private void SetCurrent_Click(object sender, EventArgs e)
        {
            setData(setCurrentTxtBox.Text, 0x33);
        }*/

        private int getSum()
        {
            int SDHex = (int)0x40 + (int)0x20 + 0x10 + 5; //6-1 ref spec 3.1.1

            byte SD = Convert.ToByte(SDHex.ToString(), 10);


            //SD, DN, OBJ, DATA, CS
            byte[] byteWithOutCheckSum = { SD, (int)0x00, (int)0x47, 0x0, 0x0 }; // quert status

            int sum = 0;
            int arrayLength = byteWithOutCheckSum.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                sum += byteWithOutCheckSum[i];
            }

            return sum; 
        }
        
        
        private double getData(byte obj, byte checksum)
        {
            double data;
            int percentData = 0;


            int SDHex = (int)0x40 + (int)0x20 + 0x10 + 5; //6-1 ref spec 3.1.1
            byte SD = Convert.ToByte(SDHex.ToString(), 10);
            byte[] byteWithOutCheckSum = { SD, (int)0x00, (int)0x47, 0x0, 0x0 }; // quert status
            int arrayLength = byteWithOutCheckSum.Length;


            int sum = getSum();

            string hexSum = sum.ToString("X");
            string cs1 = "";
            string cs2 = "";
            if (hexSum.Length == 4)
            {
                cs1 = hexSum.Substring(0, hexSum.Length / 2);
                cs2 = hexSum.Substring(hexSum.Length / 2);
            }
            else if (hexSum.Length == 3)
            {
                cs1 = hexSum.Substring(0, 1);
                cs2 = hexSum.Substring(1);
            }
            else if ((hexSum.Length is 2) || (hexSum.Length is 1))
            {
                cs1 = "0";
                cs2 = hexSum;
            }

            if (cs1 != "")
            {


                byteWithOutCheckSum[arrayLength - 2] = Convert.ToByte(cs1, 16);
                byteWithOutCheckSum[arrayLength - 1] = Convert.ToByte(cs2, 16);
            }

            // now the byte array is ready to be sent

            List<byte> responseTelegram;
            using (SerialPort port = new SerialPort("Com6", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(byteWithOutCheckSum, 0, byteWithOutCheckSum.Length);
                Thread.Sleep(500);

                responseTelegram = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        //Console.WriteLine(t);
                        responseTelegram.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
            }

            if (responseTelegram == null)
            {
                Console.WriteLine("No telegram was read");
            }
            else
            {

                string percentDataString = responseTelegram[5].ToString("X") + responseTelegram[6].ToString("X");
                percentData = Convert.ToInt32(percentDataString, 16);

            }

            // get nominal voltage
            float nominalVoltage = 0;

            List<byte> response;
            byte[] bytesToSend = { 0x74, 0x00, obj, 0x00, checksum };

            using (SerialPort port = new SerialPort("com6", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                port.Write(bytesToSend, 0, bytesToSend.Length);
                Thread.Sleep(50);
                response = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        response.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
            }
            if (response == null)
            {
                Console.WriteLine("No telegram was read");
                return -1; 
            }
            else
            {
                byte[] byteArray = { response[6], response[5], response[4], response[3] };
                nominalVoltage = BitConverter.ToSingle(byteArray, 0);
                data = (double)percentData * nominalVoltage / 25600;
                //Console.WriteLine(string.Format("Voltage:{0}", data));

                return data; 
            }

        }

        private void setData(string Volt, byte obj)
        {
            // setting voltage, 30V

            //turn on remote control first

            byte[] bytes = new byte[] { 0xF1, 0x00, 0x36, 0x10, 0x10, 0x01, 0x47 };

            setRemoteControl(bytes);
            SetRemoteControlCheckBox.Checked = true;

            //
            int sum = getSum();

            string hexSum = sum.ToString("X");
            string cs1 = "";
            string cs2 = "";
            // 
            float setVolt = float.Parse(Volt);
            int percentSetValue = (int)Math.Round((25600 * setVolt) / 84);

            string hexValue = percentSetValue.ToString("X");
            string hexValue1 = "";
            string hexValue2 = "";

            if (hexValue.Length == 4)
            {
                hexValue1 = hexValue.Substring(0, hexValue.Length / 2);
                hexValue2 = hexValue.Substring(hexValue.Length / 2);
            }
            else if (hexValue.Length == 3)
            {
                hexValue1 = hexValue.Substring(0, 1);
                hexValue2 = hexValue.Substring(1);
            }
            else if ((hexValue.Length is 2) || (hexValue.Length is 1))
            {
                hexValue1 = "0";
                hexValue2 = hexValue;
            }
            byte[] newbytesWithoutChecksum = { 0xF2, 0x00, obj, Convert.ToByte(hexValue1, 16), Convert.ToByte(hexValue2, 16), 0x0, 0x0 };

            int newsum = 0;
            int newarrayLength = newbytesWithoutChecksum.Length;
            for (int i = 0; i < newarrayLength; i++)
            {
                newsum += newbytesWithoutChecksum[i];
            }

            string newhexSum = newsum.ToString("X");
            string newcs1 = "";
            string newcs2 = "";
            if (hexSum.Length == 4)
            {
                newcs1 = newhexSum.Substring(0, newhexSum.Length / 2);
                newcs2 = newhexSum.Substring(newhexSum.Length / 2);
            }
            else if (newhexSum.Length == 3)
            {
                newcs1 = newhexSum.Substring(0, 1);
                newcs2 = newhexSum.Substring(1);
            }
            else if ((newhexSum.Length is 2) || (newhexSum.Length is 1))
            {
                newcs1 = "0";
                newcs2 = newhexSum;
            }

            if (newcs1 != "")
            {


                newbytesWithoutChecksum[newarrayLength - 2] = Convert.ToByte(newcs1, 16);
                newbytesWithoutChecksum[newarrayLength - 1] = Convert.ToByte(newcs2, 16);
            }

            List<byte> newResponseTelegram;
            using (SerialPort port = new SerialPort("Com6", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(newbytesWithoutChecksum, 0, newbytesWithoutChecksum.Length);
                Thread.Sleep(500);

                newResponseTelegram = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        //Console.WriteLine(t);
                        newResponseTelegram.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
            }
            if (newResponseTelegram[3] == 0)
            {
                Console.WriteLine("New voltage was set");
            }
            else
            {
                Console.WriteLine(newResponseTelegram[3].ToString());
            }
        }

        private string getInfo(byte obj, byte checksum, int objInt)
        {

            // reading  device type
            List<byte> Serialresponse;
            // Remember the dataframe setup, SD, DN,   OBJ, DATA checksum1, checksum2
            // OBJ = 0x00 = 0, for device type
            byte[] serialBytesToSend = { 0x7F, 0x00, obj, 0x00, checksum };
            using (SerialPort port = new SerialPort("Com6", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(serialBytesToSend, 0, serialBytesToSend.Length);
                Thread.Sleep(500);

                Serialresponse = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        //Console.WriteLine(t);
                        Serialresponse.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);

                string binary = Convert.ToString(Serialresponse[0], 2);
                string payloadLengtBinaryString = binary.Substring(4);
                int payloadLength = Convert.ToInt32(payloadLengtBinaryString, 2);

                string returnInfoString = "";

                if (Serialresponse[2] == objInt) // means that I got a response on obj, which is refers to the object list.
                {
                    for (var i = 0; i < payloadLength; i++)
                    {
                        returnInfoString += Convert.ToChar(Serialresponse[3 + i]);
                    }
                }

                //Console.WriteLine(string.Format("info:{0}", returnInfoString));

                return returnInfoString; 
            }

        }




        private void setRemoteControl(byte[] bytesToSend)
        {
            // Remember the dataframe setup, SD, DN,   OBJ, DATA [hex1, hex2] checksum1, checksum2
            //OBJ 0x36 = 54

            byte[] bytesToSendToTurnOnRC = bytesToSend; // Turn on remote control
            List<byte> RCresponse;
            using (SerialPort port = new SerialPort("com6", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                port.Write(bytesToSendToTurnOnRC, 0, bytesToSendToTurnOnRC.Length);
                Thread.Sleep(50);
                RCresponse = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        RCresponse.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
                if (RCresponse[3] == 0)
                {
                    Console.WriteLine("Remote Control is turned on");
                }
                else
                {
                    Console.WriteLine(String.Format("Remote control is not turned on due to error: {0}", RCresponse[3].ToString()));
                }
            }
        }

        private void setPowerOutputonoff(byte[] bytesToSend)
        {
            // Remember the dataframe setup, SD, DN,   OBJ, DATA [hex1, hex2] checksum1, checksum2
            //OBJ 0x36 = 54

            byte[] bytesToSendToTurnOnRC = bytesToSend; 
            List<byte> RCresponse;
            using (SerialPort port = new SerialPort("com6", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                port.Write(bytesToSendToTurnOnRC, 0, bytesToSendToTurnOnRC.Length);
                Thread.Sleep(50);
                RCresponse = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        RCresponse.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
                if (RCresponse[3] == 0)
                {
                    Console.WriteLine("Power output is turned on");
                }
                else
                {
                    Console.WriteLine(String.Format("Power output is not turned on due to error: {0}", RCresponse[3].ToString()));
                }
            }
        }
    }
}