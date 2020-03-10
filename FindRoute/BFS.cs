using System;
using System.Collections.Generic;
using System.Text;

namespace FindRoute
{
    class BFS
    {
        private RouteTree Base { get; set; }
        private int x { get; set; }
        private int y { get; set; }
        private Queue<RouteTree> _queue { get; set; }
        public BFS()
        {
            Base = new RouteTree();
            Base.x = SearchBases.Source[0];
            Base.y = SearchBases.Source[1];
            _queue = new Queue<RouteTree>();
        }
        public void FindWay()
        {
            RouteTree Node = Base;
            //bool Isfinish = false;

            _queue.Enqueue(Node);

            while (!AlgorithmBase.ProblemSolved(Node.x, Node.y) && _queue.Count > 0)
            {
                if (SearchBases.map[Node.x - 1][Node.y] == ' ' && Node.Top == null) //top
                {
                    Node.Top = new RouteTree()
                    {
                        PrevNode = Node,
                        x = Node.x - 1,
                        y = Node.y
                    };

                    SearchBases.map[Node.Top.x][Node.Top.y] = '.';
                    Console.SetCursorPosition(Node.Top.y, Node.Top.x);
                    Console.Write(".");

                    _queue.Enqueue(Node.Top);
                }
                if (SearchBases.map[Node.x][Node.y + 1] == ' ' && Node.Right == null) //right
                {
                    Node.Right = new RouteTree()
                    {
                        PrevNode = Node,
                        x = Node.x,
                        y = Node.y + 1
                    };

                    SearchBases.map[Node.Right.x][Node.Right.y] = '.';
                    Console.SetCursorPosition(Node.Right.y, Node.Right.x);
                    Console.Write(".");

                    _queue.Enqueue(Node.Right);
                }
                if (SearchBases.map[Node.x + 1][Node.y] == ' ' && Node.Down == null) //down
                {
                    Node.Down = new RouteTree()
                    {
                        PrevNode = Node,
                        x = Node.x + 1,
                        y = Node.y
                    };

                    SearchBases.map[Node.Down.x][Node.Down.y] = '.';
                    Console.SetCursorPosition(Node.Down.y, Node.Down.x);
                    Console.Write(".");

                    _queue.Enqueue(Node.Down);
                }
                if (SearchBases.map[Node.x][Node.y - 1] == ' ' && Node.Left == null) //left
                {
                    Node.Left = new RouteTree()
                    {
                        PrevNode = Node,
                        x = Node.x,
                        y = Node.y - 1
                    };

                    SearchBases.map[Node.Left.x][Node.Left.y] = '.';
                    Console.SetCursorPosition(Node.Left.y, Node.Left.x);
                    Console.Write(".");

                    _queue.Enqueue(Node.Left);
                }
                Node = _queue.Dequeue();
            }            
            this.ShowWay(Node);
        }
        public void ShowWay(RouteTree Node)
        {
            SearchBases.map[Node.x][Node.y] = 'o';
            Console.SetCursorPosition(Node.y, Node.x);
            Console.Write("o");

            while (Node.PrevNode.PrevNode != null)
            {
                Node = Node.PrevNode;
                SearchBases.map[Node.x][Node.y] = 'o';
                Console.SetCursorPosition(Node.y, Node.x);
                Console.Write("o");                
            }
        }
    }
}
