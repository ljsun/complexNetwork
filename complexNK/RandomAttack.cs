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
    public partial class RandomAttack : Form
    {
        public List<List<string>> beforeAttackData;
        public List<List<string>> afterAttackData;
        public List<Point> beforeAttackPoint;
        public List<Point> afterAttackPoint;
        public Bitmap beforeAttackBm;
        public Graphics beforeAttackGra;
        public Bitmap afterAttackBm;
        public Graphics afterAttackGra;
        public Pen circlePen;
        public int attackedNodeIndex;

        public static int DIAMETER = 14;

        public RandomAttack(List<List<string>> beforeAttackData, List<List<string>> afterAttackData, int attackedNodeIndex)
        {
            this.beforeAttackData = beforeAttackData;
            this.afterAttackData = afterAttackData;
            this.attackedNodeIndex = attackedNodeIndex;
            InitializeComponent();
        }

        private void RandomAttack_Load(object sender, EventArgs e)
        {
            // 初始化画板
            this.beforeAttackBm = new Bitmap(this.beforeAttackPic.Width, this.beforeAttackPic.Height);
            this.beforeAttackGra = Graphics.FromImage(beforeAttackBm);
            this.beforeAttackGra.Clear(Color.White);

            this.afterAttackBm = new Bitmap(this.afterAttackPic.Width, this.afterAttackPic.Height);
            this.afterAttackGra = Graphics.FromImage(afterAttackBm);
            this.afterAttackGra.Clear(Color.White);

            // 初始化笔
            this.circlePen = new Pen(Color.Black);

            // 创建节点的随机位置
            this.beforeAttackPoint = CommonUtils.createRandomLocations(this.beforeAttackPic.Width, this.beforeAttackPic.Height, RandomAttack.DIAMETER);
            this.afterAttackPoint = CommonUtils.createRandomLocations(this.afterAttackPic.Width, this.afterAttackPic.Height, RandomAttack.DIAMETER);

            // 开始画图
            // beforeAttackBm
            paintNode(this.beforeAttackPoint, this.beforeAttackGra, this.attackedNodeIndex, true);
            paintEdge(this.beforeAttackData, this.beforeAttackPoint, this.beforeAttackGra);
            paintNodesName(this.beforeAttackPoint, this.beforeAttackGra, this.attackedNodeIndex, true);
            this.beforeAttackPic.Image = this.beforeAttackBm;
            // afterAttackBm
            paintNode(this.afterAttackPoint, this.afterAttackGra, this.attackedNodeIndex, false);
            paintEdge(this.afterAttackData, this.afterAttackPoint, this.afterAttackGra);
            paintNodesName(this.afterAttackPoint, this.afterAttackGra, this.attackedNodeIndex, false);
            this.afterAttackPic.Image = this.afterAttackBm;

            // 计算攻击前后各个指标
            // 计算攻击前
            List<double> shorestPath;
            string pathStr;
            this.beforeCoefficient.Text = GraphUtils.getAverageClusterCoefficient(this.beforeAttackData).ToString();
            this.beforeAverageDegree.Text = GraphUtils.getAverageDegree(this.beforeAttackData).ToString();
            this.beforeCoreness.Text = GraphUtils.getGraphCoreness(this.beforeAttackData).ToString();
            shorestPath = GraphUtils.getGraphShorestPath(this.beforeAttackData);
            pathStr = "";
            foreach (double path in shorestPath)
            {
                pathStr += path.ToString() + "  ";
            }
            this.beforeShorestPath.Text = pathStr;
            // 计算攻击后
            this.afterCoefficient.Text = GraphUtils.getAverageClusterCoefficient(this.afterAttackData).ToString();
            this.afterAverageDegree.Text = GraphUtils.getAverageDegree(this.afterAttackData).ToString();
            this.afterCoreness.Text = GraphUtils.getGraphCoreness(this.afterAttackData).ToString();
            shorestPath = GraphUtils.getGraphShorestPath(this.afterAttackData);
            pathStr = "";
            foreach (double path in shorestPath)
            {
                pathStr += path.ToString() + "  ";
            }
            this.afterShorestPath.Text = pathStr;
        }

        // 画圈
        private void paintNode(List<Point> points, Graphics gra, int index, Boolean isDraw)
        {
            // i代表依次访问的point的索引
            int i = 0;
            foreach (Point point in points)
            {
                if (index - 1 != i)
                {
                    gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    gra.DrawEllipse(this.circlePen, point.X, point.Y, DIAMETER, DIAMETER);//画椭圆的方法，x坐标、y坐标、宽、高
                }
                else
                {
                    if (isDraw)
                    {
                        Pen attackedPen = new Pen(Color.Green);
                        gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        gra.DrawEllipse(attackedPen, point.X, point.Y, DIAMETER, DIAMETER);//画椭圆的方法，x坐标、y坐标、宽、高
                    }
                }
                i++;
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
        private void paintNodesName(List<Point> points, Graphics gra, int index, Boolean isDraw)
        {
            int i = 1;
            string num;
            Font myFont;
            Brush brush;
            foreach (Point point in points)
            {
                if (index != i)
                {
                    num = "" + (i);
                    myFont = new Font("宋体", 8, FontStyle.Bold);
                    brush = new SolidBrush(Color.Red);//填充的颜色
                    gra.DrawString(num, myFont, brush, point.X + Network.DIAMETER / 8, point.Y + Network.DIAMETER / 4);
                }
                else
                {
                    if (isDraw)
                    {
                        num = "" + (i);
                        myFont = new Font("宋体", 8, FontStyle.Bold);
                        brush = new SolidBrush(Color.Green);//填充的颜色
                        gra.DrawString(num, myFont, brush, point.X + Network.DIAMETER / 8, point.Y + Network.DIAMETER / 4);
                    }
                }
                i++;
            }
        }
    }
}
