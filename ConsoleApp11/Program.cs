using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp11
{

    class Book
    {
        public string title;
        int pages;
        public void F(int a , string b)
        {
            pages = a;
            title = b;
            Console.WriteLine(title + " " +pages);
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            
            LOTR.F(5, "Abeceda");
            
        }
    }
   
}
