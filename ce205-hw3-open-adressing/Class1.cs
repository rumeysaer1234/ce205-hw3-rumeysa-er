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

namespace ce205_hw3_open_adressing
{
    public class Class1
    {
        public class HashNode
        {
            public int key;
            public string data;
            public HashNode(int key, string value)
            {
                this.key = key;
                this.data = value;
            }
            public int GetKey()
            {
                return this.key;
            }
            public string GetData()
            {
                return this.data;
            }
        }
        public class HashOps
        {
            HashNode[] table;
            const int maxSize = 10;
            #region Utilities
            public void OpenTable()
            {
                table = new HashNode[maxSize];
                for (int i = 0; i < maxSize; i++)
                {
                    table[i] = null;
                }
            }
            public bool CheckOpenSpace()
            {
                bool isOpen = false;
                for (int i = 0; i < maxSize; i++)
                {
                    if (table[i] == null)
                        isOpen = true;
                }
                return isOpen;
            }
            /**
             * @name Hash1
             * @param [in] key [\b int]]
             * hash function definition
             **/
            public int Hash1(int key)
            {
                return key % maxSize;
            }
            /**
            * @name Hash2
            * @param [in] key [\b int]]
            * Must be non-zero, less than array size, ideally odd
            **/
            public int Hash2(int key)
            {
                //Must be non-zero, less than array size, ideally odd
                return 5 - (key % 5);
            }
            #endregion

            #region Operations
            //Linear Insert
            /**
             * @name LinearInsert
             * @param [in] key [\b int]]
             * @param [in] data [\b string]]
             * These functions are sequential and their number indicates the level of the hash function.
             **/
            public void LinearInsert(int key, string data)
            {
                if (!CheckOpenSpace())
                {
                    Console.WriteLine("Table is at full capacity");
                    return;
                }
                int hash = Hash1(key);
                while (table[hash] != null && table[hash].GetKey() != key)
                {
                    hash = (hash + 1) % maxSize;
                }
                table[hash] = new HashNode(key, data);
            }
            //Quadratic Insert
            /**
            * @name QuadraticInsert
            * @param [in] key [\b int]]
            * @param [in] data [\b string]]
            * Another probe function that eliminates primary clustering is called quadratic probing.
            **/
            public void QuadraticInsert(int key, string data)
            {
                if (!CheckOpenSpace())
                {
                    Console.WriteLine("Table is at full capacity");
                    return;
                }
                int hash = Hash1(key);
                int j = 0;
                while (table[hash] != null && table[hash].GetKey() != key)
                {
                    j++;
                    hash = (hash + (j * j)) % maxSize;
                }
                table[hash] = new HashNode(key, data);
            }
            //Double Hashing
            /**
            * @name DoubleHashing
            * @param [in] key [\b int]]
            * @param [in] data [\b string]]
            * Double hashing is a computer programming technique used in conjunction with open addressing in hash tables to 
            * resolve hash conflicts by using a secondary hash of the key as an offset when a collision occurs.
            **/
            public void DoubleHashing(int key, string data)
            {
                if (!CheckOpenSpace())
                {
                    Console.WriteLine("Table is at full capacity");
                    return;
                }
                int hash1 = Hash1(key);
                int hash2 = Hash2(key);
                while (table[hash1] != null && table[hash1].GetKey() != key)
                {
                    hash1 = (hash1 + (hash2 * hash2)) % maxSize;
                }
                table[hash1] = new HashNode(key, data);
            }
            //Get Data through Linear Probing
            /**
             * @name GetDataLinearProbing
             * @param [in] key [\b int]]
             * n linear probing, the hash table is searched sequentially that starts from the original location of the hash. 
             * If in case the location that we get is already occupied, then we check for the next location. 
             **/
            public string GetDataLinearProbing(int key)
            {
                int hash = Hash1(key);
                while (table[hash] != null && table[hash].GetKey() != key)
                {
                    hash = (hash + 1) % maxSize;
                }
                if (table[hash] == null)
                    return "No data mapped with the given key";
                else
                    return table[hash].GetData();

            }
            //Get Data through Quadratic Probing
            /**
             * @name GetDataQuadraticProbing
             * @param [in] key [\b int]]
             * Quadratic probing is an open-addressing scheme where we look for the i2‘th slot in the i*2 iteration
             * if the given hash value x collides in the hash table. 
             **/
            public string GetDataQuadraticProbing(int key)
            {
                int hash = Hash1(key);
                int j = 0;
                while (table[hash] != null && table[hash].GetKey() != key)
                {
                    j++;
                    hash = (hash + (j * j)) % maxSize;
                }
                if (table[hash] == null)
                    return "No data mapped with the given key";
                else
                    return table[hash].GetData();

            }
            //Get Data through Double Hashing
            /**
           * @name GetDataDoubleHashing
           * @param [in] key [\b int]]
           * Double hashing is a collision resolving technique in Open Addressed Hash tables.
           * Double hashing uses the idea of applying a second hash function to key when a collision occurs.
           **/
            public string GetDataDoubleHashing(int key)
            {
                int hash1 = Hash1(key);
                int hash2 = Hash2(key);
                while (table[hash1] != null && table[hash1].GetKey() != key)
                {
                    hash1 = (hash1 + (hash2 * hash2)) % maxSize;
                }
                if (table[hash1] == null)
                    return "No data mapped with the given key";
                else
                    return table[hash1].GetData();

            }
            #endregion
        }
    }
}