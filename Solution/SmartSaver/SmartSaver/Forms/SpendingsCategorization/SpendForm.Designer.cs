namespace SmartSaver.Forms.SpendingsCategorization
{
    partial class SpendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpendForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.save_Button = new System.Windows.Forms.Button();
            this.transaction_story_textInput = new System.Windows.Forms.TextBox();
            this.creditCardButton = new System.Windows.Forms.Button();
            this.cashButton = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(752, 75);
            this.panelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Complete transaction";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panelBottom.Controls.Add(this.save_Button);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 413);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(752, 75);
            this.panelBottom.TabIndex = 0;
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.Color.White;
            this.save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_Button.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_Button.Location = new System.Drawing.Point(595, 8);
            this.save_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(145, 54);
            this.save_Button.TabIndex = 1;
            this.save_Button.Text = "Save";
            this.save_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_Button.UseVisualStyleBackColor = false;
            // 
            // transaction_story_textInput
            // 
            this.transaction_story_textInput.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transaction_story_textInput.Location = new System.Drawing.Point(52, 189);
            this.transaction_story_textInput.Multiline = true;
            this.transaction_story_textInput.Name = "transaction_story_textInput";
            this.transaction_story_textInput.PlaceholderText = "Add notes...";
            this.transaction_story_textInput.Size = new System.Drawing.Size(650, 155);
            this.transaction_story_textInput.TabIndex = 5;
            // 
            // creditCardButton
            // 
            this.creditCardButton.BackColor = System.Drawing.Color.Transparent;
            this.creditCardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("creditCardButton.BackgroundImage")));
            this.creditCardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.creditCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditCardButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.creditCardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creditCardButton.Location = new System.Drawing.Point(52, 97);
            this.creditCardButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creditCardButton.Name = "creditCardButton";
            this.creditCardButton.Size = new System.Drawing.Size(64, 64);
            this.creditCardButton.TabIndex = 1;
            this.creditCardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.creditCardButton.UseVisualStyleBackColor = false;
            // 
            // cashButton
            // 
            this.cashButton.BackColor = System.Drawing.Color.Transparent;
            this.cashButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cashButton.BackgroundImage")));
            this.cashButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cashButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashButton.Location = new System.Drawing.Point(138, 97);
            this.cashButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(64, 64);
            this.cashButton.TabIndex = 1;
            this.cashButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cashButton.UseVisualStyleBackColor = false;
            // 
            // SpendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(752, 488);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.creditCardButton);
            this.Controls.Add(this.transaction_story_textInput);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "SpendForm";
            this.Text = "Complete transaction...";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox transaction_story_textInput;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button creditCardButton;
        private System.Windows.Forms.Button cashButton;
    }
}