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
            this.panel1.Location = new System.Drawing.Point(118, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 154);
            this.panel1.TabIndex = 4;
            // 
            // DesignatedFinancialPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.designatedPlanLabel);
            this.DoubleBuffered = true;
            this.Name = "DesignatedFinancialPlanForm";
            this.Text = "DesignatedFinancialPlanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label designatedPlanLabel;
        private System.Windows.Forms.Panel panel1;
    }
}