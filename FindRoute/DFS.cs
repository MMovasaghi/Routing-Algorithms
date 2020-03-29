using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FindRoute
{    
    class DFS
    {
        private Stack<RouteTree> _stack { get; set; }
        private RouteTree Base { get; set; }
        private int x { get; set; }
        private int y { get; set; }
        public int stackOperation { get; set; }
        public int NodeVisited { get; set; }
        public DFS()
        {
            x = SearchBases.Source[0];
            y = SearchBases.Source[1];
            Base = new RouteTree();
            Base.x = x;
            Base.y = y;
            _stack = new Stack<RouteTree>();
            stackOperation = 0;
            NodeVisited = 0;
        }
        public int FindWay()
        {
            RouteTree Node = Base;
            bool Isfinish = false;
            bool Notfound = false;

            int i = 0;                       

            while (!AlgorithmBase.ProblemSolved(x,y) && !Isfinish && !Notfound)
            {
                NodeVisited += 4;
                if (SearchBases.map[x-1][y] == ' ' && Node.Top == null) //top
                {
                    x -= 1;
                    SearchBases.map[x][y] = '.';
                    Console.SetCursorPosition(y, x);
                    Console.Write(".");

                    
                    _stack.Push(Node);
                    Node.Top = new RouteTree();
                    Node.IsOK = Route.top;
                    Node.Top.PrevNode = Node;
                    Node = Node.Top;
                    Node.Down = Node.PrevNode;

                    Node.x = x;
                    Node.y = y;
                }
                else if (SearchBases.map[x][y+1] == ' ' && Node.Right == null) //right
                {
                    y += 1;
                    SearchBases.map[x][y] = '.';
                    Console.SetCursorPosition(y, x);
                    Console.Write(".");

                    _stack.Push(Node);
                    Node.Right = new RouteTree();
                    Node.IsOK = Route.right;
                    Node.Right.PrevNode = Node;
                    Node = Node.Right;
                    Node.Left = Node.PrevNode;

                    Node.x = x;
                    Node.y = y;
                }
                else if (SearchBases.map[x+1][y] == ' ' && Node.Down == null) //down
                {
                    x += 1;
                    SearchBases.map[x][y] = '.';
                    Console.SetCursorPosition(y, x);
                    Console.Write(".");

                    _stack.Push(Node);
                    Node.Down = new RouteTree();
                    Node.IsOK = Route.down;
                    Node.Down.PrevNode = Node;
                    Node = Node.Down;
                    Node.Top = Node.PrevNode;

                    Node.x = x;
                    Node.y = y;
                }
                else if (SearchBases.map[x][y-1] == ' ' && Node.Left == null) //left
                {
                    y -= 1;
                    SearchBases.map[x][y] = '.';
                    Console.SetCursorPosition(y, x);
                    Console.Write(".");

                    _stack.Push(Node);
                    Node.Left = new RouteTree();
                    Node.IsOK = Route.left;
                    Node.Left.PrevNode = Node;
                    Node = Node.Left;
                    Node.Right = Node.PrevNode;

                    Node.x = x;
                    Node.y = y;
                }
                else
                {
                    if(_stack.Count >= 1)
                    {
                        if (_stack.Peek() != null)
                        {
                            Node = _stack.Pop();
                            x = Node.x;
                            y = Node.y;
                            stackOperation++;
                        }
                        else
                            Isfinish = true;
                    }
                    else
                    {
                        Notfound = true;
                    }
                }
                Thread.Sleep(20);
                i++;
            }
            if(!Notfound)
            {
                _stack.Push(Node);
                stackOperation++;
                ShowWay();
            }
            else
            {
                Console.SetCursorPosition(0, 22);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\tWAY NOT FOUND");
            }
            return i;
        }
        public void ShowWay()
        {
            while (_stack.Count > 1)
            {
                NodeVisited++;
                var Node = _stack.Pop();               
                SearchBases.map[Node.x][Node.y] = 'o';
                Console.SetCursorPosition(Node.y, Node.x);
                Console.Write("o");
                stackOperation++;
            }
        }
    }
}
