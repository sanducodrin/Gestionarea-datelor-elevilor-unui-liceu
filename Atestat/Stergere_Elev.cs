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
    public partial class Stergere_Elev : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        int currentRow;
        int rowNumber;

        public Stergere_Elev()
        {
            InitializeComponent();
        }

        private void Stergere_Elev_Load(object sender, EventArgs e)
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

        private void firstBtn_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            navigate();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentRow == 0)
                currentRow = rowNumber;
            currentRow--;
            navigate();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentRow < rowNumber - 1)
                currentRow++;
            else
                currentRow = 0;
            navigate();
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            currentRow = rowNumber - 1;
            navigate();
        }

        private void ModifBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteți sigur că doriți să stergeți elevul " + numeTb.Text + "?", "ATENTIE!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM Utilizatori WHERE Id_elev = " + ds.Tables[0].Rows[currentRow].ItemArray[0].ToString() + "; DELETE FROM Note WHERE Id_elev = " + ds.Tables[0].Rows[currentRow].ItemArray[0].ToString() + "; DELETE FROM Elevi WHERE Id = " + ds.Tables[0].Rows[currentRow].ItemArray[0].ToString() + ";";

                if (conn == null)
                    conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                else
                    if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand comanda = new SqlCommand(query, conn);
                int rezultat = comanda.ExecuteNonQuery();
                if (rezultat > 0)
                {
                    MessageBox.Show("Ștergere cu success !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Stergere_Elev_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Eroare la ștergerea datelor !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void navigate()
        {
            dr = ds.Tables[0].Rows[currentRow];

            numeTb.Text = dr.ItemArray[1].ToString() + " " + dr.ItemArray[2].ToString();
            //prenumeTb.Text = dr.ItemArray[2].ToString();
            clasaTb.Text = dr.ItemArray[4].ToString() + " " + dr.ItemArray[5].ToString();
            //literaTb.Text = dr.ItemArray[5].ToString();
            numarTb.Text = dr.ItemArray[7].ToString();
            DateTime nastere = Convert.ToDateTime(dr.ItemArray[6]);
            dataNasteriiTB.Text = nastere.Day.ToString() + ". " + nastere.Month.ToString() + ". " + nastere.Year.ToString();
        }

        private void Stergere_Elev_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin mainFrm = new Admin();
            mainFrm.Show();
        }
    }
}
