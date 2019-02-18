using System;
using System.Text;
using HashTable.Classes;


namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable HT = new Hashtable(1024);
            HashTable.Classes.Hashtable.Hash("Cat");
            Console.ReadLine();
        }
    }
}
