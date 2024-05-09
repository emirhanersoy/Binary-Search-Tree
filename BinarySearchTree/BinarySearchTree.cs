using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        // Kök düğüm
        public Node root;

        // Yeni bir düğüm eklemek için yardımcı yöntem
        private Node InsertRec(Node root, int data)
        {
            // Ağacın boşsa, yeni bir düğüm oluştur ve kök olarak ayarla
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            // Aksi takdirde, ağaçta gezinmeye başla
            if (data < root.data)
            {
                // Yeni düğümü sol alt ağaca ekle
                root.left = InsertRec(root.left, data);
            }
            else if (data > root.data)
            {
                // Yeni düğümü sağ alt ağaca ekle
                root.right = InsertRec(root.right, data);
            }

            // Değiştirilmiş kök düğümü döndür
            return root;
        }

        // Yeni bir düğüm eklemek için erişim yöntemi
        public void Insert(int data)
        {
            root = InsertRec(root, data);
        }

        // Bir düğümün varlığını kontrol etmek için yardımcı yöntem
        private bool SearchRec(Node root, int data)
        {
            // Ağaç boşsa veya düğüm yoksa, false döndür
            if (root == null)
                return false;

            // Düğüm bulunduğunda true döndür
            if (data == root.data)
                return true;

            // Aranan değer düğüm verisinden küçükse, sol ağaca git
            if (data < root.data)
                return SearchRec(root.left, data);

            // Aranan değer düğüm verisinden büyükse, sağ ağaca git
            return SearchRec(root.right, data);
        }

        // Bir düğümün varlığını kontrol etmek için erişim yöntemi
        public bool Search(int data)
        {
            return SearchRec(root, data);
        }

        // Ağacı inorder olarak dolaşmak için yardımcı yöntem
        private void InorderRec(Node root)
        {
            if (root != null)
            {
                InorderRec(root.left);
                Console.Write(root.data + " ");
                InorderRec(root.right);
            }
        }

        // Ağacı inorder olarak dolaşmak için erişim yöntemi
        public void Inorder()
        {
            InorderRec(root);
            Console.WriteLine();
        }
    }
}
