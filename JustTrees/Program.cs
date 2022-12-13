using JustTrees.BTree;

Console.WriteLine("Hello, World!");

BTree binarySearchTree = new BTree();
binarySearchTree.Insert(30);
binarySearchTree.Insert(35);
binarySearchTree.Insert(50);
binarySearchTree.Insert(15);
binarySearchTree.Insert(60);
binarySearchTree.Insert(40);
binarySearchTree.Insert(80);
binarySearchTree.Insert(75);
binarySearchTree.Insert(65);
binarySearchTree.Insert(90);
binarySearchTree.Insert(85);

Console.WriteLine("Inorder Traversal is: ");
binarySearchTree.In_Order(binarySearchTree.ReturnRoot());

Console.WriteLine();
Console.WriteLine("Preorder Traversal is: ");
binarySearchTree.Pre_order(binarySearchTree.ReturnRoot());

Console.WriteLine();
Console.WriteLine("PostOrder Traversal is: ");
binarySearchTree.Post_Order(binarySearchTree.ReturnRoot());

Console.ReadLine();