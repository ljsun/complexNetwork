using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace complexNK.units
{
    class NodeRank
    {
        // 这里的index依旧是标号，而非行号
        public int index;
        public int rank;
        public NodeRank(int index, int rank)
        {
            this.index = index;
            this.rank = rank;
        }
    }
}
