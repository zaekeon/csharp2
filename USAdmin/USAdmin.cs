using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
namespace USAdmin
{
    public partial class USAdmin : Form
    {
        private const string CONST_UDEMY_SERVICE = "Udemy Windows Service";

        public USAdmin()
        {
            InitializeComponent();
        }


        private void USAdmin_Load(object sender, EventArgs e)
        {
            

            lblServiceStatus.Text = getServiceStatus();

            if (lblServiceStatus.Text.Contains("Stopped"))
            {
                btnStart.Enabled = true;
            }
            else

            {
                btnStop.Enabled = true;
            }

        }

        public string getServiceStatus()
        {
            ServiceController sc = new ServiceController(CONST_UDEMY_SERVICE);
            string serviceStatus = string.Empty;

            try
            {
                serviceStatus = sc.Status.ToString();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error connecting to service");
            }

            return serviceStatus;

        }

        private void btnGetServiceStatus_Click(object sender, EventArgs e)
        {
            lblServiceStatus.Text = getServiceStatus();

            if (lblServiceStatus.Text.Contains("Stopped"))
            {
                btnStart.Enabled = true;
            }
            else

            {
                btnStop.Enabled = true;
            }


        }

        public bool startService()
        {
            ServiceController sc = new ServiceController(CONST_UDEMY_SERVICE);
            try
            {


                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public bool stopService()
        {
            return true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (startService())
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                lblServiceStatus.Text = "Service Status: Started";

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (stopService())
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                lblServiceStatus.Text = "Service Status: Stopped";

            }
        }
    }
}
