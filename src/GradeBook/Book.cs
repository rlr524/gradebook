using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{

    class Book
    {
        // a constructor that explicitly initializes grades
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        // here AddGrade is an instance member  (and instance method) of the class "Book" and will be available where we use 
        // that object as in our Program.cs file where we add a "new Book" object to instantiate the "Book" object...note no use of the static keyword
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        // these are instance fields that are associated with the object Book so when Book is available, grades and name are also available;
        // the object Book contains and encapsulates a list of grades and a name...these two pieces of state are private to the object Book
        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var gradeNumber in grades)
            {
                highGrade = Math.Max(gradeNumber, highGrade);
                lowGrade = Math.Min(gradeNumber, lowGrade);
                result += gradeNumber;
            };
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N2}");
            //N2 instructs to carry the number out two decimals; N3 would be three, etc.
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
        }
        private List<double> grades;
        private string name;
    }
}
