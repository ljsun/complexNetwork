namespace complexNK
{
    partial class IntentionalAttack
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
            this.currentPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attack = new System.Windows.Forms.Button();
            this.attackedIndexPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.currentPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackedIndexPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "攻击序列";
            // 
            // currentPic
            // 
            this.currentPic.Location = new System.Drawing.Point(12, 112);
            this.currentPic.Name = "currentPic";
            this.currentPic.Size = new System.Drawing.Size(909, 469);
            this.currentPic.TabIndex = 1;
            this.currentPic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(425, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "当前状态";
            // 
            // attack
            // 
            this.attack.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.attack.Location = new System.Drawing.Point(15, 12);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(135, 23);
            this.attack.TabIndex = 5;
            this.attack.Text = "攻击";
            this.attack.UseVisualStyleBackColor = true;
            this.attack.Click += new System.EventHandler(this.attack_Click);
            // 
            // attackedIndexPic
            // 
            this.attackedIndexPic.Location = new System.Drawing.Point(72, 49);
            this.attackedIndexPic.Name = "attackedIndexPic";
            this.attackedIndexPic.Size = new System.Drawing.Size(849, 33);
            this.attackedIndexPic.TabIndex = 6;
            this.attackedIndexPic.TabStop = false;
            // 
            // IntentionalAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 601);
            this.Controls.Add(this.attackedIndexPic);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPic);
            this.Controls.Add(this.label1);
            this.Name = "IntentionalAttack";
            this.Text = "IntentionalAttack";
            this.Load += new System.EventHandler(this.IntentionalAttack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackedIndexPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox currentPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.PictureBox attackedIndexPic;
    }
}