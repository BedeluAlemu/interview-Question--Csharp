using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class HashTable
{
    public int size = 10;
    HashNode[] Table;

    /* constructor*/
    HashTable()
    {
        Table = new HashNode[size];
        for (int i = 0; i < size; i++)
        {
            Table[i] = (null);

        }


    }

    public void insert(string drink, string name)
    {
        HashNode pointer = null;

        int index = HashFunction(name);

        index = index % size;

        HashNode NewObj = new HashNode(drink, name);

        if (Table[index] == null)
        {
            Table[index] = NewObj;
        }
        else
        {
            pointer = Table[index];

            while (pointer.getNext() != null)
            {
                pointer = pointer.getNext();
            }
            pointer.setNext(NewObj);

        }


    }
    public int HashFunction(string name)
    {
        int index = 0;
        for (int i = 0; i < name.Length; i++)
        {
            index = index + (int)name[i];

        }


        return index;
    }

    public void PrintFunction()
    {
        HashNode current = null;
        for (int i = 0; i < size; i++)
        {
            current = Table[i];
            while (current != null)
            {
                Console.WriteLine("===================\n");
                Console.WriteLine("Index = {0}\n", i);
                Console.WriteLine("Name = {0}\n", current.getname());
                Console.WriteLine("Drink = {0}\n", current.getdrink());
                current = current.getNext();
            }
        }

    }
    static void Main(string[] args)
    {
        HashTable HT = new HashTable();
        HT.insert("coke", "mike");
        HT.insert("2coke", "2mike");
        HT.insert("2coke", "2mike");
        HT.insert("2coke", "2mike");
        HT.insert("3coke", "3mike");
        HT.insert("4coke", "4mike");
        HT.insert("5coke", "5mike");
        HT.insert("4coke", "4mike");
        HT.PrintFunction();
        Console.ReadKey();

    }
}
