namespace Port_Forwarding_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fromIpInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void toPortInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void toIpInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            string fromIp = fromIpInput.Text;
            string toIp = toIpInput.Text;
            string fromPort = fromPortInput.Text;
            string toPort = toPortInput.Text;
            ExecuteCommands.addNetsh(fromIp, fromPort, toIp, toPort);


        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string fromIp = fromIpInput.Text;
            string fromPort = fromPortInput.Text;
            ExecuteCommands.removeNetsh(fromIp, fromPort);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
