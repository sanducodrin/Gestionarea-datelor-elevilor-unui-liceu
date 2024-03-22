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
    public partial class Stergere_User : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        int currentRow;
        int rowNumber;

        public Stergere_User()
        {
            InitializeComponent();
        }

        private void Stergere_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin mainFrm = new Admin();
            mainFrm.Show();
        }

        private void Stergere_User_Load(object sender, EventArgs e)
        {
            string query = "SELECT u.* FROM Utilizatori u";

            conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet("Utilizatori");
            da.Fill(ds, "Utilizatori");
            currentRow = 0;
            rowNumber = ds.Tables[0].Rows.Count;

            navigate();
        }

        private void firstBtnStg_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            navigate();
        }

        private void prevBtnStg_Click(object sender, EventArgs e)
        {
            if (currentRow == 0)
                currentRow = rowNumber;
            currentRow--;
            navigate();
        }

        private void nextBtnStg_Click(object sender, EventArgs e)
        {
            if (currentRow < rowNumber - 1)
                currentRow++;
            else
                currentRow = 0;
            navigate();
        }

        private void lastBtnStg_Click(object sender, EventArgs e)
        {
            currentRow = rowNumber - 1;
            navigate();
        }

        private void StergereBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteți sigur că doriți să ștergeți utilizatorul " + usernameTbStg.Text + "?", "ATENTIE!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                string query = "DELETE FROM Utilizatori WHERE Username = '" + usernameTbStg.Text + "';";

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
                    Stergere_User_Load(sender, e);
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

            numeTbStg.Text = dr.ItemArray[4].ToString() + " " + dr.ItemArray[5].ToString();
            //prenumeTbStg.Text = dr.ItemArray[5].ToString();
            usernameTbStg.Text = dr.ItemArray[2].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
