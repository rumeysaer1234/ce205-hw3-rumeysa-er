/**
* @file ce205_hw3-rumeysa-er
* @author Rumeysa Er
* @date 13 December 2022
*
* @brief <b> HW-3 Functions </b>
*
* HW-3 Sample Lib Functions
*
* @see http://bilgisayar.mmf.erdogan.edu.tr/en/
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw3_hashing_with_chaining
{
    public class Class1
    {
        //program to implement hashing with chaining
        public class HashSc
        {
            public class hashnode
            {
                //insert the keys into the hash table
                int key;
                string data;
                hashnode next;
                /**
                 * @name hashnode
                 * @param [in] key [\b int]]
                 * @param [in] data [\b string]
                 * declaration of node
                 * **/
                public hashnode(int key, string data)
                {
                    this.key = key;
                    this.data = data;
                    next = null;
                }
                public int getkey()
                {
                    return key;
                }
                public string getdata()
                {
                    return data;
                }
                public void setNextNode(hashnode obj)
                {
                    next = obj;
                }
                public hashnode getNextNode()
                {
                    return this.next;
                }
            }

            hashnode[] table;
            const int size = 100;

            public void opentable()
            {
                table = new hashnode[size];
                for (int i = 0; i < size; i++)
                {
                    table[i] = null;
                }
            }
            /**
             * @name insert
             * @param [in] key [\b int]]
             * @param [in] data [\b string]
             * inserting method
             * * **/
            public void insert(int key, string data)
            {
                hashnode nObj = new hashnode(key, data);
                int hash = key % size;
                while (table[hash] != null && table[hash].getkey() % size != key % size)
                {
                    hash = (hash + 1) % size;
                }
                if (table[hash] != null && hash == table[hash].getkey() % size)
                {
                    nObj.setNextNode(table[hash].getNextNode());
                    table[hash].setNextNode(nObj);
                    return;
                }
                else
                {
                    table[hash] = nObj;
                    return;
                }
            }
            /**
               * @name retrieve
               * @param [in] key [\b int]]
               * Returns an integer value generated using the backward hashing algorithm.
               * **/
            public string retrieve(int key)
            {
                int hash = key % size;
                while (table[hash] != null && table[hash].getkey() % size != key % size)
                {
                    hash = (hash + 1) % size;
                }
                hashnode current = table[hash];
                while (current.getkey() != key && current.getNextNode() != null)
                {
                    current = current.getNextNode();
                }
                if (current.getkey() == key)
                {
                    return current.getdata();
                }
                else
                {
                    return "nothing found!";
                }
            }
            /**
              * @name remove
              * @param [in] key [\b int]]
              * removing an element
              * a current node pointer used for traversal, currently points to the head
              * **/
            public void remove(int key)
            {
                int hash = key % size;
                while (table[hash] != null && table[hash].getkey() % size != key % size)
                {
                    hash = (hash + 1) % size;
                }
                //a current node pointer used for traversal, currently points to the head
                hashnode current = table[hash];
                bool isRemoved = false;
                while (current != null)
                {
                    if (current.getkey() == key)
                    {
                        table[hash] = current.getNextNode();
                        Console.WriteLine("entry removed successfully!");
                        isRemoved = true;
                        break;
                    }

                    if (current.getNextNode() != null)
                    {
                        if (current.getNextNode().getkey() == key)
                        {
                            hashnode newNext = current.getNextNode().getNextNode();
                            current.setNextNode(newNext);
                            Console.WriteLine("entry removed successfully!");
                            isRemoved = true;
                            break;
                        }
                        else
                        {
                            current = current.getNextNode();
                        }
                    }

                }

                if (!isRemoved)
                {
                    //delete from hash table
                    Console.WriteLine("nothing found to delete!");
                    return;
                }
            }
        }
    }
}