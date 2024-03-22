using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Atestat
{
    public partial class Normal : Form
    {
        public Normal()
        {
            InitializeComponent();
            //timer1.Enabled = true;
            timer1.Start();
            LoadNextImage();

            homePanel.Visible = true;
            situatiePanel.Visible = false;

            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
        }

        public int idElev;
        public string user_name, pass;

        public void userid(int i, string u, string p)
        {
            idElev = i;
            user_name = u;
            pass = p;
        }

        private void Normal_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Nume, Prenume FROM Elevi WHERE Id = " + idElev + ";", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            textBox1.Text = sdr[0] as string + " " + sdr[1] as string;
        }

        private void Normal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 7)
                imageNumber = 1;
            slidePic1.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
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

        private void homeButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            situatiePanel.Visible = false;
        }

        private void LabelMediePop()
        {
            LLRlabelMedie.Text = "";
            LElabelMedie.Text = "";
            LFlabelMedie.Text = "";
            LGlabelMedie.Text = "";
            LLlabelMedie.Text = "";
            MatematicalabelMedie.Text = "";
            FizicalabelMedie.Text = "";
            ChimielabelMedie.Text = "";
            BiologielabelMedie.Text = "";
            IstorielabelMedie.Text = "";
            GeografielabelMedie.Text = "";
            SSUlabelMedie.Text = "";
            ReligielabelMedie.Text = "";
            EMlabelMedie.Text = "";
            EPlabelMedie.Text = "";
            EFSlabelMedie.Text = "";
            InformaticalabelMedie.Text = "";
            TIClabelMedie.Text = "";
        }

        private void LabelMateriePop()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            SqlCommand cmd;
            SqlDataReader sdr;

            float nr_materii_notate = 0, medie_materii = 0;

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Limba si literatura romana' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            int nr_note = 0, medie = 0;
            LLRlabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                LLRlabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                LLRlabel.Text = "Nu există note";
                LLRlabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                LLRlabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Matematica' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            Matematicalabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                Matematicalabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                Matematicalabel.Text = "Nu există note";
                MatematicalabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                MatematicalabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Fizica' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            Fizicalabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                Fizicalabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                Fizicalabel.Text = "Nu există note";
                FizicalabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                FizicalabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Chimie' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            Chimielabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                Chimielabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                Chimielabel.Text = "Nu există note";
                ChimielabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                ChimielabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Istoria' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            Istorielabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                Istorielabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                Istorielabel.Text = "Nu există note";
                IstorielabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                IstorielabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Geografie' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            Geografielabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                Geografielabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                Geografielabel.Text = "Nu există note";
                GeografielabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                GeografielabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Religie' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            Religielabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                Religielabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                Religielabel.Text = "Nu există note";
                ReligielabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                ReligielabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Educatie fizica si sport' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            EFSlabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                EFSlabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                EFSlabel.Text = "Nu există note";
                EFSlabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                EFSlabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Informatica' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            Informaticalabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                Informaticalabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                Informaticalabel.Text = "Nu există note";
                InformaticalabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                InformaticalabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Limba Engleza' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            LElabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                LElabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                LElabel.Text = "Nu există note";
                LElabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                LElabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Biologie' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            Biologielabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                Biologielabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                Biologielabel.Text = "Nu există note";
                BiologielabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                BiologielabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Stiinte socio-umane' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            SSUlabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                SSUlabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                SSUlabel.Text = "Nu există note";
                SSUlabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                SSUlabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Limba Franceza' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            LFlabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                LFlabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                LFlabel.Text = "Nu există note";
                LFlabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                LFlabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Limba Germana' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            LGlabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                LGlabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                LGlabel.Text = "Nu există note";
                LGlabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                LGlabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Limba Latina' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            LLlabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                LLlabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                LLlabel.Text = "Nu există note";
                LLlabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                LLlabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Educatie muzicala' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            EMlabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                EMlabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                EMlabel.Text = "Nu există note";
                EMlabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                EMlabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'Educatie plastica' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            EPlabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                EPlabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                EPlabel.Text = "Nu există note";
                EPlabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                EPlabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            conn.Open();
            cmd = new SqlCommand("SELECT Nota FROM Note WHERE Materie = 'TIC' AND Id_elev =" + idElev + ";", conn);
            sdr = cmd.ExecuteReader();
            nr_note = 0; medie = 0;
            TIClabel.Text = "";
            while (sdr.Read())
            {
                nr_note++;
                TIClabel.Text += sdr[0].ToString() + "   ";
                medie += sdr.GetInt32(0);
            }
            if (nr_note == 0)
            {
                TIClabel.Text = "Nu există note";
                TIClabelMedie.Text = "";
            }
            else
            {
                medie /= nr_note;
                TIClabelMedie.Text = medie.ToString();
                nr_materii_notate++;
                medie_materii += medie;
            }
            conn.Close();
            sdr.Close();

            if (nr_materii_notate != 0)
            {
                medie_materii /= nr_materii_notate;
                medie_materii = (float)System.Math.Round(medie_materii, 2);
                MediaGeneralalabel.Text = medie_materii.ToString();
            }
            else
                MediaGeneralalabel.Text = "";
        }

        private void situatieButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            situatiePanel.Visible = true;
            contPanel.Visible = false;

            situatiePanel.AutoScroll = false;
            situatiePanel.HorizontalScroll.Enabled = false;
            situatiePanel.HorizontalScroll.Visible = false;
            situatiePanel.HorizontalScroll.Maximum = 0;
            situatiePanel.AutoScroll = true;

            LabelMediePop();

            LabelMateriePop();
        }

        private void contButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            situatiePanel.Visible = true;
            contPanel.Visible = true;

            situatiePanel.AutoScroll = false;

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Nume, Prenume, Clasa, Litera, Nr_matricol FROM Elevi WHERE Id = " + idElev + ";", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            infGenNumeTB.Text = sdr[0].ToString() + " " + sdr[1].ToString();
            infGenClasaTB.Text = sdr[2].ToString() + " " + sdr[3].ToString();
            infGenNr_matricolTB.Text = sdr[4].ToString();
            conn.Close();
            sdr.Close();
        }

        private bool Completate()
        {
            if (modifCredUsernameTB.Text.Length == 0)
            {
                label31.Visible = true;
                return false;
            }
            else
                if (modifCredParolaActTB.Text.Length == 0)
            {
                label28.Visible = true;
                return false;
            }
            else
                if (modifCredParolaNouaTB.Text.Length == 0)
            {
                label29.Visible = true;
                return false;
            }
            else
                if(modifCredConfParolaTB.Text.Length == 0)
            {
                label30.Visible = true;
                return false;
            }
            return true;
        }

        private void modifCredUsernameTB_TextChanged(object sender, EventArgs e)
        {
            if (modifCredUsernameTB.Text.Length == 0)
                label31.Visible = true;
            else
                label31.Visible = false;
        }

        private void modifCredParolaActTB_TextChanged(object sender, EventArgs e)
        {
            if (modifCredParolaActTB.Text.Length == 0)
            {
                label28.Visible = true;
                label32.Visible = false;
            }
            else
            {
                label28.Visible = false;
                if ( modifCredParolaActTB.Text != pass)
                    label32.Visible = true;
                else
                    label32.Visible = false;
            }
        }

        private void modifCredParolaNouaTB_TextChanged(object sender, EventArgs e)
        {
            if (modifCredParolaNouaTB.Text.Length == 0)
                label29.Visible = true;
            else
                label29.Visible = false;
        }

        private void modifCredConfParolaTB_TextChanged(object sender, EventArgs e)
        {
            if (modifCredConfParolaTB.Text.Length == 0)
                label30.Visible = true;
            else
                if (modifCredConfParolaTB.Text != modifCredParolaNouaTB.Text)
                label30.Visible = true;
            else
                label30.Visible = false;
        }

        private void ModifCred_Click(object sender, EventArgs e)
        {
            if (groupBox20.Enabled == false)
            {
                groupBox20.Enabled = true;
                modifCredUsernameTB.Text = user_name;
                modifCredModifBTN.Text = "Modificare";

                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }
            else
            {
                groupBox20.Enabled = false;
                modifCredUsernameTB.Text = "";
                modifCredParolaNouaTB.Text = "";
                modifCredParolaActTB.Text = "";
                modifCredModifBTN.Text = "";
                modifCredConfParolaTB.Text = "";
                modifCredModifBTN.Text = "Modificare";

                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }
        }

        private void modifCredModifBTN_Click(object sender, EventArgs e)
        {
            if(Completate() && modifCredParolaActTB.Text == pass && modifCredParolaNouaTB.Text == modifCredConfParolaTB.Text)
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Utilizatori SET Username = '" + modifCredUsernameTB.Text + "', Parola =	HASHBYTES('SHA2_256', '" + modifCredParolaNouaTB.Text + "') WHERE Id_elev = " + idElev + ";", conn);
                int rezultat = cmd.ExecuteNonQuery();
                if (rezultat > 0)
                {
                    MessageBox.Show("Modificare cu success !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    groupBox20.Enabled = false;
                    modifCredUsernameTB.Text = "";
                    modifCredParolaNouaTB.Text = "";
                    modifCredParolaActTB.Text = "";
                    modifCredModifBTN.Text = "";
                    modifCredConfParolaTB.Text = "";

                    label28.Visible = false;
                    label29.Visible = false;
                    label30.Visible = false;
                    label31.Visible = false;
                    label32.Visible = false;

                    Normal_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Eroare la modificarea datelor !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
