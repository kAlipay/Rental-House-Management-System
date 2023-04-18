namespace RentalHouseManagementSystem
{
    partial class frmuploadfiles
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
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnupload = new System.Windows.Forms.Button();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lbltenid = new System.Windows.Forms.Label();
            this.cbofiles = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(116, 145);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(380, 24);
            this.ProgressBar1.TabIndex = 32;
            // 
            // btnupload
            // 
            this.btnupload.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnupload.Location = new System.Drawing.Point(12, 141);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(98, 28);
            this.btnupload.TabIndex = 29;
            this.btnupload.Text = "Upload";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // txtlocation
            // 
            this.txtlocation.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtlocation.Location = new System.Drawing.Point(12, 110);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(380, 23);
            this.txtlocation.TabIndex = 28;
            this.txtlocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged_1);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(60, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(172, 23);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Upload Scanned Files";
            // 
            // lbltenid
            // 
            this.lbltenid.AutoSize = true;
            this.lbltenid.Location = new System.Drawing.Point(432, 114);
            this.lbltenid.Name = "lbltenid";
            this.lbltenid.Size = new System.Drawing.Size(40, 13);
            this.lbltenid.TabIndex = 31;
            this.lbltenid.Text = "lbltenid";
            // 
            // cbofiles
            // 
            this.cbofiles.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofiles.FormattingEnabled = true;
            this.cbofiles.Items.AddRange(new object[] {
            "ID",
            "Contract",
            "Other Documents"});
            this.cbofiles.Location = new System.Drawing.Point(64, 71);
            this.cbofiles.Name = "cbofiles";
            this.cbofiles.Size = new System.Drawing.Size(228, 23);
            this.cbofiles.TabIndex = 35;
            this.cbofiles.Text = "Select what file to be upload";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.Label3.Location = new System.Drawing.Point(298, 71);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(222, 18);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "Ex: ID, Contract, Other Documents.";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(17, 71);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 18);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "Files :";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "OpenFileDialog1";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Location = new System.Drawing.Point(398, 105);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(98, 28);
            this.btnbrowse.TabIndex = 36;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // frmuploadfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(521, 197);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lbltenid);
            this.Controls.Add(this.cbofiles);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmuploadfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Files";
            this.Load += new System.EventHandler(this.uploadfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Button btnupload;
        internal System.Windows.Forms.TextBox txtlocation;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lbltenid;
        internal System.Windows.Forms.ComboBox cbofiles;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnbrowse;
    }
}