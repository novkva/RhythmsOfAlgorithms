using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillAlgorithms
{
    public class Trees
    {
        Node root {get; set;}
        public Trees()
        {
            root = null;
        }
        public void Add(Node v, int x)
        {
            if (v == null)
            {
                return;
            }
            if (x < v.x)
            {
                if (v.l == null)
                {
                    v.l = new Node(x, v);
                    return;
                }
                Add(v.l, x);
            }
            else
            {
                if (v.r == null)
                {
                    v.r = new Node(x, v);
                    return;
                }
                Add(v.r, x);
            }
        }
        public void Add(int x)
        {
            if (root == null)
            {
                root = new Node(x, null);

            }
        }
    }

    public class Node 
    {
        int x;
        Node l;
        Node r;
        Node parent;
        Node(int x, Node parent)
        {
            this.x = x;
            this.parent = parent;
            this.l = null;
            this.r = null;
        }
    }
}