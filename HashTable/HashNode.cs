using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HashNode
{

    private string name = null;
    private string drink = null;
    private HashNode Next = null;

    public HashNode(string name, string drink)
    {
        this.name = name;
        this.drink = drink;
        Next = null;
    }

    public string getname() { return name; }

    public void setname(string name) { this.name = name; }

    public string getdrink() { return drink; }

    public void setdrink(string drink) { this.drink = drink; }

    public HashNode getNext() { return Next; }

    public void setNext(HashNode Next) { this.Next = Next; }
}
