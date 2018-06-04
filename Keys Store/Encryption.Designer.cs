namespace Keys_Store
{
    partial class Encryption
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
            this.statuslbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPasstxt = new System.Windows.Forms.TextBox();
            this.newPasstxt = new System.Windows.Forms.TextBox();
            this.repeatPasstxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statuslbl
            // 
            this.statuslbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.statuslbl.AutoSize = true;
            this.statuslbl.Location = new System.Drawing.Point(12, 10);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(43, 13);
            this.statuslbl.TabIndex = 1;
            this.statuslbl.Text = "Status: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repeat";
            // 
            // oldPasstxt
            // 
            this.oldPasstxt.Location = new System.Drawing.Point(95, 35);
            this.oldPasstxt.Name = "oldPasstxt";
            this.oldPasstxt.PasswordChar = '●';
            this.oldPasstxt.Size = new System.Drawing.Size(120, 20);
            this.oldPasstxt.TabIndex = 5;
            // 
            // newPasstxt
            // 
            this.newPasstxt.Location = new System.Drawing.Point(95, 61);
            this.newPasstxt.Name = "newPasstxt";
            this.newPasstxt.PasswordChar = '●';
            this.newPasstxt.Size = new System.Drawing.Size(120, 20);
            this.newPasstxt.TabIndex = 6;
            // 
            // repeatPasstxt
            // 
            this.repeatPasstxt.Location = new System.Drawing.Point(95, 87);
            this.repeatPasstxt.Name = "repeatPasstxt";
            this.repeatPasstxt.PasswordChar = '●';
            this.repeatPasstxt.Size = new System.Drawing.Size(120, 20);
            this.repeatPasstxt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(8, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Encryption
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(227, 155);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.repeatPasstxt);
            this.Controls.Add(this.newPasstxt);
            this.Controls.Add(this.oldPasstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statuslbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Encryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Encryption";
            this.Load += new System.EventHandler(this.Encryption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldPasstxt;
        private System.Windows.Forms.TextBox newPasstxt;
        private System.Windows.Forms.TextBox repeatPasstxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}