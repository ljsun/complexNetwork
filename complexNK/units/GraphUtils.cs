using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace complexNK.units
{
    class GraphUtils
    {
        //计算邻居节点的数目
        public static int getNumberOfNeighbors(List<List<string>> data, int index)
        {
            int number = 0;
            //找到index节点所在的行
            List<string> row = data[index - 1];
            for (int i = 0; i<row.Count; i++)
            {
                if (row[i].Equals("y"))
                    number++;
            }
            return number;
        }

        //计算邻居节点的index（这里的index指的是标号)
        public static List<int> getNeighbors(List<List<string>> data, int index)
        {
            List<int> neighbors = new List<int>();
            List<string> row = data[index - 1];
            for (int i = 0; i < row.Count; i++)
            {
                if (row[i].Equals("y"))
                {
                    // 加1是为了返回节点的标号
                    neighbors.Add(i + 1);
                }
            }
            return neighbors;
        }

        // 判断两个节点之间是否有边相连
        public static Boolean isNeighbor(List<List<string>> data, int index1, int index2)
        {
            return data[index1 - 1][index2 - 1].Equals("y");
        }

        //计算邻居间实际存在的边的数目
        public static int getExistingEdgesOfNeighbors(List<List<string>> data, int index)
        {
            // 返回邻居节点的标号
            List<int> neighbors = GraphUtils.getNeighbors(data, index);
            int existingEdges = 0;
            for (int i = 0; i < neighbors.Count; i++)
            {
                for (int j = 0; j < neighbors.Count; j++)
                {
                    // 判断两个节点之前是否有边相连
                    if (GraphUtils.isNeighbor(data, neighbors[i], neighbors[j]))
                        existingEdges++;
                }
            }
            // 返回邻居节点间存在的边的数目
            return existingEdges/2;
        }

        //计算各个邻居间可能存在的最大边的数目
        public static int getPossibleEdgesOfNeighbors(List<List<string>> data, int index)
        {
            int numberOfNeighbors = GraphUtils.getNumberOfNeighbors(data, index);
            return numberOfNeighbors * (numberOfNeighbors - 1) / 2;
        }

        // 计算每个节点的聚类因子
        public static double getClusterCoefficient(List<List<string>> data, int index)
        {
            // 计算邻居间实际存在的边的数目
            int existingEdgesOfNeighbors = GraphUtils.getExistingEdgesOfNeighbors(data, index);
            // 计算邻居间可能存在的边的数目
            int possibleEdgesOfNeighbors = GraphUtils.getPossibleEdgesOfNeighbors(data, index);
            //判断分母是否为0
            if (possibleEdgesOfNeighbors.Equals(0))
                return 0;
            return 1.0*existingEdgesOfNeighbors/possibleEdgesOfNeighbors;
        }

        // 计算平均聚类因子
        public static double getAverageClusterCoefficient(List<List<string>> data)
        {
            double sumOfClusteringCoefficient = 0;
            for (int i = 0; i < data.Count; i++)
            {
                sumOfClusteringCoefficient += GraphUtils.getClusterCoefficient(data, i + 1);
            }
            return sumOfClusteringCoefficient / data.Count;
        }

        // 计算某一个node的度
        public static int getDegreeeOfNode(List<List<string>> data, int index)
        {
            List<string> row = data[index - 1];
            int degree = 0;
            for (int i = 0; i < row.Count; i++)
            {
                if (row[i].Equals("y"))
                    degree++;
            }
            return degree;
        }

        // 计算所有节点的平均的度
        public static double getAverageDegree(List<List<string>> data)
        {
            int sumDegree = 0;
            for (int i = 1; i <= data.Count; i++)
            {
                sumDegree += getDegreeeOfNode(data, i);
            }
            return 1.0*sumDegree/data.Count;
        }

        // 得到所有节点的度
        public static List<int> getAllDegree(List<List<string>> data)
        {
            List<int> allDegree = new List<int>();
            for (int i = 0; i < data.Count; i++)
            {
                List<string> row = data[i];
                int degree = 0;
                for (int j = 0; j < row.Count; j++)
                {
                    if (row[j].Equals("y"))
                        degree++;
                }
                allDegree.Add(degree);
            }
            return allDegree;
        }

        // 得到度最大的节点
        public static int getIndexOfMaxDegree(List<List<string>> data)
        {
            List<int> allDegree = GraphUtils.getAllDegree(data);
            int maxDegree = -1;
            foreach (int degree in allDegree)
            {
                if (degree > maxDegree)
                    maxDegree = degree;
            }
            int i;
            for (i=0; i < allDegree.Count; i++)
            {
                if (allDegree[i] == maxDegree)
                    break;
            }
            return i + 1;
        }

        // 计算图中最大的度
        public static int getMaxDegree(List<List<string>> data)
        {
            List<int> allDegree = GraphUtils.getAllDegree(data);
            return allDegree.Max();
        }

        // 此处的index依旧是节点标号，而不是list中的index
        public static void removeNode(List<List<string>> data, int index)
        {
            // 将index-1行全部变为r，表示已经移除，即将对应的行值变为r
            for (int i = 0; i < data[index - 1].Count; i++)
            {
                data[index - 1][i] = "r";
            }
            //再将对应的列值变为r
            for (int i = 0; i < data.Count; i++)
            {
                data[i][index - 1] = "r";
            }
        }

        // 计算每一个节点的coreness
        public static List<int> getNodeCoreness(List<List<string>> data)
        {
            // 若最大的度为m，则每一个节点的coreness必在0~m之间
            List<int> allCoreness = new List<int>();
            // 先初始化每一个节点的coreness
            for (int i = 0; i < data.Count; i++)
            {
                allCoreness.Add(0);
            }
            // 由于各个方法中关于data的传递全部是引用传递，
            // 而这里需要修改data中的内容，所以最好再开辟新的空间来存放一个data
            List<List<string>> duplicateData = CommonUtils.getDuplicateData(data);
            // 计算最大的度
            int maxDegree = GraphUtils.getMaxDegree(duplicateData);
            // 判断节点是否被移除
            Boolean isRemove;
            // 从度为0一直移除到度为maxDegree, 也就是从0-coreness图一直计算到k-coreness图
            for (int k = 0; k <= maxDegree+1; k++)
            {
                // 开始计算k-coreness图
                List<int> allDegree = GraphUtils.getAllDegree(duplicateData);
                isRemove = false;
                for (int i = 0; i < duplicateData.Count; i++)
                {
                    // 如果该点没有被移除
                    if (!(duplicateData[i][i].Equals("r")))
                    {
                        if (allDegree[i] < k)
                        {
                            allCoreness[i] = k - 1;
                            //移除该点, 这里仍需要传入该节点的标号
                            GraphUtils.removeNode(duplicateData, i + 1);
                            // 各个点的度很可能已经发生变化，需要重新计算各个点的度
                            isRemove = true;
                            break;
                        }
                        // 如果该点的度>=k
                        else
                        {
                            allCoreness[i] = k;
                        }
                        
                    }
                }
                if (isRemove)
                    k--;
            }
            return allCoreness;
        }

        // 计算整个图的coreness
        public static int getGraphCoreness(List<List<string>> data)
        {
            List<int> allCoreness = GraphUtils.getNodeCoreness(data);
            return allCoreness.Max();
        }

        // 以某一个点为起始点，开始搜索该点与其它点的所有最短路径, startIndex依旧是标号
        public static List<int> getAllShortestPathOfNode(List<List<string>> data, int startIndex)
        {
            List<int> shortestPath = new List<int>();
            // 先初始化最短路径的值
            for (int i = 0; i < data.Count; i++)
            {
                shortestPath.Add(-1);
            }
            // 创建访问节点队列
            Queue<NodeRank> queue = new Queue<NodeRank>();
            NodeRank startNode = new NodeRank(startIndex, 0);
 
            // 判断某一节点是否已经被访问
            List<int> visited = new List<int>();
            
            // 初始节点进队列
            queue.Enqueue(startNode);
            shortestPath[startNode.index - 1] = startNode.rank;
            visited.Add(startNode.index);

            // 如果队列不为空，则继续访问
            while (!(queue.Count == 0))
            {
                NodeRank currentNode = queue.Dequeue();
                // 每一个节点都判断是否与当前节点连接
                for (int i = 0; i < data[currentNode.index - 1].Count; i++)
                {
                    if (data[currentNode.index - 1][i].Equals("y") && !visited.Contains(i + 1))
                    {
                        // 满足条件则进队列
                        NodeRank node = new NodeRank(i + 1, currentNode.rank + 1);
                        queue.Enqueue(node);
                        shortestPath[node.index - 1] = node.rank;
                        visited.Add(node.index);
                    }
                }
            }
            // 在shortestPath中，如果有-1，则说明该点与起始点是不连通的
            return shortestPath;
        }

        // 计算某两个点之间的最短路径
        public static int getNodeToNodeShortestPath(List<List<string>> data, int startIndex, int endIndex)
        {
            List<int> shortestPath = GraphUtils.getAllShortestPathOfNode(data, startIndex);
            return shortestPath[endIndex - 1];
        }

        // 判断某一个节点是否被移除
        public static Boolean isRemove(List<List<string>> data, int index)
        {
            Boolean isRemove = false;
            if (data[index - 1][index - 1].Equals("r"))
                isRemove = true;
            return isRemove;
        }

        // 判断是否所有节点都已经被移除
        public static Boolean isAllRemove(List<List<string>> data)
        {
            Boolean isAllRemove = true;
            for (int i = 0; i < data.Count; i++)
            {
                if (!data[i][i].Equals("r"))
                    isAllRemove = false;
            }
            return isAllRemove;
        }

        public static List<int> getSubgraph(List<List<string>> data)
        {
            int startIndex = 1;
            for (int i = 0; i < data.Count; i++)
            {
                if (!GraphUtils.isRemove(data, i + 1))
                {
                    startIndex = i + 1;
                }
            }
            Queue<int> queue = new Queue<int>();
            List<int> visited = new List<int>();
            // 进队列
            queue.Enqueue(startIndex);
            visited.Add(startIndex);
            while (queue.Count != 0)
            {
                int currentIndex = queue.Dequeue();
                for (int i=0; i<data[currentIndex - 1].Count; i++)
                {
                    if (data[currentIndex - 1][i].Equals("y") && !visited.Contains(i+1))
                    {
                        queue.Enqueue(i + 1);
                        visited.Add(i + 1);
                    }
                }
            }
            return visited;
        }

        //计算子图
        public static List<List<int>> getAllSubgraph(List<List<string>> data)
        {
            List<List<int>> allSubgraph = new List<List<int>>();
            List<List<string>> duplicateData = CommonUtils.getDuplicateData(data) ;
            // 只要图不为空，就一直去找子图
            while (!GraphUtils.isAllRemove(duplicateData))
            {
                List<int> subgraph = GraphUtils.getSubgraph(duplicateData);
                allSubgraph.Add(subgraph);
                // 删除该子图中所有节点
                foreach (int index in subgraph)
                {
                    GraphUtils.removeNode(duplicateData, index);
                }
            }
            return allSubgraph;

        }

        // 计算各个联通子图的平均最短路径
        public static List<double> getGraphShorestPath(List<List<string>> data)
        {
            List<List<int>> allSubgraph = GraphUtils.getAllSubgraph(data);
            List<double> shorestPath = new List<double>();
            foreach (List<int> subgraph in allSubgraph)
            {
                int length = 0;
                int numOfEdge = 0;
                double averagePath = 0;
                foreach (int nodeIndex in subgraph)
                {
                    List<int> nodeShorestPath = GraphUtils.getAllShortestPathOfNode(data, nodeIndex);
                    foreach (int friendNode in subgraph)
                    {
                        if (nodeShorestPath[friendNode - 1] != 0)
                        {
                            length += nodeShorestPath[friendNode - 1];
                            numOfEdge += 1;
                        }
                    }
                }
                // 判断子图是否是单个节点
                if (numOfEdge == 0)
                    shorestPath.Add(averagePath);
                else
                {
                    averagePath = 1.0 * length / numOfEdge;
                    shorestPath.Add(averagePath);
                }
            }
            return shorestPath;
        }

        // 随机攻击某一个节点
        public static List<List<string>> RandomAttack(List<List<string>> data, int index)
        {
            // 由于data不能发生变化， 所以在这里要创建data的副本
            List<List<string>> duplicateData = CommonUtils.getDuplicateData(data);
            // 攻击某个节点即在duplicateData中删除某个节点
            GraphUtils.removeNode(duplicateData, index);
            return duplicateData;
        }
    }
}
