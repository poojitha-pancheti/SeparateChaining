using System;
using System.Collections.Generic;
using System.Text;

namespace SeperateChaining
{
    class HashTable
    {
        private SingleLinkedList[] array;
        private int m;
        private int n;

        public HashTable() : this(11)
        {

        }

        public HashTable(int tableSize)
        {
            m = tableSize;
            array = new SingleLinkedList[tableSize];
            n = 0;
        }

        int hash(int key)
        {
            return (key % m);
        }

        public void Insert(studentRecord newRecord)
        {
            int key = newRecord.getstudentId();
            int h = hash(key);

            if (array[h] == null)
                array[h] = new SingleLinkedList();

            array[h].insertInBeginning(newRecord);
            n++;
            
        }
        public studentRecord Search(int key)
        {
            int h = hash(key);

            if (array[h] != null)
                return array[h].Search(key);
           
            return null;
        }
        public void DisplayTable()
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write("[" + i + "] ---> ");

                if (array[i] != null)
                    array[i].displayList();
                else
                    Console.WriteLine("___");
            }
        }

        public void Delete(int key)
        {
            int h = hash(key);

            if (array[h] != null)
            {
                array[h].deleteNode(key);
                n--;
            }

            else


                Console.WriteLine("value" + key + "not present\n");

        }
    }
}
