
namespace Atestat
{
    partial class Stergere_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stergere_User));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numeTbStg = new System.Windows.Forms.TextBox();
            this.usernameTbStg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstBtnStg = new System.Windows.Forms.Button();
            this.prevBtnStg = new System.Windows.Forms.Button();
            this.lastBtnStg = new System.Windows.Forms.Button();
            this.nextBtnStg = new System.Windows.Forms.Button();
            this.StergereBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.numeTbStg);
            this.panel1.Controls.Add(this.usernameTbStg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 186);
            this.panel1.TabIndex = 1;
            // 
            // numeTbStg
            // 
            this.numeTbStg.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.numeTbStg.Location = new System.Drawing.Point(34, 124);
            this.numeTbStg.Name = "numeTbStg";
            this.numeTbStg.ReadOnly = true;
            this.numeTbStg.Size = new System.Drawing.Size(223, 32);
            this.numeTbStg.TabIndex = 6;
            this.numeTbStg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameTbStg
            // 
            this.usernameTbStg.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.usernameTbStg.Location = new System.Drawing.Point(34, 47);
            this.usernameTbStg.Name = "usernameTbStg";
            this.usernameTbStg.ReadOnly = true;
            this.usernameTbStg.Size = new System.Drawing.Size(223, 32);
            this.usernameTbStg.TabIndex = 5;
            this.usernameTbStg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstBtnStg
            // 
            this.firstBtnStg.BackColor = System.Drawing.Color.Wheat;
            this.firstBtnStg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstBtnStg.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.firstBtnStg.Location = new System.Drawing.Point(22, 218);
            this.firstBtnStg.Name = "firstBtnStg";
            this.firstBtnStg.Size = new System.Drawing.Size(58, 43);
            this.firstBtnStg.TabIndex = 8;
            this.firstBtnStg.Text = "|<";
            this.firstBtnStg.UseVisualStyleBackColor = false;
            this.firstBtnStg.Click += new System.EventHandler(this.firstBtnStg_Click);
            // 
            // prevBtnStg
            // 
            this.prevBtnStg.BackColor = System.Drawing.Color.Wheat;
            this.prevBtnStg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBtnStg.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.prevBtnStg.Location = new System.Drawing.Point(86, 218);
            this.prevBtnStg.Name = "prevBtnStg";
            this.prevBtnStg.Size = new System.Drawing.Size(58, 43);
            this.prevBtnStg.TabIndex = 9;
            this.prevBtnStg.Text = "<";
            this.prevBtnStg.UseVisualStyleBackColor = false;
            this.prevBtnStg.Click += new System.EventHandler(this.prevBtnStg_Click);
            // 
            // lastBtnStg
            // 
            this.lastBtnStg.BackColor = System.Drawing.Color.Wheat;
            this.lastBtnStg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastBtnStg.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lastBtnStg.Location = new System.Drawing.Point(264, 218);
            this.lastBtnStg.Name = "lastBtnStg";
            this.lastBtnStg.Size = new System.Drawing.Size(58, 43);
            this.lastBtnStg.TabIndex = 10;
            this.lastBtnStg.Text = ">|";
            this.lastBtnStg.UseVisualStyleBackColor = false;
            this.lastBtnStg.Click += new System.EventHandler(this.lastBtnStg_Click);
            // 
            // nextBtnStg
            // 
            this.nextBtnStg.BackColor = System.Drawing.Color.Wheat;
            this.nextBtnStg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtnStg.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.nextBtnStg.Location = new System.Drawing.Point(200, 218);
            this.nextBtnStg.Name = "nextBtnStg";
            this.nextBtnStg.Size = new System.Drawing.Size(58, 43);
            this.nextBtnStg.TabIndex = 11;
            this.nextBtnStg.Text = ">";
            this.nextBtnStg.UseVisualStyleBackColor = false;
            this.nextBtnStg.Click += new System.EventHandler(this.nextBtnStg_Click);
            // 
            // StergereBTN
            // 
            this.StergereBTN.BackColor = System.Drawing.Color.Wheat;
            this.StergereBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StergereBTN.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.StergereBTN.Location = new System.Drawing.Point(86, 267);
            this.StergereBTN.Name = "StergereBTN";
            this.StergereBTN.Size = new System.Drawing.Size(172, 45);
            this.StergereBTN.TabIndex = 12;
            this.StergereBTN.Text = "Şterge";
            this.StergereBTN.UseVisualStyleBackColor = false;
            this.StergereBTN.Click += new System.EventHandler(this.StergereBTN_Click);
            // 
            // Stergere_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(193)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(348, 333);
            this.Controls.Add(this.StergereBTN);
            this.Controls.Add(this.nextBtnStg);
            this.Controls.Add(this.lastBtnStg);
            this.Controls.Add(this.prevBtnStg);
            this.Controls.Add(this.firstBtnStg);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stergere_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stergere User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stergere_User_FormClosing);
            this.Load += new System.EventHandler(this.Stergere_User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox numeTbStg;
        private System.Windows.Forms.TextBox usernameTbStg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button firstBtnStg;
        private System.Windows.Forms.Button prevBtnStg;
        private System.Windows.Forms.Button lastBtnStg;
        private System.Windows.Forms.Button nextBtnStg;
        private System.Windows.Forms.Button StergereBTN;
    }
}