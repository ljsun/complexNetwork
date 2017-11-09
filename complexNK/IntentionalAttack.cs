using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using complexNK.units;

namespace complexNK
{
    public partial class IntentionalAttack : Form
    {
        public List<List<string>> currentData;
        public Bitmap currentBm;
        public List<Point> currentPoint;
        public Graphics currentGra;
        public Pen circlePen;
        public Pen attackPen;
        public Font attackedFont;
        public Brush attackedBrush;
        public Brush unAttackedbrush;

        public List<int> attackedIndex;


        public static int DIAMETER = 14;

        public IntentionalAttack(List<List<string>> initialData)
        {
            this.currentData = CommonUtils.getDuplicateData(initialData);
            InitializeComponent();
        }

        private void IntentionalAttack_Load(object sender, EventArgs e)
        {
            // 创建节点的随机位置
            this.currentPoint = CommonUtils.createRandomLocations(this.currentPic.Width, this.currentPic.Height, IntentionalAttack.DIAMETER);
            // 初始化attackedIndex
            this.attackedIndex = new List<int>();
            // 初始化attackedFont和attackedBrush
            this.attackedFont = new Font("宋体", 8, FontStyle.Bold);
            this.attackedBrush = new SolidBrush(Color.Green);
            this.unAttackedbrush = new SolidBrush(Color.Red);

            // 初始化画板
            this.currentBm = new Bitmap(this.currentPic.Width, this.currentPic.Height);
            this.currentGra = Graphics.FromImage(this.currentBm);
            this.currentGra.Clear(Color.White);
            // 初始化笔
            this.circlePen = new Pen(Color.Black);
            this.attackPen = new Pen(Color.Green);
            // 开始初始化图
            // 画圈
            paintNode(this.currentPoint, this.currentGra, this.attackedIndex);
            // 画线
            paintEdge(this.currentData, this.currentPoint, this.currentGra);
            // 写字
            paintNodesName(this.currentPoint, this.currentGra, this.attackedIndex);
            this.currentPic.Image = this.currentBm;
        }

        private void attack_Click(object sender, EventArgs e)
        {
            // 先判断这个图是否已经完全不连通
            if (!(GraphUtils.getMaxDegree(this.currentData) == 0))
            {
                // 先获取当前图的度最大的节点
                int indexOfMaxDegree = GraphUtils.getIndexOfMaxDegree(this.currentData);
                // 然后把这个点删除
                GraphUtils.removeNode(this.currentData, indexOfMaxDegree);
                this.attackedIndex.Add(indexOfMaxDegree);
                this.currentBm = new Bitmap(this.currentPic.Width, this.currentPic.Height);
                this.currentGra = Graphics.FromImage(this.currentBm);
                this.currentGra.Clear(Color.White);
                // 画圈
                paintNode(this.currentPoint, this.currentGra, this.attackedIndex);
                // 画线
                paintEdge(this.currentData, this.currentPoint, this.currentGra);
                // 写字
                paintNodesName(this.currentPoint, this.currentGra, this.attackedIndex);
                this.currentPic.Image = this.currentBm;

                //将被攻击点写在被攻击序列
                this.currentBm = new Bitmap(this.attackedIndexPic.Width, this.attackedIndexPic.Height);
                this.currentGra = Graphics.FromImage(this.currentBm);
                this.currentGra.Clear(Color.White);
                float x = 282;
                float y = 49;
                for (int i = 0; i < this.attackedIndex.Count; i++)
                {
                    this.currentGra.DrawString((attackedIndex[i]).ToString(), this.attackedFont, this.attackedBrush, 2+i*18, 10);
                }
                this.attackedIndexPic.Image = this.currentBm;
            }
        }

        // 画圈
        private void paintNode(List<Point> points, Graphics gra, List<int> attackedIndex)
        {
            for (int i = 0; i < points.Count; i++)
            {
                if (attackedIndex.Contains(i + 1))
                {
                    // 画绿圈
                    gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    gra.DrawEllipse(this.attackPen, points[i].X, points[i].Y, DIAMETER, DIAMETER);//画椭圆的方法，x坐标、y坐标、宽、高
                }
                else
                {
                    // 画黑圈
                    gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    gra.DrawEllipse(this.circlePen, points[i].X, points[i].Y, DIAMETER, DIAMETER);//画椭圆的方法，x坐标、y坐标、宽、高
                }
            }
        }

        // 连线
        private void paintEdge(List<List<string>> data, List<Point> points, Graphics gra)
        {
            int self_DIAMETER = Network.DIAMETER / 2;
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = i + 1; j < data[i].Count; j++)
                {
                    // 被攻击点不被别人连
                    if (data[i][j].Equals("y"))
                    {
                        Point point1 = new Point(points[i].X + self_DIAMETER, points[i].Y + self_DIAMETER);
                        Point point2 = new Point(points[j].X + self_DIAMETER, points[j].Y + self_DIAMETER);
                        gra.DrawLine(this.circlePen, point1, point2);
                    }
                }
            }
        }

        // 写数字
        private void paintNodesName(List<Point> points, Graphics gra, List<int> attackedIndex)
        {
            string num;
            for (int i = 0; i < points.Count; i++)
            {
                num = "" + (i+1);
                if (attackedIndex.Contains(i + 1))
                    gra.DrawString(num, this.attackedFont, this.attackedBrush, points[i].X + Network.DIAMETER / 8, points[i].Y + Network.DIAMETER / 4);
                else
                    gra.DrawString(num, this.attackedFont, this.unAttackedbrush, points[i].X + Network.DIAMETER / 8, points[i].Y + Network.DIAMETER / 4);
            }
        }
    }
}
