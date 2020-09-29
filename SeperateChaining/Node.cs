using System;
using System.Collections.Generic;
using System.Text;

namespace SeperateChaining
{
    class Node
    {
        public studentRecord info;
        public Node link;

        public Node(studentRecord rec)
        {
            info = rec;
            link = null;
        }
    }
}
