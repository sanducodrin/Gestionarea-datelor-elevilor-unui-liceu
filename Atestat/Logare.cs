using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Logare : Form
    {
        LiceuDataSet.UtilizatoriDataTable userDt;
        public Logare()
        {
            InitializeComponent();
            label5.Text = DateTime.Now.ToString("hh:mm tt");
            label6.Text = DateTime.Now.ToString("dd.mm.yyyy");
        }
        public Logare(LiceuDataSet.UtilizatoriDataTable dt)
        {
            userDt = dt;
            InitializeComponent();
        }
        private void LogIn_Click(object sender, EventArgs e)
        {
            if (usernameTB.TextLength == 0)
                label12.Visible = true;
            if (parolaTB.TextLength == 0)
                label4.Visible = true;
            LiceuDataSet.UtilizatoriDataTable dt = utilizatoriTableAdapter.GetDataByCredentials(usernameTB.Text, parolaTB.Text);
            if (dt.Rows.Count == 1)
            {
                if (Convert.ToInt32(dt.Rows[0]["Tip_user"] .ToString()) == 2)
                {
                    Admin mainFrm = new Admin();
                    this.Hide();
                    mainFrm.Show();
                }
                else 
                {
                    Normal mainFrm = new Normal();
                    this.Hide();
                    mainFrm.userid(Convert.ToInt32(dt.Rows[0]["Id_elev"]), usernameTB.Text, parolaTB.Text);
                    mainFrm.Show();
                }
            }
            else
            {
                if (label12.Visible == false && label4.Visible == false)
                {
                    MessageBox.Show("Username sau parola incorecte!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTB.Clear();
                    parolaTB.Clear();
                    usernameTB.Focus();
                    label12.Visible = false;
                    label4.Visible = false;
                }
            }
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
            if (usernameTB.TextLength == 0)
                label12.Visible = true;
            else
                label12.Visible = false;
        }

        private void parolaTB_TextChanged(object sender, EventArgs e)
        {
            if (parolaTB.TextLength == 0)
                label4.Visible = true;
            else
                label4.Visible = false;
        }

        private void Logare_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(this.timer1_Tick);
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y == 192)
            {
                panel1.Visible = true;
                usernameTB.Focus();
                pictureBox1.Location = new Point(268, 65);
                label1.Location = new Point(233, 118);
            }
            else
            {
                panel1.Visible = false;
                pictureBox1.Location = new Point(268, 192);
                label1.Location = new Point(233, 245);
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("hh:mm tt");
            label6.Text = DateTime.Now.ToString("dd.mm.yyyy");
        }
    }
}
