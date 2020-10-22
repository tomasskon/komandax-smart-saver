namespace SmartSaver.Forms.Savings
{
    partial class DesignatedFinancialPlanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignatedFinancialPlanForm));
            this.designatedPlanLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // designatedPlanLabel
            // 
            this.designatedPlanLabel.AutoSize = true;
            this.designatedPlanLabel.BackColor = System.Drawing.Color.Transparent;
            this.designatedPlanLabel.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.designatedPlanLabel.Location = new System.Drawing.Point(12, 99);
            this.designatedPlanLabel.Name = "designatedPlanLabel";
            this.designatedPlanLabel.Size = new System.Drawing.Size(387, 35);
            this.designatedPlanLabel.TabIndex = 3;
            this.designatedPlanLabel.Text = "Your designated financial plan:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Location = new System.Drawing.Point(160, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 181);
            this.panel1.TabIndex = 4;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(21, 55);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(448, 73);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "*colored result*";
            this.resultLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(336, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DesignatedFinancialPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.designatedPlanLabel);
            this.DoubleBuffered = true;
            this.Name = "DesignatedFinancialPlanForm";
            this.Text = "DesignatedFinancialPlanForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label designatedPlanLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button button1;
    }
}