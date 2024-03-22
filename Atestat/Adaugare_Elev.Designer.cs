
namespace Atestat
{
    partial class Adaugare_Elev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adaugare_Elev));
            this.FRB = new System.Windows.Forms.RadioButton();
            this.dataNasteriiDTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.MRB = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.PrenumeTB = new System.Windows.Forms.TextBox();
            this.NumeTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdaugaBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nr_matricolTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.literaCB = new System.Windows.Forms.ComboBox();
            this.clasaCB = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FRB
            // 
            this.FRB.AutoSize = true;
            this.FRB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.FRB.Location = new System.Drawing.Point(30, 350);
            this.FRB.Name = "FRB";
            this.FRB.Size = new System.Drawing.Size(38, 27);
            this.FRB.TabIndex = 4;
            this.FRB.TabStop = true;
            this.FRB.Text = "F";
            this.FRB.UseVisualStyleBackColor = true;
            this.FRB.CheckedChanged += new System.EventHandler(this.FRB_CheckedChanged);
            // 
            // dataNasteriiDTP
            // 
            this.dataNasteriiDTP.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.dataNasteriiDTP.Location = new System.Drawing.Point(31, 201);
            this.dataNasteriiDTP.Name = "dataNasteriiDTP";
            this.dataNasteriiDTP.Size = new System.Drawing.Size(261, 32);
            this.dataNasteriiDTP.TabIndex = 2;
            this.dataNasteriiDTP.Value = new System.DateTime(2021, 3, 14, 22, 52, 5, 0);
            this.dataNasteriiDTP.ValueChanged += new System.EventHandler(this.dataNasteriiDTP_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelVarsta);
            this.groupBox1.Controls.Add(this.dataNasteriiDTP);
            this.groupBox1.Controls.Add(this.FRB);
            this.groupBox1.Controls.Add(this.MRB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PrenumeTB);
            this.groupBox1.Controls.Add(this.NumeTB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informații cu caracter personal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(193, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Câmp obligatoriu";
            this.label12.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(146, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Câmp completat incorect";
            this.label16.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(193, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Câmp obligatoriu";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(193, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Câmp obligatoriu";
            this.label10.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(193, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Câmp obligatoriu";
            this.label1.Visible = false;
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.labelVarsta.Location = new System.Drawing.Point(117, 251);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(21, 23);
            this.labelVarsta.TabIndex = 20;
            this.labelVarsta.Text = "0";
            // 
            // MRB
            // 
            this.MRB.AutoSize = true;
            this.MRB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.MRB.Location = new System.Drawing.Point(31, 317);
            this.MRB.Name = "MRB";
            this.MRB.Size = new System.Drawing.Size(45, 27);
            this.MRB.TabIndex = 3;
            this.MRB.TabStop = true;
            this.MRB.Text = "M";
            this.MRB.UseVisualStyleBackColor = true;
            this.MRB.CheckedChanged += new System.EventHandler(this.MRB_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label9.Location = new System.Drawing.Point(27, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sex";
            // 
            // PrenumeTB
            // 
            this.PrenumeTB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.PrenumeTB.Location = new System.Drawing.Point(31, 130);
            this.PrenumeTB.Name = "PrenumeTB";
            this.PrenumeTB.Size = new System.Drawing.Size(261, 32);
            this.PrenumeTB.TabIndex = 1;
            this.PrenumeTB.TextChanged += new System.EventHandler(this.PrenumeTB_TextChanged);
            // 
            // NumeTB
            // 
            this.NumeTB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.NumeTB.Location = new System.Drawing.Point(31, 59);
            this.NumeTB.Name = "NumeTB";
            this.NumeTB.Size = new System.Drawing.Size(261, 32);
            this.NumeTB.TabIndex = 0;
            this.NumeTB.TextChanged += new System.EventHandler(this.NumeTB_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Data Naşterii";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label7.Location = new System.Drawing.Point(27, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vârsta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label6.Location = new System.Drawing.Point(27, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prenume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(27, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nume";
            // 
            // AdaugaBTN
            // 
            this.AdaugaBTN.BackColor = System.Drawing.Color.Wheat;
            this.AdaugaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdaugaBTN.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.AdaugaBTN.Location = new System.Drawing.Point(503, 336);
            this.AdaugaBTN.Name = "AdaugaBTN";
            this.AdaugaBTN.Size = new System.Drawing.Size(170, 43);
            this.AdaugaBTN.TabIndex = 2;
            this.AdaugaBTN.Text = "Adaugă";
            this.AdaugaBTN.UseVisualStyleBackColor = false;
            this.AdaugaBTN.Click += new System.EventHandler(this.AdaugaBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(55, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(55, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Litera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Număr matricol";
            // 
            // Nr_matricolTB
            // 
            this.Nr_matricolTB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.Nr_matricolTB.Location = new System.Drawing.Point(58, 47);
            this.Nr_matricolTB.Name = "Nr_matricolTB";
            this.Nr_matricolTB.Size = new System.Drawing.Size(122, 32);
            this.Nr_matricolTB.TabIndex = 0;
            this.Nr_matricolTB.TextChanged += new System.EventHandler(this.Nr_matricolTB_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.literaCB);
            this.panel1.Controls.Add(this.clasaCB);
            this.panel1.Controls.Add(this.Nr_matricolTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(456, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 250);
            this.panel1.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(80, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "Câmp obligatoriu";
            this.label15.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(56, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 16);
            this.label18.TabIndex = 21;
            this.label18.Text = "Câmp completat incorect";
            this.label18.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(56, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "Câmp completat incorect";
            this.label17.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(80, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Câmp obligatoriu";
            this.label14.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(80, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Câmp obligatoriu";
            this.label13.Visible = false;
            // 
            // literaCB
            // 
            this.literaCB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.literaCB.FormattingEnabled = true;
            this.literaCB.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.literaCB.Location = new System.Drawing.Point(59, 193);
            this.literaCB.Name = "literaCB";
            this.literaCB.Size = new System.Drawing.Size(121, 31);
            this.literaCB.TabIndex = 2;
            this.literaCB.SelectedIndexChanged += new System.EventHandler(this.literaCB_SelectedIndexChanged);
            this.literaCB.TextChanged += new System.EventHandler(this.literaCB_TextChanged);
            // 
            // clasaCB
            // 
            this.clasaCB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.clasaCB.FormattingEnabled = true;
            this.clasaCB.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.clasaCB.Location = new System.Drawing.Point(59, 118);
            this.clasaCB.Name = "clasaCB";
            this.clasaCB.Size = new System.Drawing.Size(121, 31);
            this.clasaCB.TabIndex = 1;
            this.clasaCB.SelectedIndexChanged += new System.EventHandler(this.clasaCB_SelectedIndexChanged);
            this.clasaCB.TextChanged += new System.EventHandler(this.clasaCB_TextChanged);
            // 
            // Adaugare_Elev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(193)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(756, 453);
            this.Controls.Add(this.AdaugaBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Adaugare_Elev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adăugare elev";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Adaugare_Elev_FormClosing);
            this.Load += new System.EventHandler(this.Adaugare_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton FRB;
        private System.Windows.Forms.DateTimePicker dataNasteriiDTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MRB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PrenumeTB;
        private System.Windows.Forms.TextBox NumeTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AdaugaBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nr_matricolTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelVarsta;
        private System.Windows.Forms.ComboBox clasaCB;
        private System.Windows.Forms.ComboBox literaCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}