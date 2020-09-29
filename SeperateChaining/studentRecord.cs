using System;
using System.Collections.Generic;
using System.Text;

namespace SeperateChaining
{
    class studentRecord
    {
        private int studentId;
        private string studentName;

        public studentRecord(int i, string name)
        {
            studentId = i;
            studentName = name;
        }

        public int getstudentId()
        {
            return studentId;
        }

        public void setstudentId(int i)
        {
            studentId = i;

        }

        public string tostring()
        {
            return studentId + " " + studentName + " ";
        }

    }
}
