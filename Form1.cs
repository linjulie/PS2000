
namespace PSGuiAssignment

{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //class instance takes inn a string for the serial port name
        PSUConnector.PSConnect pSU = new PSUConnector.PSConnect("com7");


        private void Form1_Load(object sender, EventArgs e)
        {
            serialNumberLabel.Text = pSU.GetSerialNr();
            deviceTypeLabel.Text = pSU.GetDeviceTyoe();
            nominalVoltageLabel.Text = pSU.GetNominalVoltage();
            nominalCurrentlabel.Text = pSU.GetNominalCurrent();
            articleNumberLabel.Text = pSU.GetArticleNumber();
            manufacturerLabel.Text = pSU.GetManufacturer();
            softwareVerLabel.Text = pSU.GetSoftwareVersion();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string volt = pSU.GetNominalVoltage();
            ShowVoltULabel.Text = volt;

        }

        private void showVoltageBtn_Click(object sender, EventArgs e)
        {
            string current = pSU.GetNominalCurrent();
            ShowCurrentILabel.Text = current;
        }

        private void SetVolt_Click(object sender, EventArgs e)
        {
            pSU.SetVolt(setVoltTxtBox.Text);
        }

        private void SetRemoteControlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool setRemote; 

            if (SetRemoteControlCheckBox.Checked)
            {
                setRemote = true; 
            }
            else
            {
                setRemote = false; 
            }

            pSU.SetRemote(setRemote);
        }

        private void PowerOutputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool setPO; 

            if (PowerOutputCheckBox.Checked)
            {
                setPO = true; 
            }
            else
            {
                setPO = false; 
            }

            pSU.SetPowerOutput(setPO);
        }

    }
}