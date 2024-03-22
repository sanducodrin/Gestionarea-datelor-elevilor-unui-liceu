
namespace Atestat
{
    partial class Notare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notare));
            this.notareBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.literaCB = new System.Windows.Forms.ComboBox();
            this.notaCB = new System.Windows.Forms.ComboBox();
            this.materieCB = new System.Windows.Forms.ComboBox();
            this.elevCB = new System.Windows.Forms.ComboBox();
            this.clasaCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notareBTN
            // 
            this.notareBTN.BackColor = System.Drawing.Color.Wheat;
            this.notareBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notareBTN.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.notareBTN.Location = new System.Drawing.Point(395, 311);
            this.notareBTN.Name = "notareBTN";
            this.notareBTN.Size = new System.Drawing.Size(170, 43);
            this.notareBTN.TabIndex = 21;
            this.notareBTN.Text = "Notează";
            this.notareBTN.UseVisualStyleBackColor = false;
            this.notareBTN.Click += new System.EventHandler(this.notareBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataDTP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.literaCB);
            this.panel1.Controls.Add(this.notaCB);
            this.panel1.Controls.Add(this.materieCB);
            this.panel1.Controls.Add(this.elevCB);
            this.panel1.Controls.Add(this.clasaCB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 275);
            this.panel1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label7.Location = new System.Drawing.Point(27, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Elev";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(27, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Litera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Clasă";
            // 
            // dataDTP
            // 
            this.dataDTP.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.dataDTP.Location = new System.Drawing.Point(284, 200);
            this.dataDTP.Name = "dataDTP";
            this.dataDTP.Size = new System.Drawing.Size(213, 32);
            this.dataDTP.TabIndex = 20;
            this.dataDTP.Value = new System.DateTime(2021, 3, 14, 22, 52, 5, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label6.Location = new System.Drawing.Point(280, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data";
            // 
            // literaCB
            // 
            this.literaCB.Enabled = false;
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
            this.literaCB.Location = new System.Drawing.Point(31, 130);
            this.literaCB.Name = "literaCB";
            this.literaCB.Size = new System.Drawing.Size(121, 31);
            this.literaCB.TabIndex = 11;
            this.literaCB.SelectedIndexChanged += new System.EventHandler(this.literaCB_SelectedIndexChanged);
            // 
            // notaCB
            // 
            this.notaCB.Enabled = false;
            this.notaCB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.notaCB.FormattingEnabled = true;
            this.notaCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.notaCB.Location = new System.Drawing.Point(284, 130);
            this.notaCB.Name = "notaCB";
            this.notaCB.Size = new System.Drawing.Size(121, 31);
            this.notaCB.TabIndex = 9;
            // 
            // materieCB
            // 
            this.materieCB.Enabled = false;
            this.materieCB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.materieCB.FormattingEnabled = true;
            this.materieCB.Items.AddRange(new object[] {
            "Biologie",
            "Chimie",
            "Educatie fizica si sport ",
            "Educatie muzicala ",
            "Educatie plastica ",
            "Fizica",
            "Geografie ",
            "Informatica ",
            "Istoria ",
            "Limba Engleza",
            "Limba Franceza ",
            "Limba Germana ",
            "Limba Latina ",
            "Limba si literatura romana",
            "Matematica ",
            "Religie ",
            "Stiinte socio-umane ",
            "TIC "});
            this.materieCB.Location = new System.Drawing.Point(284, 59);
            this.materieCB.Name = "materieCB";
            this.materieCB.Size = new System.Drawing.Size(213, 31);
            this.materieCB.TabIndex = 8;
            this.materieCB.SelectedIndexChanged += new System.EventHandler(this.materieCB_SelectedIndexChanged);
            // 
            // elevCB
            // 
            this.elevCB.Enabled = false;
            this.elevCB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.elevCB.FormattingEnabled = true;
            this.elevCB.Location = new System.Drawing.Point(31, 201);
            this.elevCB.Name = "elevCB";
            this.elevCB.Size = new System.Drawing.Size(213, 31);
            this.elevCB.Sorted = true;
            this.elevCB.TabIndex = 7;
            this.elevCB.SelectedIndexChanged += new System.EventHandler(this.elevCB_SelectedIndexChanged);
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
            this.clasaCB.Location = new System.Drawing.Point(31, 59);
            this.clasaCB.Name = "clasaCB";
            this.clasaCB.Size = new System.Drawing.Size(121, 31);
            this.clasaCB.TabIndex = 6;
            this.clasaCB.SelectedIndexChanged += new System.EventHandler(this.clasaCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(280, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Materie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(280, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notă";
            // 
            // Notare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(193)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notareBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Notare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notare_FormClosing);
            this.Load += new System.EventHandler(this.Notare_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button notareBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox notaCB;
        private System.Windows.Forms.ComboBox materieCB;
        private System.Windows.Forms.ComboBox elevCB;
        private System.Windows.Forms.ComboBox clasaCB;
        private System.Windows.Forms.ComboBox literaCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}