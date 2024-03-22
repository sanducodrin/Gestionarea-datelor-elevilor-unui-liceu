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
    public partial class Modificare_Elev : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        int rowNumber, currentRow;

        public Modificare_Elev()
        {
            InitializeComponent();
        }

        private void Modificare_Load(object sender, EventArgs e)
        {
            string query = "SELECT e.* FROM Elevi e";

            conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet("Elevi");
            da.Fill(ds, "Elevi");
            currentRow = 0;
            rowNumber = ds.Tables[0].Rows.Count;

            navigate();
        }

        private void FirstBTN_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            navigate();
        }

        private void PrevBTN_Click(object sender, EventArgs e)
        {
            if (currentRow == 0)
                currentRow = rowNumber;
            currentRow--;
            navigate();
        }

        private void NextBTN_Click(object sender, EventArgs e)
        {
            if (currentRow < rowNumber - 1)
                currentRow++;
            else
                currentRow = 0;
            navigate();
        }

        private void LastBTN_Click(object sender, EventArgs e)
        {
            currentRow = rowNumber - 1;
            navigate();
        }

        bool Completate()
        {
            if (numeTbModif.TextLength == 0)
            {
                label2.Visible = true;
                return false;
            }
            else
                if (prenumeTbModif.TextLength == 0)
            {
                label3.Visible = true;
                return false;
            }
            else
                if (dataNasteriiDTPModif == null)
            {
                label5.Visible = true;
                return false;
            }
            else
                if(varstaLABEL.Text=="")
            { 
                label5.Visible = true;
                return false;
            }
            else
                if (!fRbModif.Checked && !mRbModif.Checked)
            {
                label6.Visible = true;
                return false;
            }
            else
                if (nr_matricolTbMdif.TextLength == 0)
            {
                label16.Visible = true;
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

        private void ModifBTN_Click(object sender, EventArgs e)
        {
            if (Completate())
            {
                int GEN = 0;
                if (fRbModif.Checked == true)
                    GEN = 2;
                else
                    if (mRbModif.Checked == true)
                    GEN = 1;
                string query = "UPDATE Elevi SET Nume = '" + numeTbModif.Text + "', Prenume = '" + prenumeTbModif.Text + "', Varsta = " + varstaLABEL.Text + ", Clasa = " + clasaCB.Text + ", Litera = '" + literaCB.Text + "', Data_nasterii = '" + dataNasteriiDTPModif.Value.Date + "', Nr_matricol = '" + nr_matricolTbMdif.Text + "', Sex = " + GEN + " WHERE Id = " + ds.Tables[0].Rows[currentRow].ItemArray[0].ToString() + ";";

                if (conn == null)
                    conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                else
                    if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand comanda = new SqlCommand(query, conn);
                int rezultat = comanda.ExecuteNonQuery();
                if (rezultat > 0)
                {
                    MessageBox.Show("Modificare cu success !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Modificare_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Eroare la modificarea datelor !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void navigate()
        {
            dr = ds.Tables[0].Rows[currentRow];

            numeTbModif.Text = dr.ItemArray[1].ToString();
            prenumeTbModif.Text = dr.ItemArray[2].ToString();
            varstaLABEL.Text = dr.ItemArray[3].ToString();
            clasaCB.Text = dr.ItemArray[4].ToString();
            literaCB.Text = dr.ItemArray[5].ToString();
            dataNasteriiDTPModif.Text = dr.ItemArray[6].ToString();
            nr_matricolTbMdif.Text = dr.ItemArray[7].ToString();
            if (dr.ItemArray[8].ToString() == "1")
            {
                mRbModif.Checked = true;
                fRbModif.Checked = false;
            }
            else
                if (dr.ItemArray[8].ToString() == "2")
                {
                    fRbModif.Checked = true;
                    mRbModif.Checked = false;
                }
        }

        private void Modificare_Elev_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin mainFrm = new Admin();
            mainFrm.Show();
        }

        private void dataNasteriiDTPModif_ValueChanged(object sender, EventArgs e)
        {
            if (dataNasteriiDTPModif.Value == null)
                label5.Visible = true;
            else
                label5.Visible = false;
            if (DateTime.Now.DayOfYear < dataNasteriiDTPModif.Value.DayOfYear)
            {
                varstaLABEL.Text = (DateTime.Now.Year - dataNasteriiDTPModif.Value.Year - 1).ToString();
            }
            else
            {
                varstaLABEL.Text = (DateTime.Now.Year - dataNasteriiDTPModif.Value.Year).ToString();
            }
            if (Convert.ToInt32(varstaLABEL.Text) < 0)
                label4.Visible = true;
            else
                label4.Visible = false;
        }

        private void numeTbModif_TextChanged(object sender, EventArgs e)
        {
            if (numeTbModif.Text.Length == 0)
                label2.Visible = true;
            else
                label2.Visible = false;
        }

        private void prenumeTbModif_TextChanged(object sender, EventArgs e)
        {
            if (prenumeTbModif.Text.Length == 0)
                label3.Visible = true;
            else
                label3.Visible = false;
        }

        private void nr_matricolTbModif_TextChanged(object sender, EventArgs e)
        {
            if (nr_matricolTbMdif.Text.Length == 0)
                label16.Visible = true;
            else
                label16.Visible = false;
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
