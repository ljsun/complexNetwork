namespace complexNK
{
    partial class Network
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.loadData = new System.Windows.Forms.Button();
            this.dataSet_text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CalAverageClusterCoefficient_btn = new System.Windows.Forms.Button();
            this.averageClusterCoefficient_text = new System.Windows.Forms.TextBox();
            this.selectCoefficientNode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clusterCoefficient = new System.Windows.Forms.TextBox();
            this.calNodeCoefficient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.calAverageDegree = new System.Windows.Forms.Button();
            this.averageDegree = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectDegreeNode = new System.Windows.Forms.ComboBox();
            this.calNodeDegree = new System.Windows.Forms.Button();
            this.nodeDegree = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calGraphCoreness = new System.Windows.Forms.Button();
            this.graphCoreness = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectCorenessNode = new System.Windows.Forms.ComboBox();
            this.calNodeCoreness = new System.Windows.Forms.Button();
            this.nodeCoreness = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.selectPathStart = new System.Windows.Forms.ComboBox();
            this.selectPathEnd = new System.Windows.Forms.ComboBox();
            this.calNodeToNodePath = new System.Windows.Forms.Button();
            this.nodeToNodePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.calAveragePath = new System.Windows.Forms.Button();
            this.averagePath = new System.Windows.Forms.TextBox();
            this.disPlayDegreeDistribution = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.selectRandomAttackNode = new System.Windows.Forms.ComboBox();
            this.randomAttack = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.IntentionalAttack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(826, 12);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(110, 23);
            this.loadData.TabIndex = 0;
            this.loadData.Text = "选择数据集";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // dataSet_text
            // 
            this.dataSet_text.Location = new System.Drawing.Point(962, 14);
            this.dataSet_text.Name = "dataSet_text";
            this.dataSet_text.Size = new System.Drawing.Size(181, 21);
            this.dataSet_text.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 740);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(828, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "计算聚类因子";
            // 
            // CalAverageClusterCoefficient_btn
            // 
            this.CalAverageClusterCoefficient_btn.Location = new System.Drawing.Point(826, 79);
            this.CalAverageClusterCoefficient_btn.Name = "CalAverageClusterCoefficient_btn";
            this.CalAverageClusterCoefficient_btn.Size = new System.Drawing.Size(107, 23);
            this.CalAverageClusterCoefficient_btn.TabIndex = 4;
            this.CalAverageClusterCoefficient_btn.Text = "平均聚类因子";
            this.CalAverageClusterCoefficient_btn.UseVisualStyleBackColor = true;
            this.CalAverageClusterCoefficient_btn.Click += new System.EventHandler(this.CalAverageClusterCoefficient_btn_Click);
            // 
            // averageClusterCoefficient_text
            // 
            this.averageClusterCoefficient_text.Location = new System.Drawing.Point(962, 79);
            this.averageClusterCoefficient_text.Name = "averageClusterCoefficient_text";
            this.averageClusterCoefficient_text.Size = new System.Drawing.Size(181, 21);
            this.averageClusterCoefficient_text.TabIndex = 6;
            this.averageClusterCoefficient_text.TextChanged += new System.EventHandler(this.averageClusterCoefficient_TextChanged);
            // 
            // selectCoefficientNode
            // 
            this.selectCoefficientNode.FormattingEnabled = true;
            this.selectCoefficientNode.Location = new System.Drawing.Point(826, 139);
            this.selectCoefficientNode.Name = "selectCoefficientNode";
            this.selectCoefficientNode.Size = new System.Drawing.Size(121, 20);
            this.selectCoefficientNode.TabIndex = 7;
            this.selectCoefficientNode.SelectedIndexChanged += new System.EventHandler(this.selectCoefficientNode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "选择节点";
            // 
            // clusterCoefficient
            // 
            this.clusterCoefficient.Location = new System.Drawing.Point(1107, 138);
            this.clusterCoefficient.Name = "clusterCoefficient";
            this.clusterCoefficient.Size = new System.Drawing.Size(179, 21);
            this.clusterCoefficient.TabIndex = 10;
            // 
            // calNodeCoefficient
            // 
            this.calNodeCoefficient.Location = new System.Drawing.Point(966, 136);
            this.calNodeCoefficient.Name = "calNodeCoefficient";
            this.calNodeCoefficient.Size = new System.Drawing.Size(117, 23);
            this.calNodeCoefficient.TabIndex = 11;
            this.calNodeCoefficient.Text = "该节点聚类因子";
            this.calNodeCoefficient.UseVisualStyleBackColor = true;
            this.calNodeCoefficient.Click += new System.EventHandler(this.calNodeCoefficient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(823, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "计算度";
            // 
            // calAverageDegree
            // 
            this.calAverageDegree.Location = new System.Drawing.Point(826, 200);
            this.calAverageDegree.Name = "calAverageDegree";
            this.calAverageDegree.Size = new System.Drawing.Size(107, 23);
            this.calAverageDegree.TabIndex = 13;
            this.calAverageDegree.Text = "节点平均度";
            this.calAverageDegree.UseVisualStyleBackColor = true;
            this.calAverageDegree.Click += new System.EventHandler(this.averageDegree_Click);
            // 
            // averageDegree
            // 
            this.averageDegree.Location = new System.Drawing.Point(962, 202);
            this.averageDegree.Name = "averageDegree";
            this.averageDegree.Size = new System.Drawing.Size(179, 21);
            this.averageDegree.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(831, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "选择节点";
            // 
            // selectDegreeNode
            // 
            this.selectDegreeNode.FormattingEnabled = true;
            this.selectDegreeNode.Location = new System.Drawing.Point(826, 252);
            this.selectDegreeNode.Name = "selectDegreeNode";
            this.selectDegreeNode.Size = new System.Drawing.Size(119, 20);
            this.selectDegreeNode.TabIndex = 16;
            // 
            // calNodeDegree
            // 
            this.calNodeDegree.Location = new System.Drawing.Point(966, 252);
            this.calNodeDegree.Name = "calNodeDegree";
            this.calNodeDegree.Size = new System.Drawing.Size(117, 23);
            this.calNodeDegree.TabIndex = 17;
            this.calNodeDegree.Text = "该节点度";
            this.calNodeDegree.UseVisualStyleBackColor = true;
            this.calNodeDegree.Click += new System.EventHandler(this.calNodeDegree_Click);
            // 
            // nodeDegree
            // 
            this.nodeDegree.Location = new System.Drawing.Point(1107, 252);
            this.nodeDegree.Name = "nodeDegree";
            this.nodeDegree.Size = new System.Drawing.Size(179, 21);
            this.nodeDegree.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(828, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "计算coreness";
            // 
            // calGraphCoreness
            // 
            this.calGraphCoreness.Location = new System.Drawing.Point(826, 364);
            this.calGraphCoreness.Name = "calGraphCoreness";
            this.calGraphCoreness.Size = new System.Drawing.Size(105, 23);
            this.calGraphCoreness.TabIndex = 20;
            this.calGraphCoreness.Text = "Graph coreness";
            this.calGraphCoreness.UseVisualStyleBackColor = true;
            this.calGraphCoreness.Click += new System.EventHandler(this.calGraphCoreness_Click);
            // 
            // graphCoreness
            // 
            this.graphCoreness.Location = new System.Drawing.Point(962, 366);
            this.graphCoreness.Name = "graphCoreness";
            this.graphCoreness.Size = new System.Drawing.Size(179, 21);
            this.graphCoreness.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(829, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "选择节点";
            // 
            // selectCorenessNode
            // 
            this.selectCorenessNode.FormattingEnabled = true;
            this.selectCorenessNode.Location = new System.Drawing.Point(826, 427);
            this.selectCorenessNode.Name = "selectCorenessNode";
            this.selectCorenessNode.Size = new System.Drawing.Size(116, 20);
            this.selectCorenessNode.TabIndex = 23;
            // 
            // calNodeCoreness
            // 
            this.calNodeCoreness.Location = new System.Drawing.Point(966, 427);
            this.calNodeCoreness.Name = "calNodeCoreness";
            this.calNodeCoreness.Size = new System.Drawing.Size(117, 23);
            this.calNodeCoreness.TabIndex = 24;
            this.calNodeCoreness.Text = "该节点coreness";
            this.calNodeCoreness.UseVisualStyleBackColor = true;
            this.calNodeCoreness.Click += new System.EventHandler(this.calNodeCoreness_Click);
            // 
            // nodeCoreness
            // 
            this.nodeCoreness.Location = new System.Drawing.Point(1107, 426);
            this.nodeCoreness.Name = "nodeCoreness";
            this.nodeCoreness.Size = new System.Drawing.Size(179, 21);
            this.nodeCoreness.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(830, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "计算最短路径";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(831, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "选择起始节点";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(960, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "选择终止节点";
            // 
            // selectPathStart
            // 
            this.selectPathStart.FormattingEnabled = true;
            this.selectPathStart.Location = new System.Drawing.Point(826, 519);
            this.selectPathStart.Name = "selectPathStart";
            this.selectPathStart.Size = new System.Drawing.Size(116, 20);
            this.selectPathStart.TabIndex = 28;
            // 
            // selectPathEnd
            // 
            this.selectPathEnd.FormattingEnabled = true;
            this.selectPathEnd.Location = new System.Drawing.Point(962, 519);
            this.selectPathEnd.Name = "selectPathEnd";
            this.selectPathEnd.Size = new System.Drawing.Size(117, 20);
            this.selectPathEnd.TabIndex = 29;
            // 
            // calNodeToNodePath
            // 
            this.calNodeToNodePath.Location = new System.Drawing.Point(1107, 488);
            this.calNodeToNodePath.Name = "calNodeToNodePath";
            this.calNodeToNodePath.Size = new System.Drawing.Size(92, 23);
            this.calNodeToNodePath.TabIndex = 30;
            this.calNodeToNodePath.Text = "计算最短路径";
            this.calNodeToNodePath.UseVisualStyleBackColor = true;
            this.calNodeToNodePath.Click += new System.EventHandler(this.calNodeToNodePath_Click);
            // 
            // nodeToNodePath
            // 
            this.nodeToNodePath.Location = new System.Drawing.Point(1107, 517);
            this.nodeToNodePath.Name = "nodeToNodePath";
            this.nodeToNodePath.Size = new System.Drawing.Size(112, 21);
            this.nodeToNodePath.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(829, 557);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "计算平均路径（若图不连通，则计算各个子图的平均路径）";
            // 
            // calAveragePath
            // 
            this.calAveragePath.Location = new System.Drawing.Point(826, 589);
            this.calAveragePath.Name = "calAveragePath";
            this.calAveragePath.Size = new System.Drawing.Size(116, 23);
            this.calAveragePath.TabIndex = 33;
            this.calAveragePath.Text = "计算平均最短路径";
            this.calAveragePath.UseVisualStyleBackColor = true;
            this.calAveragePath.Click += new System.EventHandler(this.calAveragePath_Click);
            // 
            // averagePath
            // 
            this.averagePath.Location = new System.Drawing.Point(962, 591);
            this.averagePath.Name = "averagePath";
            this.averagePath.Size = new System.Drawing.Size(255, 21);
            this.averagePath.TabIndex = 34;
            // 
            // disPlayDegreeDistribution
            // 
            this.disPlayDegreeDistribution.Location = new System.Drawing.Point(826, 293);
            this.disPlayDegreeDistribution.Name = "disPlayDegreeDistribution";
            this.disPlayDegreeDistribution.Size = new System.Drawing.Size(103, 23);
            this.disPlayDegreeDistribution.TabIndex = 35;
            this.disPlayDegreeDistribution.Text = "显示度的分布";
            this.disPlayDegreeDistribution.UseVisualStyleBackColor = true;
            this.disPlayDegreeDistribution.Click += new System.EventHandler(this.disPlayDegreeDistribution_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(830, 630);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "随机攻击";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(829, 659);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 37;
            this.label12.Text = "选择攻击节点";
            // 
            // selectRandomAttackNode
            // 
            this.selectRandomAttackNode.FormattingEnabled = true;
            this.selectRandomAttackNode.Location = new System.Drawing.Point(826, 674);
            this.selectRandomAttackNode.Name = "selectRandomAttackNode";
            this.selectRandomAttackNode.Size = new System.Drawing.Size(116, 20);
            this.selectRandomAttackNode.TabIndex = 38;
            // 
            // randomAttack
            // 
            this.randomAttack.Location = new System.Drawing.Point(962, 674);
            this.randomAttack.Name = "randomAttack";
            this.randomAttack.Size = new System.Drawing.Size(104, 23);
            this.randomAttack.TabIndex = 39;
            this.randomAttack.Text = "开始攻击";
            this.randomAttack.UseVisualStyleBackColor = true;
            this.randomAttack.Click += new System.EventHandler(this.randomAttack_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(828, 707);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "蓄意攻击";
            // 
            // IntentionalAttack
            // 
            this.IntentionalAttack.Location = new System.Drawing.Point(831, 729);
            this.IntentionalAttack.Name = "IntentionalAttack";
            this.IntentionalAttack.Size = new System.Drawing.Size(111, 23);
            this.IntentionalAttack.TabIndex = 41;
            this.IntentionalAttack.Text = "开始攻击";
            this.IntentionalAttack.UseVisualStyleBackColor = true;
            this.IntentionalAttack.Click += new System.EventHandler(this.IntentionalAttack_Click);
            // 
            // Network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 764);
            this.Controls.Add(this.IntentionalAttack);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.randomAttack);
            this.Controls.Add(this.selectRandomAttackNode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.disPlayDegreeDistribution);
            this.Controls.Add(this.averagePath);
            this.Controls.Add(this.calAveragePath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nodeToNodePath);
            this.Controls.Add(this.calNodeToNodePath);
            this.Controls.Add(this.selectPathEnd);
            this.Controls.Add(this.selectPathStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nodeCoreness);
            this.Controls.Add(this.calNodeCoreness);
            this.Controls.Add(this.selectCorenessNode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.graphCoreness);
            this.Controls.Add(this.calGraphCoreness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nodeDegree);
            this.Controls.Add(this.calNodeDegree);
            this.Controls.Add(this.selectDegreeNode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.averageDegree);
            this.Controls.Add(this.calAverageDegree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calNodeCoefficient);
            this.Controls.Add(this.clusterCoefficient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectCoefficientNode);
            this.Controls.Add(this.averageClusterCoefficient_text);
            this.Controls.Add(this.CalAverageClusterCoefficient_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataSet_text);
            this.Controls.Add(this.loadData);
            this.Name = "Network";
            this.Text = "复杂网络";
            this.Load += new System.EventHandler(this.Network_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.TextBox dataSet_text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalAverageClusterCoefficient_btn;
        private System.Windows.Forms.TextBox averageClusterCoefficient_text;
        private System.Windows.Forms.ComboBox selectCoefficientNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clusterCoefficient;
        private System.Windows.Forms.Button calNodeCoefficient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calAverageDegree;
        private System.Windows.Forms.TextBox averageDegree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectDegreeNode;
        private System.Windows.Forms.Button calNodeDegree;
        private System.Windows.Forms.TextBox nodeDegree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calGraphCoreness;
        private System.Windows.Forms.TextBox graphCoreness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectCorenessNode;
        private System.Windows.Forms.Button calNodeCoreness;
        private System.Windows.Forms.TextBox nodeCoreness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectPathStart;
        private System.Windows.Forms.ComboBox selectPathEnd;
        private System.Windows.Forms.Button calNodeToNodePath;
        private System.Windows.Forms.TextBox nodeToNodePath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button calAveragePath;
        private System.Windows.Forms.TextBox averagePath;
        private System.Windows.Forms.Button disPlayDegreeDistribution;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox selectRandomAttackNode;
        private System.Windows.Forms.Button randomAttack;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button IntentionalAttack;

    }
}

