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
        public void Delete(int x)
        {
            if (root == null) return;
            Node t = Find(x);
            if (t ==null) return;
            Delete(t);
        }
        public void Delete(Node t)
        {
            if (t==null) return;
            if ((t.l ==null) || (t.r ==null))
            {
                Node child = null;
                if (t.l !=null)
                {
                    child = t.l;
                } 
                else child = t.r;
                if (t ==root)
                {
                    root = child;
                    if (child != null) child.parent = null;
                }
                if (t.parent.l == t){
                    t.parent.l = child;
                    if (child != null) child.parent = t.parent;
                }
                else
                {
                    t.parent.r = child;
                    if (child !=null) child.parent = t.parent;
                }
            }
            else
            {
                Node nxt = t.r;
                while (nxt.l != null){
                    nxt = nxt.l;
                }
                t.x = nxt.x;
                Delete(nxt);
            }
        }

        public Node Find(int x){
            return Find(root, x);
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