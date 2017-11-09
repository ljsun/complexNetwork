namespace complexNK
{
    partial class DegreeDistribution
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
            this.picDegreeDistribution = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreeDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // picDegreeDistribution
            // 
            this.picDegreeDistribution.Location = new System.Drawing.Point(27, 12);
            this.picDegreeDistribution.Name = "picDegreeDistribution";
            this.picDegreeDistribution.Size = new System.Drawing.Size(1039, 543);
            this.picDegreeDistribution.TabIndex = 0;
            this.picDegreeDistribution.TabStop = false;
            // 
            // DegreeDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 582);
            this.Controls.Add(this.picDegreeDistribution);
            this.Name = "DegreeDistribution";
            this.Text = "度分布";
            this.Load += new System.EventHandler(this.DegreeDistribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDegreeDistribution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDegreeDistribution;
    }
}