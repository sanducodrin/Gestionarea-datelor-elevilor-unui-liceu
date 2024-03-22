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

namespace Atestat
{
    public partial class Adaugare_user : Form
    {
        SqlConnection connection;
        int nr;
        public Adaugare_user()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id, Nume, Prenume, Clasa, Litera FROM Elevi ORDER BY Clasa, Litera, Nume, Prenume;", conn);
            SqlDataReader srd = cmd.ExecuteReader();
            string rowtxt;
            while(srd.Read())
            {
                for(int i=0; i<srd.FieldCount; i++)
                {
                    rowtxt = srd.GetValue(i+1).ToString() + " " + srd.GetValue(i+2).ToString() + " " + srd.GetValue(i + 3).ToString() + " " + srd.GetValue(i + 4).ToString();
                    idelevCB.Items.Add(rowtxt);
                    i = i + 4;
                }
            }
            srd.Close();
            conn.Close();
            daRB.Checked = false;
            nuRB.Checked = true;
            nr = idelevCB.Items.Count;
        }

        private void Adaugare_user_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin mainFrm = new Admin();
            mainFrm.Show();
        }

        private void daRB_CheckedChanged(object sender, EventArgs e)
        {
            if(nuRB.Checked)
            {
                nuRB.Checked = false;
                daRB.Checked = true;
            }
            if (daRB.Checked)
            {
                tip_utilizatorTB.Text = "Elev";
                numeTB.Text = "";
                prenumeTB.Text = "";
                label7.Visible = true;
                idelevCB.Visible = true;
                idelevCB.Enabled = true;
                numeTB.Enabled = false;
                prenumeTB.Enabled = false;
                nuRB.Checked = false;
            }
            else
            {
                label7.Visible = false;
                idelevCB.Visible = false;
            }
            label10.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            usernameTB.Text = "";
            parolaTB.Text = "";
            confParolaTb.Text = "";
            label14.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
        }

        private void nuRB_CheckedChanged(object sender, EventArgs e)
        {
            if(daRB.Checked)
            { 
                daRB.Checked = false;
                nuRB.Checked = true;
            }
            if(nuRB.Checked)
            {
                tip_utilizatorTB.Text = "Admin";
                idelevCB.Text = "";
                numeTB.Enabled = true;
                prenumeTB.Enabled = true;
                numeTB.Text = "";
                prenumeTB.Text = "";
            }
            label10.Visible = false;
            label11.Visible = false;
            label16.Visible = false;
            usernameTB.Text = "";
            parolaTB.Text = "";
            confParolaTb.Text = "";
            label14.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
        }

        bool Completate()
        {
            if(daRB.Checked == false && nuRB.Checked == false)
            {
                label10.Visible = true;
                return false;
            }
            else
                if(daRB.Checked && idelevCB.Text.Length == 0)
            {
                label11.Text = "Câmp obligatoriu";
                label11.Visible = true;
                return false;
            }
            else
                if (daRB.Checked && idelevCB.SelectedIndex == -1)
            {
                return false;
            }
            else
                if (nuRB.Checked && numeTB.Text.Length==0)
            {
                label12.Visible = true;
                return false;
            }
            else
                if(nuRB.Checked && prenumeTB.Text.Length==0)
            {
                label13.Visible = true;
                return false;
            }
            else
                if(usernameTB.TextLength==0)
            {
                label14.Visible = true;
                return false;
            }
            else
                if(parolaTB.TextLength==0)
            {
                label15.Visible = true;
                return false;
            }
            else
                if(confParolaTb.TextLength==0)
            {
                label17.Visible = true;
                return false;
            }
            else
                if(parolaTB.Text != confParolaTb.Text)
            {
                label9.Visible = true;
                return false;
            }
            return true;
        }

        private void AdaugaBTN_Click(object sender, EventArgs e)
        {
            string query="";
            if (Completate())
            {
                int id_elev;
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Elevi WHERE Nume='" + numeTB.Text + "' AND Prenume='" + prenumeTB.Text + "';", conn);
                if (daRB.Checked)
                {
                    SqlDataReader srd = cmd.ExecuteReader();
                    srd.Read();
                    id_elev = Convert.ToInt32(srd["Id"]);
                    conn.Close();
                    query = "INSERT INTO Utilizatori(Id_elev, Username, Parola, Nume, Prenume, Tip_user) VALUES(" + id_elev + ", '" + usernameTB.Text + "', HASHBYTES('SHA2_256', '" + parolaTB.Text + "'), '" + numeTB.Text + "', '" + prenumeTB.Text + "', " + 1 + ");";
                }
                if (nuRB.Checked)
                    query = "INSERT INTO Utilizatori(Id_elev, Username, Parola, Nume, Prenume, Tip_user) VALUES(NULL , '" + usernameTB.Text + "', HASHBYTES('SHA2_256', '" + parolaTB.Text + "'), '" + numeTB.Text + "', '" + prenumeTB.Text + "', " + 2 + ");";
                if (connection == null)
                    connection = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                else
                    if (connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd = new SqlCommand(query, connection);
                int resut = cmd.ExecuteNonQuery();
                if (resut > 0)
                {
                    MessageBox.Show("Adăugare cu success !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Adaugare_user_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Eroare la adăugare datelor !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Adaugare_user_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            idelevCB.Text = "";
            idelevCB.Enabled = false;
            nuRB.Checked = false;
            daRB.Checked = false;
            usernameTB.Text = "";
            parolaTB.Text = "";
            numeTB.Text = "";
            prenumeTB.Text = "";
            tip_utilizatorTB.Text = "";
            label11.Visible = false;
        }

        private void idelevCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idelevCB.SelectedIndex != -1)
                label16.Visible = false;
            string nume, prenume;
            int s, t;
            s = idelevCB.Text.IndexOf(" ");
            t = idelevCB.Text.Length - 5 - s;
            nume = idelevCB.Text.Substring(0, idelevCB.Text.IndexOf(" "));
            prenume = idelevCB.Text.Substring(s+1, t);
            numeTB.Text = nume;
            prenumeTB.Text = prenume;
        }

        private void confParolaTb_TextChanged(object sender, EventArgs e)
        {
            if (parolaTB.Text == confParolaTb.Text)
                label9.Visible = false;
            else
            {
                label9.Visible = true;
                label17.Visible = false;
            }
            if (confParolaTb.Text.Length == 0)
            {
                label17.Visible = true;
                label9.Visible = false;
            }
            else
                label17.Visible = false;
        }

        private void idelevCB_TextChanged(object sender, EventArgs e)
        {
            if(idelevCB.Text.Length == 0)
            {
                idelevCB.Items.Clear();
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nume, Prenume, Clasa, Litera FROM Elevi ORDER BY Clasa, Litera, Nume, Prenume;", conn);
                SqlDataReader srd = cmd.ExecuteReader();
                string rowtxt;
                while (srd.Read())
                {
                    for (int i = 0; i < srd.FieldCount; i++)
                    {
                        rowtxt = srd.GetValue(i + 1).ToString() + " " + srd.GetValue(i + 2).ToString() + " " + srd.GetValue(i + 3).ToString() + " " + srd.GetValue(i + 4).ToString();
                        idelevCB.Items.Add(rowtxt);
                        i = i + 4;
                    }
                }
                srd.Close();
                conn.Close();
            }

            label11.Visible = false;
            if (idelevCB.Text != idelevCB.SelectedIndex.ToString())
                label16.Visible = true;
            if (idelevCB.Text == idelevCB.SelectedIndex.ToString())
                label16.Visible = false;
            if (idelevCB.Text == "")
            {
                label11.Visible = true;
                label16.Visible = false;
            }
            idelevCB.SelectionStart = idelevCB.Text.Length;
        }

        private void numeTB_TextChanged(object sender, EventArgs e)
        {
            label12.Visible = false;
        }

        private void prenumeTB_TextChanged(object sender, EventArgs e)
        {
            label13.Visible = false;
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
            if (usernameTB.Text.Length == 0)
                label14.Visible = true;
            else
                label14.Visible = false;
        }

        private void parolaTB_TextChanged(object sender, EventArgs e)
        {
            if (parolaTB.Text.Length == 0)
                label15.Visible = true;
            else
                label15.Visible = false;
        }

        private void idelevCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            idelevCB.Items.Clear();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id, Nume, Prenume, Clasa, Litera FROM Elevi WHERE Nume LIKE '%" + idelevCB.Text + "%' ORDER BY Clasa, Litera, Nume, Prenume;", conn);
            SqlDataReader srd = cmd.ExecuteReader();
            string rowtxt;
            while (srd.Read())
            {
                for (int i = 0; i < srd.FieldCount; i++)
                {
                    rowtxt = srd.GetValue(i + 1).ToString() + " " + srd.GetValue(i + 2).ToString() + " " + srd.GetValue(i + 3).ToString() + " " + srd.GetValue(i + 4).ToString();
                    idelevCB.Items.Add(rowtxt);
                    i = i + 4;
                }
            }
            srd.Close();
            conn.Close();
            idelevCB.SelectionStart = idelevCB.Text.Length;
        }
    }
}
