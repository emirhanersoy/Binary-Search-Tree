using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir binary search tree oluştur
            BinaryTree tree = new BinaryTree();

            // Düğümleri ekle
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            // Inorder sıralamasını yazdır
            Console.WriteLine("Inorder traversal: ");
            tree.Inorder();

            // Düğüm ara
            int searchKey = 30;
            Console.WriteLine($"Is {searchKey} present in the tree: {tree.Search(searchKey)}");

            searchKey = 100;
            Console.WriteLine($"Is {searchKey} present in the tree: {tree.Search(searchKey)}");

            Console.ReadKey();
        }

        
    }
}
