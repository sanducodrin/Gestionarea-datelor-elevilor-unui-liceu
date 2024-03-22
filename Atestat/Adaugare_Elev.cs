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
    public partial class Adaugare_Elev : Form
    {
        SqlConnection connection;
        public Adaugare_Elev()
        {
            InitializeComponent();
        }

        private void MRB_CheckedChanged(object sender, EventArgs e)
        { 
            if (FRB.Checked)
            { 
                FRB.Checked = false;
                MRB.Checked = true;
            }
            label12.Visible = false;
        }

        private void FRB_CheckedChanged(object sender, EventArgs e)
        {
            if (MRB.Checked)
            {
                MRB.Checked = false;
                FRB.Checked = true;
            }
            label12.Visible = false;
        }

        bool Completate()
        {
            if (NumeTB.TextLength == 0)
            {
                label1.Visible = true;

                return false;
            }
            else
                if (PrenumeTB.TextLength == 0)
            {
                label10.Visible = true;

                return false;
            }
            else
                if (dataNasteriiDTP == null)
            {
                label11.Visible = true;

                return false;
            }
            else
                if(labelVarsta.Text=="")
            {
                label11.Visible = true;

                return false;
            }
            else
                if (!FRB.Checked && !MRB.Checked)
            {
                label12.Visible = true;

                return false;
            }
            else
                if (Nr_matricolTB.TextLength == 0)
            {
                label13.Visible = true;

                return false;
            }
            else
                if (clasaCB.Text.Length == 0)
            {
                label14.Visible = true;

                return false;
            }
            else
                if (clasaCB.SelectedIndex == -1)
            {
                label17.Visible = true;

                return false;
            }
            else
                if (literaCB.Text.Length == 0)
            {
                label15.Visible = true;

                return false;
            }
            else
                if (literaCB.SelectedIndex == -1)
            {
                label18.Visible = true;
                return false;
            }
            return true;
        }

        private void AdaugaBTN_Click(object sender, EventArgs e)
        {
            if(Completate())
            {
                int GEN;
                if (FRB.Checked == true)
                    GEN = 2;
                else
                    GEN = 1;
                string query_add = "INSERT INTO Elevi(Nume, Prenume, Varsta, Clasa, Litera, Data_nasterii, Nr_matricol, Sex) VALUES('" + NumeTB.Text + "', '" + PrenumeTB.Text + "', " + labelVarsta.Text + ", " + clasaCB.SelectedItem.ToString() + ", '" + literaCB.SelectedItem.ToString() + "', '" + dataNasteriiDTP.Value.Date + "', '" + Nr_matricolTB.Text + "', " + GEN + ");";
                if (connection == null)
                    connection = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                else
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                SqlCommand cmd = new SqlCommand(query_add, connection);
                int resut = cmd.ExecuteNonQuery();
                if (resut > 0)
                {
                    MessageBox.Show("Adăugare cu success !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Adaugare_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Eroare la adăugare datelor !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Adaugare_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            Nr_matricolTB.Clear();
            clasaCB.Text = "";
            literaCB.Text = "";
            NumeTB.Clear();
            PrenumeTB.Clear();
            dataNasteriiDTP.Value=DateTime.Now;
            FRB.Checked = false;
            MRB.Checked = false;
            labelVarsta.Text = "";
            label10.Visible = false;
            label1.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
        }

        private void Adaugare_Elev_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void dataNasteriiDTP_ValueChanged(object sender, EventArgs e)
        {
            if (dataNasteriiDTP.Value == null)
                label11.Visible = true;
            else
                label11.Visible = false;
            if (DateTime.Now.DayOfYear < dataNasteriiDTP.Value.DayOfYear)
            {
                labelVarsta.Text = (DateTime.Now.Year - dataNasteriiDTP.Value.Year - 1).ToString();
            }
            else
            {
                labelVarsta.Text = (DateTime.Now.Year - dataNasteriiDTP.Value.Year).ToString();
            }
            if (Convert.ToInt32(labelVarsta.Text) < 0)
                label16.Visible = true;
            else
                label16.Visible = false;
        }

        private void NumeTB_TextChanged(object sender, EventArgs e)
        {
            if (NumeTB.Text.Length == 0)
                label1.Visible = true;
            else
                label1.Visible = false;
        }

        private void PrenumeTB_TextChanged(object sender, EventArgs e)
        {
            if (PrenumeTB.Text.Length == 0)
                label10.Visible = true;
            else
                label10.Visible = false;
        }

        private void Nr_matricolTB_TextChanged(object sender, EventArgs e)
        {
            if (Nr_matricolTB.Text.Length == 0)
                label13.Visible = true;
            else
                label13.Visible = false;
        }

        private void clasaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clasaCB.SelectedIndex == -1)
                label17.Visible = true;
            if (clasaCB.SelectedIndex != -1)
                label17.Visible = false;
        }

        private void clasaCB_TextChanged(object sender, EventArgs e)
        {
            label14.Visible = false;
            if (clasaCB.Text != clasaCB.SelectedIndex.ToString())
                label17.Visible = true;
            if (clasaCB.Text == clasaCB.SelectedIndex.ToString())
                label17.Visible = false;
            if (clasaCB.Text == "")
            {
                label14.Visible = true;
                label17.Visible = false;
            }
        }

        private void literaCB_TextChanged(object sender, EventArgs e)
        {
            label15.Visible = false;
            if (literaCB.Text != literaCB.SelectedIndex.ToString())
                label18.Visible = true;
            if (literaCB.Text == literaCB.SelectedIndex.ToString())
                label18.Visible = false;
            if (literaCB.Text == "")
            {
                label15.Visible = true;
                label18.Visible = false;
            }
        }

        private void literaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (literaCB.SelectedIndex == -1)
                label18.Visible = true;
            if (literaCB.SelectedIndex != -1)
                label18.Visible = false;
        }
    }
}
