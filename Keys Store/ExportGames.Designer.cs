namespace Keys_Store
{
    partial class ExportGames
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
            this.format = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineJump = new System.Windows.Forms.CheckBox();
            this.results = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // format
            // 
            this.format.Location = new System.Drawing.Point(12, 29);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(425, 20);
            this.format.TabIndex = 0;
            this.format.Text = "{NAME}";
            this.format.TextChanged += new System.EventHandler(this.ExportGames_Load);
            this.format.Leave += new System.EventHandler(this.ExportGames_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format:";
            // 
            // lineJump
            // 
            this.lineJump.AutoSize = true;
            this.lineJump.Checked = true;
            this.lineJump.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineJump.Location = new System.Drawing.Point(354, 9);
            this.lineJump.Name = "lineJump";
            this.lineJump.Size = new System.Drawing.Size(83, 17);
            this.lineJump.TabIndex = 2;
            this.lineJump.Text = "One per line";
            this.lineJump.UseVisualStyleBackColor = true;
            this.lineJump.CheckedChanged += new System.EventHandler(this.ExportGames_Load);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(12, 73);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.results.Size = new System.Drawing.Size(425, 264);
            this.results.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output:";
            // 
            // copybtn
            // 
            this.copybtn.Location = new System.Drawing.Point(12, 343);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(425, 34);
            this.copybtn.TabIndex = 5;
            this.copybtn.Text = "Copy to clipboard";
            this.copybtn.UseVisualStyleBackColor = true;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // ExportGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 389);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.results);
            this.Controls.Add(this.lineJump);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.format);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ExportGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Games";
            this.Load += new System.EventHandler(this.ExportGames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox format;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox lineJump;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copybtn;
    }
}