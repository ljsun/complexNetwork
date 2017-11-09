using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace complexNK
{
    public partial class DegreeDistribution : Form
    {
        public Bitmap bm;
        public Graphics gra;
        public Dictionary<int, int> allDegreeNum;
        public int degreeMax = 0;
        public int degreeNumMax = 0;
        public DegreeDistribution(Dictionary<int, int> allDegreeNum)
        {
            this.allDegreeNum = allDegreeNum;
            InitializeComponent();
            // 获取度的最大值，与度个数的最大值
            foreach (var dic in this.allDegreeNum)
            {
                if (dic.Key > this.degreeMax)
                    this.degreeMax = dic.Key;
                if (dic.Value > this.degreeNumMax)
                    this.degreeNumMax = dic.Value;
            }
            Console.WriteLine(this.degreeMax + "   " + this.degreeNumMax);
        }

        private void DegreeDistribution_Load(object sender, EventArgs e)
        {
            this.bm = new Bitmap(this.picDegreeDistribution.Width, this.picDegreeDistribution.Height);
            this.gra = Graphics.FromImage(bm);
            // 总体限制 ，图表距离左右边界各100 ， 距离上下边界各80
            CreateHistogram();
            this.picDegreeDistribution.Image = this.bm;
        }

        // 绘制柱状图
        public void CreateHistogram()
        {
            // 清空图片背景颜色
            this.gra.Clear(Color.White);
            Font fontRegular = new Font("Arial", 10, FontStyle.Regular);
            Font fontBold = new Font("宋体", 20, FontStyle.Bold);
            // 颜色渐变画刷
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, this.picDegreeDistribution.Width,
                                                                 this.picDegreeDistribution.Height),
                                                                 Color.Blue, Color.Yellow, 45.0f, true);
            this.gra.FillRectangle(Brushes.WhiteSmoke, 0, 0, this.picDegreeDistribution.Width, this.picDegreeDistribution.Height);
            // 标题
            this.gra.DrawString("节点度分布图", fontBold, brush, new PointF(this.picDegreeDistribution.Width/2 - 60, 30));
            // 图标的边框线
            this.gra.DrawRectangle(new Pen(Color.Blue), 0, 0, this.picDegreeDistribution.Width - 1, this.picDegreeDistribution.Height - 1);
            Pen myPen = new Pen(brush, 1);
            // 绘制线条
            // 绘制纵向线条
            // x 为第二条纵线的起始位置
            int xInternal = (this.picDegreeDistribution.Width - 200) / (this.degreeMax + 1);
            int x = 100 + xInternal;
            for (int i = 0; i <= this.degreeMax; i++)
            {
                // 
                this.gra.DrawLine(myPen, x, 80, x, this.picDegreeDistribution.Height-80);
                x += xInternal;
            }
            // 画第一条纵线
            Pen myPenBold = new Pen(brush, 2);
            // x 为第一条纵粗线的起始位置
            x = 100;
            this.gra.DrawLine(myPenBold, x, 80, x, this.picDegreeDistribution.Height - 80);
            // 绘制横向线条
            int yInternal = (this.picDegreeDistribution.Height - 160) / (this.degreeNumMax + 1);
            int y = 80 + yInternal;
            for (int i = 0; i < this.degreeNumMax; i++)
            {
                this.gra.DrawLine(myPen, 100, y, this.picDegreeDistribution.Width-100, y);
                y += yInternal ;
            }
            //画第一条横线, 这里+6是为了保证下方线对齐
            this.gra.DrawLine(myPenBold, 100 , y+6, this.picDegreeDistribution.Width - 100, y+6);
            // 保存horizontal 下面有用
            int horizontal = y + 6;
            // x轴, x为横轴第一个数字的起始位置
            x = 100 + xInternal - 7;
            for (int i = 0; i < this.degreeMax + 1; i++)
            {
                this.gra.DrawString(i.ToString(), fontRegular, Brushes.Blue, x, this.picDegreeDistribution.Height-80+8);
                x += xInternal;
            }
            // y轴, y为纵轴第一个数字的起始位置
            y = this.picDegreeDistribution.Height-80;
            for (int i = 0; i < this.degreeNumMax+1; i++)
            {
                this.gra.DrawString(i.ToString(), fontRegular, Brushes.Blue, 75, y-7);
                y -= yInternal;
            }
            // 绘制柱状图
            Font histogramFont = new Font("Arial", 10, FontStyle.Bold);
            SolidBrush histogramBrush = new SolidBrush(Color.Green);
            // 循环画柱
            foreach (var dic in this.allDegreeNum)
            {
                int degree = dic.Key;
                int degreeNum = dic.Value;
                this.gra.FillRectangle(histogramBrush, 100+3*xInternal/4 + degree*xInternal, 80 + yInternal*(this.degreeNumMax-degreeNum+1), xInternal/2, horizontal - 80 - yInternal*(this.degreeNumMax-degreeNum+1));
                this.gra.DrawString(degreeNum.ToString(), histogramFont, Brushes.Green, 100 + 3 * xInternal / 4 + degree * xInternal + 3, 80 + yInternal * (this.degreeNumMax - degreeNum + 1) - 15);
            }
            //横轴、纵轴说明
            Font axisFont = new Font("Arial", 15, FontStyle.Bold | FontStyle.Italic);
            Brush axisBresh = new SolidBrush(Color.Green);
            this.gra.DrawString("节点数目", axisFont, axisBresh, new PointF(5, 80));
            this.gra.DrawString("度", axisFont, axisBresh, new PointF(this.picDegreeDistribution.Width-100-xInternal, horizontal + 20));
            // 释放资源
            brush.Dispose();
            axisBresh.Dispose();
            histogramBrush.Dispose();
        }
    }
}
