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
    public partial class Notare : Form
    {
        SqlConnection conn;
        string nume, prenume;
        public Notare()
        {
            InitializeComponent();
        }

        private void Notare_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            clasaCB.Text = "";
            literaCB.Text = "";
            literaCB.Enabled = false;
            elevCB.Text = "";
            elevCB.Enabled = false;
            materieCB.Text = "";
            materieCB.Enabled = false;
            notaCB.Text = "";
            notaCB.Enabled = false;
            dataDTP.Value = DateTime.Now;
        }

        private void Notare_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin mainFrm = new Admin();
            mainFrm.Show();
        }

        private void clasaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (literaCB.Enabled == true)
            {
                literaCB.Enabled = false;
                literaCB.Text = "";
            }
            if (elevCB.Enabled == true)
            {
                elevCB.Enabled = false;
                elevCB.Text = "";
            }
            if (materieCB.Enabled == true)
            {
                materieCB.Enabled = false;
                materieCB.Text = "";
            }
            if (notaCB.Enabled == true)
            {
                notaCB.Enabled = false;
                notaCB.Text = "";
            }
            if(dataDTP.Enabled == true)
            {
                dataDTP.Enabled = false;
                dataDTP.Value = DateTime.Now;
            }
            if (clasaCB.Text != "")
            {
                literaCB.Enabled = true;
            }
            if(literaCB.Text != "")
            {
                elevCB.Items.Clear();
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nume, Prenume FROM Elevi WHERE Clasa = " + clasaCB.Text + " AND Litera = '" + literaCB.Text + "';", conn);
                SqlDataReader srd = cmd.ExecuteReader();
                string rowtxt;
                while (srd.Read())
                {
                    for (int i = 0; i < srd.FieldCount; i++)
                    {
                        rowtxt = srd.GetValue(i).ToString() + " " + srd.GetValue(i + 1).ToString();
                        elevCB.Items.Add(rowtxt);
                        i = i + 1;
                    }
                }
                srd.Close();
                conn.Close();
            }
        }

        private void literaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            elevCB.Items.Clear();
            elevCB.Text = "";
            if (elevCB.Enabled == true)
            {
                elevCB.Text = "";
                elevCB.Enabled = false;
            }
            if (materieCB.Enabled == true)
            {
                materieCB.Text = "";
                materieCB.Enabled = false;
            }
            if (notaCB.Enabled == true)
            {
                notaCB.Text = "";
                notaCB.Enabled = false;
            }
            if (dataDTP.Enabled == true)
            {
                dataDTP.Enabled = false;
                dataDTP.Value = DateTime.Now;
            }
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Nume, Prenume FROM Elevi WHERE Clasa = " + clasaCB.Text + " AND Litera = '" + literaCB.Text + "';", conn);
            SqlDataReader srd = cmd.ExecuteReader();
            string rowtxt;
            while (srd.Read())
            {
                for (int i = 0; i < srd.FieldCount; i++)
                {
                    rowtxt = srd.GetValue(i).ToString() + " " + srd.GetValue(i + 1).ToString();
                    elevCB.Items.Add(rowtxt);
                    i = i + 1;
                }
            }
            srd.Close();
            conn.Close();

            if(literaCB.Text != "")
            {
                elevCB.Enabled = true;
            }
        }

        private void elevCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materieCB.Enabled == true)
            {
                materieCB.Text = "";
                materieCB.Enabled = false;
            }
            if (notaCB.Enabled == true)
            {
                notaCB.Text = "";
                notaCB.Enabled = false;
            }
            if (dataDTP.Enabled == true)
            {
                dataDTP.Enabled = false;
                dataDTP.Value = DateTime.Now;
            }
            if (elevCB.Text != "")
            {
                materieCB.Enabled = true;
            }
            int k = elevCB.SelectedItem.ToString().IndexOf(" ");
            nume = elevCB.Text.Substring(0, k);
            int p = elevCB.Text.Length-k-1;
            prenume = elevCB.Text.Substring(k+1, p);
        }

        private void materieCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notaCB.Enabled == true)
            {
                notaCB.Text = "";
                notaCB.Enabled = false;
            }
            if (dataDTP.Enabled == true)
            {
                dataDTP.Enabled = false;
                dataDTP.Value = DateTime.Now;
            }
            if (materieCB.Text != "")
            {
                notaCB.Enabled = true;
                dataDTP.Enabled = true;
            }
        }

        bool Completate()
        {
            if(clasaCB.Text.Length == 0)
            {
                MessageBox.Show("Câmpul Clasă necompletat!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if(clasaCB.SelectedIndex == -1)
            {
                MessageBox.Show("Câmpul Clasă completat incorect!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if(literaCB.Text.Length == 0)
            {
                MessageBox.Show("Câmpul Litera necompletat!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if(literaCB.SelectedIndex == -1)
            {
                MessageBox.Show("Câmpul Litera completat incorect!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if(elevCB.Text.Length == 0)
            {
                MessageBox.Show("Câmpul Elev necompletat!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if(elevCB.SelectedIndex == -1)
            {
                MessageBox.Show("Câmpul Elev completat incorect!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if(materieCB.Text.Length == 0)
            {
                MessageBox.Show("Câmpul Materie necompletat!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if(materieCB.SelectedIndex == -1)
            {
                MessageBox.Show("Câmpul Materie completat incorect!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if(notaCB.Text.Length == 0)
            {
                MessageBox.Show("Câmpul Notă necompletat!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if(notaCB.SelectedIndex == -1)
            {
                MessageBox.Show("Câmpul Notă completat incorect!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void notareBTN_Click(object sender, EventArgs e)
        {
            if(Completate())
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Elevi WHERE Nume='" + nume + "' AND Prenume='" + prenume + "' AND Clasa= " + clasaCB.Text + " AND Litera= '" + literaCB.Text + "';", conn);
                SqlDataReader srd = cmd.ExecuteReader();
                srd.Read();
                int id_elev = Convert.ToInt32(srd["Id"]);
                srd.Close();
                string query = "INSERT INTO Note(Id_elev, Materie, Nota, Data) VALUES(" + id_elev + ", '" + materieCB.Text + "', " + notaCB.Text + ", '" + dataDTP.Value + "');";
                if (conn == null)
                    conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                else
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                cmd = new SqlCommand(query, conn);
                int resut = cmd.ExecuteNonQuery();
                if (resut > 0)
                {
                    MessageBox.Show("Notare cu success !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Notare_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Eroare la adăugare datelor !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
