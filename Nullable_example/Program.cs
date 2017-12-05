using System;

namespace Nullable_example
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? middlename = true;
            if (middlename == true)
            {
                Console.WriteLine("User is  major ");
            }
            else
                if (middlename == false)
            {
                Console.WriteLine("User is not major");
            }
            else
            {
                Console.WriteLine("USer didnot specified the major");
            }
        }

    }
}
