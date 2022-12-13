using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static ce205_hw3_open_adressing.Class1;
using static ce205_hw3_hashing_with_chaining.Class1;
using static ce205_hw3_avl_redblack_bplus_tree.Class1;

namespace ce205_hw3_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Hashing_With_Chaining_Test1()
        {
            HashSc hashSc = new HashSc();
            hashSc.opentable();
            string LoremText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum molestie.\r\n\r\n";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashSc.insert(i + 1, LoremArray[i]);
            string result = hashSc.retrieve(3);
            string expected = "dolor";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Hashing_With_Chaining_Test2()
        {
            HashSc hashSc = new HashSc();
            hashSc.opentable();
            string LoremText = "Cras semper at nisl quis ultricies. Donec venenatis fringilla mauris.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashSc.insert(i + 1, LoremArray[i]);
            string result = hashSc.retrieve(1);
            string expected = "Cras";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Hashing_With_Chaining_Test3()
        {
            HashSc hashSc = new HashSc();
            hashSc.opentable();
            string LoremText = "Suspendisse egestas porttitor quam, sed scelerisque felis gravida ac. Vivamus.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashSc.insert(i + 1, LoremArray[i]);
            string result = hashSc.retrieve(9);
            string expected = "ac.";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Open_Addressing_LinearProbing_Test1()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Mauris ornare, ante ut ullamcorper blandit, nibh tortor scelerisque magna.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.LinearInsert(i + 1, LoremArray[i]);
            string result = hashOps.GetDataLinearProbing(4);
            string expected = "ut";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Open_Addressing_LinearProbing_Test2()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Aliquam efficitur elit non augue consectetur eleifend. Cras ultricies iaculis.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.LinearInsert(i + 1, LoremArray[i]);
            string result = hashOps.GetDataLinearProbing(1);
            string expected = "Aliquam";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Open_Addressing_LinearProbing_Test3()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Nulla facilisi. Donec et elit sed tortor pretium sodales in.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.LinearInsert(i + 1, LoremArray[i]);
            string result = hashOps.GetDataLinearProbing(6);
            string expected = "sed";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Open_Addressing_QuadraticProbing_Test1()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Nunc pharetra ex a nisl hendrerit, vitae ullamcorper odio dictum.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.QuadraticInsert(i + 1, LoremArray[i]);
            string result = hashOps.GetDataQuadraticProbing(4);
            string expected = "a";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Open_Addressing_QuadraticProbing_Test2()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Suspendisse risus turpis, ultricies dictum purus et, convallis congue massa.\r\n\r\n";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.QuadraticInsert(i + 1, LoremArray[i]);
            string result = hashOps.GetDataQuadraticProbing(6);
            string expected = "purus";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Open_Addressing_QuadraticProbing_Test3()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Suspendisse tincidunt orci erat, id convallis metus efficitur non. Etiam.\r\n\r\n";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.QuadraticInsert(i + 1, LoremArray[i]);
            string result = hashOps.GetDataQuadraticProbing(3);
            string expected = "orci";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Open_Addressing_DoubleHashing_Test1()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Ut eget mollis magna. Vivamus bibendum non erat sit amet.\r\n\r\n";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.DoubleHashing(i + 1, LoremArray[i]);
            string result = hashOps.GetDataDoubleHashing(6);
            string expected = "bibendum";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Open_Addressing_DoubleHashing_Test2()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Sed non ipsum at orci interdum accumsan vel vel libero.\r\n\r\n";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.DoubleHashing(i + 1, LoremArray[i]);
            string result = hashOps.GetDataDoubleHashing(6);
            string expected = "interdum";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Open_Addressing_DoubleHashing_Test3()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Morbi ac lacus eget metus luctus gravida. Donec tincidunt in.\r\n\r\n";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.DoubleHashing(i + 1, LoremArray[i]);
            string result = hashOps.GetDataDoubleHashing(2);
            string expected = "ac";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AVLTree_Test1()
        {
            AVLTree tree = new AVLTree();

            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Fusce accumsan risus orci, porttitor bibendum orci pharetra at. In.\r\n\r\n";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.LinearInsert(i + 1, LoremArray[i]);

            /* Constructing tree given in the above figure */
            for (int i = 1; i < LoremArray.Length; i++)
                tree.root = tree.insert(tree.root, i);

            string result = "";

            tree.root = tree.deleteNode(tree.root, 10);

            result = hashOps.GetDataLinearProbing(tree.search(5).key);

            string expected1 = "porttitor";

            Assert.AreEqual(expected1, result);
        }

        [TestMethod]
        public void AVLTree_Test2()
        {
            AVLTree tree = new AVLTree();

            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Aliquam eget libero euismod, fermentum nibh et, finibus erat. Nam.\r\n\r\n";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.LinearInsert(i + 1, LoremArray[i]);

            /* Constructing tree given in the above figure */
            for (int i = 1; i < LoremArray.Length; i++)
                tree.root = tree.insert(tree.root, i);

            string result = "";

            tree.root = tree.deleteNode(tree.root, 10);

            result = hashOps.GetDataLinearProbing(tree.search(3).key);

            string expected1 = "libero";

            Assert.AreEqual(expected1, result);
        }

        [TestMethod]
        public void AVLTree_Test3()
        {
            AVLTree tree = new AVLTree();

            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Sed eu est felis. Vivamus vel mauris quis magna tempor.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.LinearInsert(i + 1, LoremArray[i]);

            /* Constructing tree given in the above figure */
            for (int i = 1; i < LoremArray.Length; i++)
                tree.root = tree.insert(tree.root, i);

            string result = "";

            tree.root = tree.deleteNode(tree.root, 10);

            result = hashOps.GetDataLinearProbing(tree.search(8).key);

            string expected1 = "quis";

            Assert.AreEqual(expected1, result);
        }
        [TestMethod]
        public void RedBlackTree1()
        {
            RedBlackTree tree = new RedBlackTree();

            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Donec ut ultricies justo. Quisque sit amet sem sit amet libero cursus accumsan. Integer condimentum elit non risus vehicula, elementum.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.LinearInsert(i + 1, LoremArray[i]);

            for (int i = 0; i < LoremArray.Length; i++)
                tree.Insert(i + 1);

            string result = hashOps.GetDataLinearProbing(tree.Find(1).data);

            string expected1 = "Donec";

            Assert.AreEqual(expected1, result);
        }
    }
}
