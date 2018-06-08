namespace Keys_Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasCards = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedGames = new System.Windows.Forms.DataGridView();
            this.Game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exportgamesbtn = new System.Windows.Forms.Button();
            this.exportkeysbtn = new System.Windows.Forms.Button();
            this.encryptbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appName,
            this.SubID,
            this.appID,
            this.hasCards,
            this.Qty,
            this.Details});
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(680, 350);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(680, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // appName
            // 
            this.appName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appName.DataPropertyName = "AppName";
            this.appName.HeaderText = "Game";
            this.appName.MinimumWidth = 150;
            this.appName.Name = "appName";
            this.appName.ReadOnly = true;
            this.appName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SubID
            // 
            this.SubID.DataPropertyName = "SubID";
            this.SubID.HeaderText = "SubID";
            this.SubID.Name = "SubID";
            this.SubID.ReadOnly = true;
            // 
            // appID
            // 
            this.appID.DataPropertyName = "AppID";
            this.appID.HeaderText = "AppID";
            this.appID.Name = "appID";
            this.appID.ReadOnly = true;
            this.appID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.appID.Width = 75;
            // 
            // hasCards
            // 
            this.hasCards.DataPropertyName = "HasCards";
            this.hasCards.FalseValue = "";
            this.hasCards.HeaderText = "Cards";
            this.hasCards.IndeterminateValue = "";
            this.hasCards.Name = "hasCards";
            this.hasCards.ReadOnly = true;
            this.hasCards.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hasCards.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hasCards.TrueValue = "";
            this.hasCards.Width = 50;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Quantity";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Details
            // 
            this.Details.DataPropertyName = "Details";
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.AutoSize = true;
            this.copyButton.Location = new System.Drawing.Point(734, 358);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(233, 28);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // selectedGames
            // 
            this.selectedGames.AllowUserToAddRows = false;
            this.selectedGames.AllowUserToDeleteRows = false;
            this.selectedGames.BackgroundColor = System.Drawing.Color.LightGray;
            this.selectedGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Game,
            this.Quantity});
            this.selectedGames.Location = new System.Drawing.Point(734, 36);
            this.selectedGames.Name = "selectedGames";
            this.selectedGames.RowHeadersVisible = false;
            this.selectedGames.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selectedGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectedGames.Size = new System.Drawing.Size(233, 316);
            this.selectedGames.TabIndex = 8;
            // 
            // Game
            // 
            this.Game.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Game.DataPropertyName = "AppName";
            this.Game.HeaderText = "Game";
            this.Game.Name = "Game";
            this.Game.ReadOnly = true;
            this.Game.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.Width = 35;
            // 
            // rightBtn
            // 
            this.rightBtn.Location = new System.Drawing.Point(698, 170);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(30, 30);
            this.rightBtn.TabIndex = 6;
            this.rightBtn.Text = ">>";
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.Location = new System.Drawing.Point(698, 206);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(30, 30);
            this.leftBtn.TabIndex = 7;
            this.leftBtn.Text = "<<";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // hide
            // 
            this.hide.AutoSize = true;
            this.hide.Checked = true;
            this.hide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hide.Location = new System.Drawing.Point(613, 13);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(79, 17);
            this.hide.TabIndex = 9;
            this.hide.Text = "Hide empty";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Find games";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportgamesbtn
            // 
            this.exportgamesbtn.Location = new System.Drawing.Point(297, 7);
            this.exportgamesbtn.Name = "exportgamesbtn";
            this.exportgamesbtn.Size = new System.Drawing.Size(94, 23);
            this.exportgamesbtn.TabIndex = 11;
            this.exportgamesbtn.Text = "Export games list";
            this.exportgamesbtn.UseVisualStyleBackColor = true;
            this.exportgamesbtn.Click += new System.EventHandler(this.exportgamesbtn_Click);
            // 
            // exportkeysbtn
            // 
            this.exportkeysbtn.Location = new System.Drawing.Point(397, 7);
            this.exportkeysbtn.Name = "exportkeysbtn";
            this.exportkeysbtn.Size = new System.Drawing.Size(94, 23);
            this.exportkeysbtn.TabIndex = 12;
            this.exportkeysbtn.Text = "Export keys list";
            this.exportkeysbtn.UseVisualStyleBackColor = true;
            this.exportkeysbtn.Click += new System.EventHandler(this.exportkeysbtn_Click);
            // 
            // encryptbtn
            // 
            this.encryptbtn.Location = new System.Drawing.Point(497, 7);
            this.encryptbtn.Name = "encryptbtn";
            this.encryptbtn.Size = new System.Drawing.Size(94, 23);
            this.encryptbtn.TabIndex = 13;
            this.encryptbtn.Text = "Encryption";
            this.encryptbtn.UseVisualStyleBackColor = true;
            this.encryptbtn.Click += new System.EventHandler(this.encryptbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 399);
            this.Controls.Add(this.encryptbtn);
            this.Controls.Add(this.exportkeysbtn);
            this.Controls.Add(this.exportgamesbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.selectedGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Keys Storage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView selectedGames;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Game;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.CheckBox hide;
        private System.Windows.Forms.DataGridViewTextBoxColumn appName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubID;
        private System.Windows.Forms.DataGridViewTextBoxColumn appID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exportgamesbtn;
        private System.Windows.Forms.Button exportkeysbtn;
        private System.Windows.Forms.Button encryptbtn;
    }
}

