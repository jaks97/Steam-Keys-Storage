namespace Keys_Store
{
    partial class AddKey
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
            this.keys = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.hasCards = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appID = new System.Windows.Forms.TextBox();
            this.subID = new System.Windows.Forms.TextBox();
            this.detailsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.removed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // keys
            // 
            this.keys.Location = new System.Drawing.Point(15, 109);
            this.keys.Multiline = true;
            this.keys.Name = "keys";
            this.keys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keys.Size = new System.Drawing.Size(252, 140);
            this.keys.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(53, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(214, 20);
            this.name.TabIndex = 1;
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(104, 281);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 22);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // hasCards
            // 
            this.hasCards.AutoSize = true;
            this.hasCards.Location = new System.Drawing.Point(214, 258);
            this.hasCards.Name = "hasCards";
            this.hasCards.Size = new System.Drawing.Size(53, 17);
            this.hasCards.TabIndex = 4;
            this.hasCards.Text = "Cards";
            this.hasCards.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Keys (one per line)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AppID";
            // 
            // appID
            // 
            this.appID.Location = new System.Drawing.Point(53, 38);
            this.appID.Name = "appID";
            this.appID.Size = new System.Drawing.Size(214, 20);
            this.appID.TabIndex = 2;
            this.appID.Leave += new System.EventHandler(this.appID_Leave);
            // 
            // subID
            // 
            this.subID.Location = new System.Drawing.Point(53, 64);
            this.subID.Name = "subID";
            this.subID.Size = new System.Drawing.Size(214, 20);
            this.subID.TabIndex = 8;
            this.subID.Leave += new System.EventHandler(this.subID_Leave);
            // 
            // detailsBox
            // 
            this.detailsBox.Location = new System.Drawing.Point(53, 255);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(142, 20);
            this.detailsBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SubID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Details";
            // 
            // removed
            // 
            this.removed.AutoSize = true;
            this.removed.Location = new System.Drawing.Point(195, 89);
            this.removed.Name = "removed";
            this.removed.Size = new System.Drawing.Size(72, 17);
            this.removed.TabIndex = 12;
            this.removed.Text = "Removed";
            this.removed.UseVisualStyleBackColor = true;
            // 
            // AddKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 309);
            this.Controls.Add(this.removed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.subID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.appID);
            this.Controls.Add(this.keys);
            this.Controls.Add(this.hasCards);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keys;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.CheckBox hasCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox appID;
        private System.Windows.Forms.TextBox subID;
        private System.Windows.Forms.TextBox detailsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox removed;
    }
}