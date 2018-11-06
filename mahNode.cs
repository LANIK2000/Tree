using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class mahNode
    {
        public int Num { get; set; }
        public mahNode lChild { get; set; }
        public mahNode rChild { get; set; }

        public mahNode(int getNum){
            Num = getNum;
        }

        public void Insert(int getNum)
        {
            if (this.Num == getNum)
                { /*Do nothing*/ }
            else if (this.Num < getNum)
            {
                if (this.rChild == null)
                    { this.rChild = new mahNode(getNum); }
                else
                    { this.rChild.Insert(getNum); }
            }
            else
            {
                if (this.lChild == null)
                    { this.lChild = new mahNode(getNum); }
                else
                    { this.lChild.Insert(getNum); }
            }
        }

        public string Search(int getNum)
        {
            if (this.Num == getNum)
                { return "FOUND"; }
            else if (this.Num < getNum)
            {
                if (rChild == null)
                    { return "NOT IN TREE"; }
                else
                    { return "RIGHT - " + rChild.Search(getNum); }
            }
            else
            {
                if (lChild == null)
                    { return "NOT IN TREE"; }
                else
                    { return "LEFT - " + lChild.Search(getNum); }
            }
        }

        public void Delete(int getNum)
        {
            if (this.Num < getNum)
            {
                if (this.rChild != null)
                    if(this.rChild.Num==getNum)
                        { this.rChild = null;}
                    else
                        { this.rChild.Delete(getNum); }
            }
            else
            {
                if (this.lChild != null)
                    if (this.lChild.Num == getNum)
                        { this.lChild = null; }
                    else
                        { this.lChild.Delete(getNum); }
            }
        }
    }
}
