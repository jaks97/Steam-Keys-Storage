using System.Collections.Generic;

namespace Keys_Store
{
    partial class RemoveKeys
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
            this.label1 = new System.Windows.Forms.Label();
            this.keysPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.copyButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keys copied to clipboard";
            // 
            // keysPanel
            // 
            this.keysPanel.AutoScroll = true;
            this.keysPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keysPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keysPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.keysPanel.Location = new System.Drawing.Point(15, 33);
            this.keysPanel.Name = "keysPanel";
            this.keysPanel.Size = new System.Drawing.Size(529, 249);
            this.keysPanel.TabIndex = 2;
            this.keysPanel.WrapContents = false;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(469, 4);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Copy Again";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(15, 288);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(529, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Mark Used";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // RemoveKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 321);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.keysPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RemoveKeys";
            this.Text = "Keys";
            this.Load += new System.EventHandler(this.RemoveKeys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel keysPanel;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button removeButton;
    }
}