using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using complexNK.units;

namespace complexNK
{
    public partial class Network : Form
    {
        public List<Point> points = new List<Point>();
        public List<List<string>> data;
        public static int DIAMETER = 14;
        public Bitmap bm;
        public Graphics gra;
        public Pen pen;
        public Network()
        {
            InitializeComponent();
        }

        public void createSelectDataSource()
        {
            for (int i = 0; i < 63; i++)
            {
                this.selectCoefficientNode.Items.Add(i + 1);
                this.selectDegreeNode.Items.Add(i + 1);
                this.selectCorenessNode.Items.Add(i + 1);
                this.selectPathStart.Items.Add(i + 1);
                this.selectPathEnd.Items.Add(i + 1);
                this.selectRandomAttackNode.Items.Add(i + 1);
            }
        }

        private void Network_Load(object sender, EventArgs e)
        {
            // 创建画笔
            pen = new Pen(Color.Black);
            // 创建画板
            this.bm = new Bitmap(this.panel1.Width, this.panel1.Height);
            this.gra = Graphics.FromImage(this.bm);
            this.gra.Clear(Color.White);
            this.panel1.BackgroundImage = bm;
            // 创建节点的随机位置
            points = CommonUtils.createRandomLocations(this.panel1.Width, this.panel1.Height, Network.DIAMETER);
            // 在下拉列表里面添加值
            createSelectDataSource();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();   //显示选择文件对话框 
            openFileDialog1.InitialDirectory = "C:";
            // 打开文件类型
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;

            //如果点击确定
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 释放之前bitmap的资源
                this.bm.Dispose();
                
                this.bm = new Bitmap(this.panel1.Width, this.panel1.Height);
                this.gra = Graphics.FromImage(this.bm);
                this.gra.Clear(Color.White);
                this.data = readFile(openFileDialog1.FileName);
                //画点
                paintNode();
                //画线
                paintEdge(this.data);
                //画数字
                paintNodesName();
                this.panel1.BackgroundImage = this.bm;

                this.dataSet_text.Text = openFileDialog1.FileName;
            } 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void paintNode()
        {
            foreach(Point point in this.points)
            {
                this.gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;                              
                this.gra.DrawEllipse(pen, point.X, point.Y, DIAMETER, DIAMETER);//画椭圆的方法，x坐标、y坐标、宽、高
            }
        }

        private void paintEdge(List<List<string>> data)
        {
            int self_DIAMETER = Network.DIAMETER / 2;
            for (int i=0; i < data.Count; i++)
            {
                for (int j = i + 1; j < data[i].Count; j++)
                {
                    if (data[i][j].Equals("y"))
                    {
                        Point point1 = new Point(this.points[i].X + self_DIAMETER, this.points[i].Y + self_DIAMETER);
                        Point point2 = new Point(this.points[j].X + self_DIAMETER, this.points[j].Y + self_DIAMETER);
                        this.gra.DrawLine(this.pen, point1, point2);
                    }
                }
            }
        }

        private void paintNodesName()
        {
            int i = 1;
            foreach (Point point in this.points)
            {
                string num = "" + (i);
                Font myFont = new Font("宋体", 8, FontStyle.Bold);
                Brush bush = new SolidBrush(Color.Red);//填充的颜色
                this.gra.DrawString(num, myFont, bush, point.X + Network.DIAMETER / 8, point.Y + Network.DIAMETER / 4);
                i++;
            }
        }

        private List<List<string>> readFile(string filename)
        {
            //读取csv文件
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8);
            string nextLine = "";
            //将数据存储在list 中
            List<List<string>> alldata = new List<List<string>>();
            while ((nextLine = sr.ReadLine()) != null)
            {
                string[] data = nextLine.Split(',');
                // 将data转化为list
                List<string> listData = new List<string>(data);
                listData.RemoveAt(0);
                alldata.Add(listData);
            }
            sr.Close();
            return alldata;
        }

        private void averageClusterCoefficient_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalAverageClusterCoefficient_btn_Click(object sender, EventArgs e)
        {
            string AverageClusterCoefficient = ((decimal)GraphUtils.getAverageClusterCoefficient(this.data)).ToString();
            averageClusterCoefficient_text.Text = AverageClusterCoefficient;
        }

        private void calNodeCoefficient_Click(object sender, EventArgs e)
        {
            int index = (int)this.selectCoefficientNode.SelectedItem;
            double clusterCoefficient = GraphUtils.getClusterCoefficient(this.data, index);
            this.clusterCoefficient.Text = clusterCoefficient.ToString(); 
        }

        private void selectCoefficientNode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void averageDegree_Click(object sender, EventArgs e)
        {
            double averageDegree = GraphUtils.getAverageDegree(this.data);
            this.averageDegree.Text = ((decimal)averageDegree).ToString();
        }

        private void calNodeDegree_Click(object sender, EventArgs e)
        {
            int index = (int)this.selectDegreeNode.SelectedItem;
            int degree = GraphUtils.getDegreeeOfNode(this.data, index);
            this.nodeDegree.Text = degree.ToString();
        }

        private void calGraphCoreness_Click(object sender, EventArgs e)
        {
            int graphCoreness = GraphUtils.getGraphCoreness(this.data);
            this.graphCoreness.Text = graphCoreness.ToString();
        }

        private void calNodeCoreness_Click(object sender, EventArgs e)
        {
            // 这里的index仍然是标号，并非list中的index
            int index = (int)this.selectCorenessNode.SelectedItem;
            List<int> allCoreness = GraphUtils.getNodeCoreness(this.data);
            this.nodeCoreness.Text = allCoreness[index - 1].ToString();
        }

        private void calNodeToNodePath_Click(object sender, EventArgs e)
        {
            // 所有关于index的都是节点在图中的标号
            int startIndex = (int) this.selectPathStart.SelectedItem;
            int endIndex = (int) this.selectPathEnd.SelectedItem;
            int pathLength = GraphUtils.getNodeToNodeShortestPath(this.data, startIndex, endIndex);
            if (pathLength == -1)
                this.nodeToNodePath.Text = "这两个节点不连通";
            else
                this.nodeToNodePath.Text = pathLength.ToString();
        }

        private void calAveragePath_Click(object sender, EventArgs e)
        {
            List<double> shorestPath = GraphUtils.getGraphShorestPath(data);
            string pathStr = "";
            foreach (double path in shorestPath)
            {
                pathStr += path.ToString() + "  ";
            }
            this.averagePath.Text = pathStr;
        }

        private void disPlayDegreeDistribution_Click(object sender, EventArgs e)
        {
            List<int> allDegree = GraphUtils.getAllDegree(this.data);
            complexNK.DegreeDistribution degreeDistributionForm = new complexNK.DegreeDistribution(CalDegreeNum(allDegree));
            degreeDistributionForm.ShowDialog();
        }

        public Dictionary<int, int> CalDegreeNum(List<int> allDegree)
        {
            Dictionary<int, int> allDegreeNum = new Dictionary<int,int>();
            foreach (int degree in allDegree)
            {
                if (allDegreeNum.ContainsKey(degree))
                    allDegreeNum[degree] += 1;
                else
                    allDegreeNum[degree] = 1;
            }
            return allDegreeNum;
        }

        private void randomAttack_Click(object sender, EventArgs e)
        {
            int index = (int) this.selectRandomAttackNode.SelectedItem;
            // 这里返回的是this.data的副本
            List<List<string>> afterAttackData = GraphUtils.RandomAttack(this.data, index);
            complexNK.RandomAttack randomAttackForm = new complexNK.RandomAttack(this.data, afterAttackData, index);
            randomAttackForm.ShowDialog();
        }

        private void IntentionalAttack_Click(object sender, EventArgs e)
        {
            complexNK.IntentionalAttack intentionalAttackForm = new complexNK.IntentionalAttack(this.data);
            intentionalAttackForm.ShowDialog();
        }
    }
}
