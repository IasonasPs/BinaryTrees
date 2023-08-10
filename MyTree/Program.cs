using MyTree.Tree;

namespace MyTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();


            var array =new[] {8,5,6,4,9,2,10,0};



            foreach (var item in array) 
            {
                   tree.Add(item);
            }

            tree.Root.Display();//8
                tree.Root.Right.Display();//9
                    tree.Root.Right.Right.Display();//10
                tree.Root.Left.Display();//5
                    tree.Root.Left.Right.Display();//6
                    tree.Root.Left.Left.Display();//4
                        tree.Root.Left.Left.Left.Display();//2
                            tree.Root.Left.Left.Left.Left.Display();//2















        }
    }
}