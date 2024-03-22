
namespace Atestat
{
    partial class Logare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logare));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.parolaTB = new System.Windows.Forms.TextBox();
            this.liceuDataSet = new Atestat.LiceuDataSet();
            this.utilizatoriTableAdapter = new Atestat.LiceuDataSetTableAdapters.UtilizatoriTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.liceuDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(144, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(144, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parola:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.usernameTB.Location = new System.Drawing.Point(148, 67);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(205, 32);
            this.usernameTB.TabIndex = 2;
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.Wheat;
            this.LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn.Location = new System.Drawing.Point(148, 202);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(205, 42);
            this.LogIn.TabIndex = 4;
            this.LogIn.Text = "Login";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // parolaTB
            // 
            this.parolaTB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.parolaTB.Location = new System.Drawing.Point(148, 137);
            this.parolaTB.Name = "parolaTB";
            this.parolaTB.PasswordChar = '*';
            this.parolaTB.Size = new System.Drawing.Size(205, 32);
            this.parolaTB.TabIndex = 3;
            this.parolaTB.TextChanged += new System.EventHandler(this.parolaTB_TextChanged);
            // 
            // liceuDataSet
            // 
            this.liceuDataSet.DataSetName = "LiceuDataSet";
            this.liceuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(253, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Câmp obligatoriu";
            this.label12.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(253, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Câmp obligatoriu";
            this.label4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LogIn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.parolaTB);
            this.panel1.Controls.Add(this.usernameTB);
            this.panel1.Location = new System.Drawing.Point(55, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 279);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Atestat.Properties.Resources.Sample_User_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(268, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG IN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "label5";
            this.label6.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Logare
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(193)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(604, 497);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Logare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logare";
            this.Load += new System.EventHandler(this.Logare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liceuDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.TextBox parolaTB;
        private LiceuDataSet liceuDataSet;
        private LiceuDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }

}

