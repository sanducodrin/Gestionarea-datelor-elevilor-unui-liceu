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
    public partial class Admin : Form
    {   
        public Admin()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(this.pictureBox1, "Adăugare");
            toolTip1.SetToolTip(this.pictureBox2, "Modificare");
            toolTip1.SetToolTip(this.pictureBox5, "Ștergere");
            toolTip1.SetToolTip(this.pictureBox4, "Notare");
            toolTip1.SetToolTip(this.exitBtn, "Ieșire");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 7)
                imageNumber = 1;
            slidePic.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;
            if (imageNumber == 2)
                imgTxt.Text = "Campusul";
            if (imageNumber == 3)
                imgTxt.Text = "Clubul treivirgulăpaişpe";
            if (imageNumber == 4)
                imgTxt.Text = "Clubul de dezbateri";
            if (imageNumber == 5)
                imgTxt.Text = "Shin Dong-hyuk la Hasdeu";
            if (imageNumber == 6)
                imgTxt.Text = "Spectacolul Almost, Maine";
            if (imageNumber == 7)
                imgTxt.Text = "Concursul Hasdeu Open Tenis";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modificare_Nota mainFrm = new Modificare_Nota();
            mainFrm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y == 48)
            {
                pictureBox1.Location = new Point(12, 12);
                pictureBox2.Location = new Point(204, 48);
                pictureBox5.Location = new Point(401, 48);

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
            }
            else
            {
                pictureBox1.Location = new Point(12, 48);
                pictureBox2.Location = new Point(204, 48);
                pictureBox5.Location = new Point(401, 48);

                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Adaugare_Elev mainFrm = new Adaugare_Elev();
            mainFrm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Adaugare_user mainFrm = new Adaugare_user();
            mainFrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modificare_Elev mainFrm = new Modificare_Elev();
            mainFrm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stergere_Elev mainFrm = new Stergere_Elev();
            mainFrm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stergere_User mainFrm = new Stergere_User();
            mainFrm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Location.Y == 48)
            {
                pictureBox1.Location = new Point(12, 48);
                pictureBox2.Location = new Point(204, 12);
                pictureBox5.Location = new Point(401, 48);

                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = true;
                button7.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
            }
            else
            {
                pictureBox1.Location = new Point(12, 48);
                pictureBox2.Location = new Point(204, 48);
                pictureBox5.Location = new Point(401, 48);

                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Location.Y == 48)
            {
                pictureBox1.Location = new Point(12, 48);
                pictureBox2.Location = new Point(204, 48);
                pictureBox5.Location = new Point(401, 12);

                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = false;
            }
            else
            {
                pictureBox1.Location = new Point(12, 48);
                pictureBox2.Location = new Point(204, 48);
                pictureBox5.Location = new Point(401, 48);

                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Notare mainFrm = new Notare();
            mainFrm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Modificare_User mainFrm = new Modificare_User();
            mainFrm.Show();
            this.Hide();
        }
    }
}
