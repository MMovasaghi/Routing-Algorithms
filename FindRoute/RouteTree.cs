using System;
using System.Collections.Generic;
using System.Text;

namespace FindRoute
{
    enum Route
    {
        top,
        right,
        down,
        left
    }
    class RouteTree
    {
        public RouteTree Top { get; set; }
        public RouteTree Right { get; set; }
        public RouteTree Down { get; set; }
        public RouteTree Left { get; set; }
        public RouteTree PrevNode { get; set; }
        public Route IsOK { get;set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}
