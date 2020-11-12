using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    class Libary
    {

        public Libary() : base()
        {
            this.numberOfBooks = -1;
            this.numberOfStudents = -1;
        }
        private int numberOfBooks;
        public int NumberOfBooks
        {
            get => numberOfBooks;
            set => numberOfBooks = value;
        }
        private int numberOfStudents;
        public int NumberOfStudents
        {
            get => numberOfStudents;
            set => NumberOfStudents = value;
        }
        private List<string> studentsList = new List<string>();
        public List<string> StudentsList
        {
            get => studentsList;
            set => studentsList = value;
        }


        public void PrintAllVariables()
        {
            foreach (PropertyDescriptor item in TypeDescriptor.GetProperties(this))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
