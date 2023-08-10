using BinaryTrees.Tree;

namespace BinaryTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            var tree = new BinaryTree<int>();

            foreach (var item in new[]{8,5,6,4,1,2 }) 
            {
                tree.Add(item);
            }

           

        
                tree.Root.Display(); //8

                tree.Root.Left.Display(); //5
                tree.Root.Left.Left.Display();//4
                tree.Root.Left.Right.Display();//6

                tree.Root.Left.Left.Left.Display();
                tree.Root.Left.Left.Left.Right.Display();



            Console.ReadLine();
        }
    }
}