using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Libary schoolLibary = new Libary();
            schoolLibary.NumberOfStudents = 2;
            schoolLibary.NumberOfBooks = 4;
            schoolLibary.StudentsList.Add("John");
            schoolLibary.StudentsList.Add("Poul");

            Book book1 = new Book("Elektrika", 256, "Ján", "Učebnica", 2000);
            Book book2 = new Book("Veľká enckylopedia o Autách", 256, "Anna", "Encyklopedia", 2000);
            Book book3 = new Book("C# od A-Z", 256, "Peter", "Príručka", 2000);
            Book book4 = new Book("Arduino", 256, "Miro", "Dobrodružná", 2000);
            schoolLibary.PrintAllVariables();
            Console.ReadLine();
        }
    }
}
