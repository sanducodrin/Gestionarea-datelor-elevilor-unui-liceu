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
    public partial class Modificare_User : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        int rowNumber, currentRow;

        public Modificare_User()
        {
            InitializeComponent();
        }

        private void Modificare_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin mainFrm = new Admin();
            mainFrm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private bool Completate()
        {
            if(infGenNumeTB.Text.Length == 0)
            {
                label4.Visible = true;
                return false;
            }
            else
                if(infGenPrenumeTB.Text.Length == 0)
            {
                label7.Visible = true;
                return false;
            }
            else
                if(credUserTB.Text.Length == 0)
            {
                label8.Visible = true;
                return false;
            }
            else
                if(credParolaNouaTB.Text != credConfParolaTB.Text)
            {
                label30.Visible = true;
                return false;
            }
            return true;
        }

        private void ModifBTN_Click(object sender, EventArgs e)
        {
            if(Completate())
            {
                dr = ds.Tables[0].Rows[currentRow];
                string query="";
                if (adminRB.Checked == true)
                {
                    if (Convert.ToInt32(dr.ItemArray[6]) == 1)
                    {
                        conn = new SqlConnection(Properties.Settings.Default.LiceuConnectionString);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Note WHERE Id_elev = " + dr.ItemArray[1].ToString() + ";", conn);
                        cmd.ExecuteNonQuery();
                    }
                    if(credParolaNouaTB.Text.Length == 0)
                        query = "UPDATE Utilizatori SET Nume = '" + infGenNumeTB.Text + "', Prenume = '" + infGenPrenumeTB.Text + "', Tip_user = 2, Username = '" + credUserTB.Text + "', Id_elev = NULL WHERE Id = " + dr.ItemArray[0].ToString() + ";";
                    else
                        query = "UPDATE Utilizatori SET Nume = '" + infGenNumeTB.Text + "', Prenume = '" + infGenPrenumeTB.Text + "', Tip_user = 2, Username = '" + credUserTB.Text + "', Parola = HASHBYTES('SHA2_256', '" + credParolaNouaTB.Text + "'), Id_elev = NULL WHERE Id = " + dr.ItemArray[0].ToString() + ";";
                }
                else
                {
                    if (Convert.ToInt32(dr.ItemArray[6]) == 2)
                        MessageBox.Show("Nu se poate modifica utilizatorul din administrator în elev", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (credParolaNouaTB.Text.Length == 0)
                            query = "UPDATE Utilizatori SET Nume = '" + infGenNumeTB.Text + "', Prenume = '" + infGenPrenumeTB.Text + "', Username = '" + credUserTB.Text + "' WHERE Id = " + dr.ItemArray[0].ToString() + ";";
                        else
                            query = "UPDATE Utilizatori SET Nume = '" + infGenNumeTB.Text + "', Prenume = '" + infGenPrenumeTB.Text + "', Username = '" + credUserTB.Text + "', Parola = HASHBYTES('SHA2_256', '" + credParolaNouaTB.Text + "') WHERE Id = " + dr.ItemArray[0].ToString() + ";";
                    }
                }

                if(elevRB.Checked == true && Convert.ToInt32(dr.ItemArray[6]) == 2)
                {

                }
                else
                {
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
                        Modificare_User_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Eroare la modificarea datelor !", "ATENTIE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void navigate()
        {
            dr = ds.Tables[0].Rows[currentRow];

            infGenNumeTB.Text = dr.ItemArray[4].ToString();
            infGenPrenumeTB.Text = dr.ItemArray[5].ToString();
            if(Convert.ToInt32(dr.ItemArray[6]) == 1)
            {
                elevRB.Checked = true;
                adminRB.Checked = false;
            }
            else
            {
                elevRB.Checked = false;
                adminRB.Checked = true;
            }
            credUserTB.Text = dr.ItemArray[2].ToString();
            credParolaNouaTB.Text = "";
            credConfParolaTB.Text = "";
        }

        private void infGenNumeTB_TextChanged(object sender, EventArgs e)
        {
            if (infGenNumeTB.Text.Length == 0)
                label4.Visible = true;
            else
                label4.Visible = false;
        }

        private void infGenPrenumeTB_TextChanged(object sender, EventArgs e)
        {
            if (infGenPrenumeTB.Text.Length == 0)
                label7.Visible = true;
            else
                label7.Visible = false;
        }

        private void elevRB_CheckedChanged(object sender, EventArgs e)
        {
            if(adminRB.Checked == true)
            {
                adminRB.Checked = false;
                elevRB.Checked = true;
            }
        }

        private void adminRB_CheckedChanged(object sender, EventArgs e)
        {
            if(elevRB.Checked == true)
            {
                elevRB.Checked = false;
                adminRB.Checked = true;
            }
        }

        private void credUserTB_TextChanged(object sender, EventArgs e)
        {
            if (credUserTB.Text.Length == 0)
                label8.Visible = true;
            else
                label8.Visible = false;
        }

        private void credConfParolaTB_TextChanged(object sender, EventArgs e)
        {
            label30.Visible = false;
            if (credConfParolaTB.Text != credParolaNouaTB.Text)
                label30.Visible = true;
        }

        private void Modificare_User_Load(object sender, EventArgs e)
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
    }
}
