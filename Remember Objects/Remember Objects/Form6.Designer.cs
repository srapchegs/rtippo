namespace Remember_Objects
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
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
            this.switchPlayerButton.Location = new System.Drawing.Point(532, 624);
            this.switchPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.switchPlayerButton.Name = "switchPlayerButton";
            this.switchPlayerButton.Size = new System.Drawing.Size(333, 142);
            this.switchPlayerButton.TabIndex = 0;
            this.switchPlayerButton.UseVisualStyleBackColor = true;
            this.switchPlayerButton.Click += new System.EventHandler(this.switchPlayerButton_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.playerLabel.Location = new System.Drawing.Point(590, 51);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(24, 37);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = ".";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(504, 160);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(397, 454);
            this.checkedListBox1.TabIndex = 3;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1375, 777);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.switchPlayerButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form6";
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