namespace Remember_Objects
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.switchPlayerButton = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // switchPlayerButton
            // 
            this.switchPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.switchPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.switchPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.switchPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchPlayerButton.Image = ((System.Drawing.Image)(resources.GetObject("switchPlayerButton.Image")));
            this.switchPlayerButton.Location = new System.Drawing.Point(1064, 1200);
            this.switchPlayerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.switchPlayerButton.Name = "switchPlayerButton";
            this.switchPlayerButton.Size = new System.Drawing.Size(666, 273);
            this.switchPlayerButton.TabIndex = 0;
            this.switchPlayerButton.UseVisualStyleBackColor = true;
            this.switchPlayerButton.Click += new System.EventHandler(this.switchPlayerButton_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.playerLabel.Location = new System.Drawing.Point(1180, 98);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(47, 75);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = ".";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1008, 308);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(790, 837);
            this.checkedListBox1.TabIndex = 3;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2750, 1494);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.switchPlayerButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameScreen";
            this.Text = "Select Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button switchPlayerButton;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}