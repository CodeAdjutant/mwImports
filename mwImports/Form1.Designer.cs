namespace mwImports
{
    partial class Form1
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
            this.ckMalcode = new System.Windows.Forms.CheckBox();
            this.ckMwDomains = new System.Windows.Forms.CheckBox();
            this.ckMwDomList = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.tbMal0de = new System.Windows.Forms.TextBox();
            this.tbMwd = new System.Windows.Forms.TextBox();
            this.tbMwdl = new System.Windows.Forms.TextBox();
            this.btGetData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckMalcode
            // 
            this.ckMalcode.AutoSize = true;
            this.ckMalcode.Location = new System.Drawing.Point(23, 25);
            this.ckMalcode.Name = "ckMalcode";
            this.ckMalcode.Size = new System.Drawing.Size(89, 17);
            this.ckMalcode.TabIndex = 0;
            this.ckMalcode.Text = "malc0de.com";
            this.ckMalcode.UseVisualStyleBackColor = true;
            // 
            // ckMwDomains
            // 
            this.ckMwDomains.AutoSize = true;
            this.ckMwDomains.Location = new System.Drawing.Point(23, 87);
            this.ckMwDomains.Name = "ckMwDomains";
            this.ckMwDomains.Size = new System.Drawing.Size(127, 17);
            this.ckMwDomains.TabIndex = 1;
            this.ckMwDomains.Text = "malwaredomains.com";
            this.ckMwDomains.UseVisualStyleBackColor = true;
            // 
            // ckMwDomList
            // 
            this.ckMwDomList.AutoSize = true;
            this.ckMwDomList.Location = new System.Drawing.Point(23, 162);
            this.ckMwDomList.Name = "ckMwDomList";
            this.ckMwDomList.Size = new System.Drawing.Size(134, 17);
            this.ckMwDomList.TabIndex = 2;
            this.ckMwDomList.Text = "malwaredomainlist.com";
            this.ckMwDomList.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check Updates";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(20, 260);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 4;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(20, 308);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 5;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(20, 244);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(33, 13);
            this.lbFrom.TabIndex = 6;
            this.lbFrom.Text = "From:";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(20, 292);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(23, 13);
            this.lbTo.TabIndex = 7;
            this.lbTo.Text = "To:";
            // 
            // tbMal0de
            // 
            this.tbMal0de.BackColor = System.Drawing.SystemColors.Control;
            this.tbMal0de.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMal0de.Location = new System.Drawing.Point(20, 48);
            this.tbMal0de.Multiline = true;
            this.tbMal0de.Name = "tbMal0de";
            this.tbMal0de.Size = new System.Drawing.Size(200, 33);
            this.tbMal0de.TabIndex = 8;
            // 
            // tbMwd
            // 
            this.tbMwd.BackColor = System.Drawing.SystemColors.Control;
            this.tbMwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMwd.Location = new System.Drawing.Point(23, 110);
            this.tbMwd.Multiline = true;
            this.tbMwd.Name = "tbMwd";
            this.tbMwd.Size = new System.Drawing.Size(197, 46);
            this.tbMwd.TabIndex = 9;
            // 
            // tbMwdl
            // 
            this.tbMwdl.BackColor = System.Drawing.SystemColors.Control;
            this.tbMwdl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMwdl.Location = new System.Drawing.Point(20, 185);
            this.tbMwdl.Multiline = true;
            this.tbMwdl.Name = "tbMwdl";
            this.tbMwdl.Size = new System.Drawing.Size(200, 43);
            this.tbMwdl.TabIndex = 10;
            // 
            // btGetData
            // 
            this.btGetData.Location = new System.Drawing.Point(145, 400);
            this.btGetData.Name = "btGetData";
            this.btGetData.Size = new System.Drawing.Size(75, 23);
            this.btGetData.TabIndex = 11;
            this.btGetData.Text = "Go";
            this.btGetData.UseVisualStyleBackColor = true;
            this.btGetData.Click += new System.EventHandler(this.btGetData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 446);
            this.Controls.Add(this.btGetData);
            this.Controls.Add(this.tbMwdl);
            this.Controls.Add(this.tbMwd);
            this.Controls.Add(this.tbMal0de);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckMwDomList);
            this.Controls.Add(this.ckMwDomains);
            this.Controls.Add(this.ckMalcode);
            this.Name = "Form1";
            this.Text = "Malware Imports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckMalcode;
        private System.Windows.Forms.CheckBox ckMwDomains;
        private System.Windows.Forms.CheckBox ckMwDomList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox tbMal0de;
        private System.Windows.Forms.TextBox tbMwd;
        private System.Windows.Forms.TextBox tbMwdl;
        private System.Windows.Forms.Button btGetData;
    }
}

