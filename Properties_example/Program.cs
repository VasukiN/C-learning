using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_example
{
    public interface ILibrary
        {
            void BookVeriety();
            void BookExibition();
        
        }
    protected class Library : ILibrary
    {
        public string[] BookKind = { "Friction", "Non Friction", "Autobiagraphy", "Slef Help", "Adventures", "Drama", "Religious" };

        private string book;
        public string Book
        {
            get { return book; }
            set
            {
                if (value==null)
                {
                
                throw new ArgumentNullException("value"); }

                book = value;
            }

        }
        private float price;
        public float Price
        {

            get { return price; }
            set
            {
                if (value < 0)
                    throw new IndexOutOfRangeException("Price should be greater than ZERO");
                else
                    price = value;
            }
        }

        public Library()
        {

        }
        public void BookVeriety()
        {
            Console.WriteLine("Variety of Books available in Exibition are as follows");
            foreach (string b in BookKind)
            {
                
                Console.WriteLine(b);
                //Console.ReadLine();
            }
        }
        public void BookExibition()
        {
            foreach (string b in BookKind)
            {
                if (Book=="")
                {
                    Console.WriteLine("No books available under this category");
                }
                Console.WriteLine("Kind of Book: {0} && Name of Book : {1} Price of Book : {2}", b,Book ,Price);
                Console.ReadLine();
            }
        }
    }
    class Program : Library
    {
        static void Main(string[] args)
        {
            Library l1 = new Program();
            l1.BookVeriety();
            l1.Book = "Who will cry when you die";
            l1.Price = 170.50f;
            l1.BookExibition();
            l1.Book = "Mahadev";
            l1.Price = 300.00f;
            
            l1.BookExibition();



        }
    }
}
