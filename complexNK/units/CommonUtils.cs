using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;


namespace complexNK.units
{
    class CommonUtils
    {   

        // 随机生成节点的坐标
        public static List<Point> createRandomLocations(int width, int height, int diameter)
        {
            // 相当于将panel划分为63个区域 9列，7行
            int xInterval = width / 9;
            int yInterval = height / 7;
            List<Point> points = new List<Point>();
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    double randx = r.NextDouble();
                    int x = (int)(randx * xInterval) + i*xInterval;
                    if (x > xInterval - diameter + i * xInterval)
                    {
                        x = xInterval - diameter + i * xInterval;
                    }   
                    double randy = r.NextDouble();
                    int y = j * yInterval + (int)(randy * yInterval);
                    if (y > yInterval - diameter + j * yInterval)
                        y = yInterval - diameter + j * yInterval;
                    Point point = new Point(x, y);
                    points.Add(point);
                }
            }
            return points;
        }

        public static List<List<string>> getDuplicateData(List<List<string>> data)
        {
            List<List<string>> duplicateData = new List<List<string>>();
            for (int i = 0; i < data.Count; i++)
            {
                List<string> row = new List<string>();
                for (int j = 0; j < data[i].Count; j++)
                {
                    row.Add(data[i][j]);
                }
                duplicateData.Add(row);
            }
            return duplicateData;
        }
              
      
    }
}
