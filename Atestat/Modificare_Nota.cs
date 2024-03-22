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
    public partial class Modificare_Nota : Form
    {
        SqlConnection conn;
        string nume, prenume;
        int id_elev;
        public Modificare_Nota()
        {
            InitializeComponent();
        }

        private void Modificare_Nota_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            clasaCBModif.Text = "";
            literaCBModif.Enabled = false;
            literaCBModif.Text = "";
            elevCBModif.Enabled = false;
            elevCBModif.Text = "";
            materieCBModif.Enabled = false;
            materieCBModif.Text = "";
            notaCBModif.Enabled = false;
            notaCBModif.Text = "";
            notaNouaCB.Enabled = false;
            notaNouaCB.Text = "";
            label3.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
        }

        private void clasaCBModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clasaCBModif.SelectedIndex == -1)
                label8.Visible = true;
            if (clasaCBModif.SelectedIndex != -1)
                label8.Visible = false;
            if (literaCBModif.Enabled == true)
            {
                literaCBModif.Enabled = false;
                literaCBModif.Text = "";
                label3.Visible = false;
            }
            if (elevCBModif.Enabled == true)
            {
                elevCBModif.Enabled = false;
                elevCBModif.Text = "";
                label9.Visible = false;
            }
            if (materieCBModif.Enabled == true)
            {
                materieCBModif.Enabled = false;
                materieCBModif.Text = "";
                label10.Visible = false;
            }
            if (notaCBModif.Enabled == true)
            {
                notaCBModif.Enabled = false;
                notaCBModif.Text = "";
                label11.Visible = false;
            }
            if(notaNouaCB.Enabled == true)
            {
                notaNouaCB.Enabled = false;
                notaNouaCB.Text = "";
                label12.Visible = false;
            }
            if (clasaCBModif.Text != "")
            {
                literaCBModif.Enabled = true;
            }
            if (literaCBModif.Text != "")
            {
                elevCBModif.Items.Clear();
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nume, Prenume FROM Elevi WHERE Clasa = " + clasaCBModif.Text + " AND Litera = '" + literaCBModif.Text + "';", conn);
                SqlDataReader srd = cmd.ExecuteReader();
                string rowtxt;
                while (srd.Read())
                {
                    for (int i = 0; i < srd.FieldCount; i++)
                    {
                        rowtxt = srd.GetValue(i).ToString() + " " + srd.GetValue(i + 1).ToString();
                        elevCBModif.Items.Add(rowtxt);
                        i = i + 1;
                    }
                }
                srd.Close();
                conn.Close();
            }
        }

        private void literaCBModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (literaCBModif.SelectedIndex == -1)
                label3.Visible = true;
            if (literaCBModif.SelectedIndex != -1)
                label3.Visible = false;
            elevCBModif.Items.Clear();
            elevCBModif.Text = "";
            if (elevCBModif.Enabled == true)
            {
                elevCBModif.Text = "";
                elevCBModif.Enabled = false;
                label9.Visible = false;
            }
            if (materieCBModif.Enabled == true)
            {
                materieCBModif.Text = "";
                materieCBModif.Enabled = false;
                label10.Visible = false;
            }
            if (notaCBModif.Enabled == true)
            {
                notaCBModif.Text = "";
                notaCBModif.Enabled = false;
                label11.Visible = false;
            }
            if (notaNouaCB.Enabled == true)
            {
                notaNouaCB.Enabled = false;
                notaNouaCB.Text = "";
                label12.Visible = false;
            }
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Nume, Prenume FROM Elevi WHERE Clasa = " + clasaCBModif.Text + " AND Litera = '" + literaCBModif.Text + "';", conn);
            SqlDataReader srd = cmd.ExecuteReader();
            string rowtxt;
            while (srd.Read())
            {
                for (int i = 0; i < srd.FieldCount; i++)
                {
                    rowtxt = srd.GetValue(i).ToString() + " " + srd.GetValue(i + 1).ToString();
                    elevCBModif.Items.Add(rowtxt);
                    i = i + 1;
                }
            }
            srd.Close();
            conn.Close();

            if (literaCBModif.Text != "")
            {
                elevCBModif.Enabled = true;
            }
        }

        private void elevCBModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elevCBModif.SelectedIndex == -1)
                label9.Visible = true;
            if (elevCBModif.SelectedIndex != -1)
                label9.Visible = false;
            if (materieCBModif.Enabled == true)
            {
                materieCBModif.Text = "";
                materieCBModif.Enabled = false;
                label10.Visible = false;
            }
            if (notaCBModif.Enabled == true)
            {
                notaCBModif.Text = "";
                notaCBModif.Enabled = false;
                label11.Visible = false;
            }
            if (elevCBModif.Text != "")
            {
                materieCBModif.Enabled = true;
            }
            if (notaNouaCB.Enabled == true)
            {
                notaNouaCB.Enabled = false;
                notaNouaCB.Text = "";
                label12.Visible = false;
            }
            int k = elevCBModif.SelectedItem.ToString().IndexOf(" ");
            nume = elevCBModif.Text.Substring(0, k);
            int p = elevCBModif.Text.Length - k - 1;
            prenume = elevCBModif.Text.Substring(k + 1, p);
        }

        private void materieCBModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materieCBModif.SelectedIndex == -1)
                label10.Visible = true;
            if (materieCBModif.SelectedIndex != -1)
                label10.Visible = false;
            notaCBModif.Items.Clear();
            if (notaCBModif.Enabled == true)
            {
                notaCBModif.Text = "";
                notaCBModif.Enabled = false;
                label11.Visible = false;
            }
            if (notaNouaCB.Enabled == true)
            {
                notaNouaCB.Enabled = false;
                notaNouaCB.Text = "";
                label12.Visible = false;
            }
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Elevi WHERE Nume='" + nume + "' AND Prenume='" + prenume + "' AND Clasa= " + clasaCBModif.Text + " AND Litera= '" + literaCBModif.Text + "';", conn);
            SqlDataReader srd = cmd.ExecuteReader();
            srd.Read();
            id_elev = Convert.ToInt32(srd["Id"]);
            srd.Close();
            cmd = new SqlCommand("SELECT Nota, [Data] FROM Note WHERE Id_elev = " + id_elev + " AND Materie = '" + materieCBModif.Text + "';", conn);
            srd = cmd.ExecuteReader();
            string rowtxt;
            while (srd.Read())
            {
                for (int i = 0; i < srd.FieldCount; i++)
                {
                    rowtxt = srd.GetValue(i).ToString() + " - " + srd.GetValue(i+1).ToString();
                    notaCBModif.Items.Add(rowtxt);
                    i = i + 1;
                }
            }
            srd.Close();
            conn.Close();
            if (materieCBModif.Text != "")
            {
                notaCBModif.Enabled = true;
            }
        }

        private void notaCBModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notaCBModif.SelectedIndex == -1)
                label11.Visible = true;
            if (notaCBModif.SelectedIndex != -1)
                label11.Visible = false;
            if (notaNouaCB.Enabled == true)
            {
                notaNouaCB.Text = "";
                notaNouaCB.Enabled = false;
            }
            if (notaCBModif.Text != "")
            {
                notaNouaCB.Enabled = true;
            }
        }

        bool Completate()
        {
            if (clasaCBModif.Text.Length == 0)
            {
                return false;
            }
            else
                if(clasaCBModif.SelectedIndex == -1)
            {
                return false;
            }
            else
                if (literaCBModif.Text.Length == 0)
            {
                return false;
            }
            else
                if(literaCBModif.SelectedIndex == -1)
            {
                return false;
            }
            else
                if (elevCBModif.Text.Length == 0)
            {
                return false;
            }
            else
                if(elevCBModif.SelectedIndex == -1)
            {
                return false;
            }
            else
                if (materieCBModif.Text.Length == 0)
            { 
                return false;
            }
            else
                if(materieCBModif.SelectedIndex == -1)
            {
                return false;
            }
            else
                if (notaCBModif.Text.Length == 0)
            {
                return false;
            }
            else
                if(notaCBModif.SelectedIndex == -1)
            {
                return false;
            }
            else
                if(notaNouaCB.Text.Length == 0)
            {
                return false;
            }
            else
                if(notaNouaCB.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void modifBTNModif_Click(object sender, EventArgs e)
        {
            if(Completate())
            {
                string nota = notaCBModif.Text.Substring(0, notaCBModif.Text.IndexOf(" "));
                if(notaNouaCB.Text == nota)
                {
                    MessageBox.Show("Nota nouă și nota veche coincid!", "A T E N T I E !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                    conn.Open();
                    DateTime dataaux = Convert.ToDateTime(notaCBModif.Text.Substring(notaCBModif.Text.IndexOf(" ")+2,notaCBModif.Text.Length - notaCBModif.Text.IndexOf(" ")-2));
                    SqlCommand cmd = new SqlCommand("UPDATE Note SET Nota= " + notaNouaCB.Text + " WHERE Id_elev=" + id_elev + " AND Materie='" + materieCBModif.Text + "' AND Data= '" + dataaux + "';", conn);
                    if (conn == null)
                        conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                    else
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    int resut = cmd.ExecuteNonQuery();
                    if (resut > 0)
                    {
                        MessageBox.Show("Modificare notă cu success !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Modificare_Nota_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Eroare la modificarea notei !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void clasaCBModif_TextChanged(object sender, EventArgs e)
        {
            if (clasaCBModif.Text != clasaCBModif.SelectedIndex.ToString())
                label8.Visible = true;
            if (clasaCBModif.Text == clasaCBModif.SelectedIndex.ToString())
                label8.Visible = false;
        }

        private void literaCBModif_TextChanged(object sender, EventArgs e)
        {
            if (literaCBModif.Text != literaCBModif.SelectedIndex.ToString())
                label3.Visible = true;
            if (literaCBModif.Text == literaCBModif.SelectedIndex.ToString())
                label3.Visible = false;
        }

        private void elevCBModif_TextChanged(object sender, EventArgs e)
        {
            if (elevCBModif.Text != elevCBModif.SelectedIndex.ToString())
                label9.Visible = true;
            if (elevCBModif.Text == elevCBModif.SelectedIndex.ToString())
                label9.Visible = false;
        }

        private void materieCBModif_TextChanged(object sender, EventArgs e)
        {
            if (materieCBModif.Text != materieCBModif.SelectedIndex.ToString())
                label10.Visible = true;
            if (materieCBModif.Text == materieCBModif.SelectedIndex.ToString())
                label10.Visible = false;
        }

        private void notaCBModif_TextChanged(object sender, EventArgs e)
        {
            if (notaCBModif.Text != notaCBModif.SelectedIndex.ToString())
                label11.Visible = true;
            if (notaCBModif.Text == notaCBModif.SelectedIndex.ToString())
                label11.Visible = false;
        }

        private void notaNouaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notaNouaCB.SelectedIndex == -1)
                label12.Visible = true;
            if (notaNouaCB.SelectedIndex != -1)
                label12.Visible = false;
        }

        private void notaNouaCB_TextChanged(object sender, EventArgs e)
        {
            if (notaNouaCB.Text != notaNouaCB.SelectedIndex.ToString())
                label12.Visible = true;
            if (notaNouaCB.Text == notaNouaCB.SelectedIndex.ToString())
                label12.Visible = false;
        }

        private void Modificare_Nota_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin mainFrm = new Admin();
            mainFrm.Show();
        }
    }
}
