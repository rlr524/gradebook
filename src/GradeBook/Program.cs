using System;

namespace GradeBook
{
    // can think of a class as consisting of two things, the state (the data it holds, like the grade numbers below) and the
    // behavior that acts on that state, such as averaging it or getting a count of how many elements of data
    class Program
    {
        static void Main(string[] args)
        {
            // here we are referencing the Book() constructor method created in the Book() class created in Book.cs...this is a way of abstraction - encapsulating 
            // the components of the program so one component does one thing, not many...we bundle both the data (state) and
            // the behaviors (methods) that work on that data in one place...here we are using the Book() contstructor method to create a new book object
            var book = new Book("Rob's Grade Book");
            book.AddGrade(88.0);
            book.AddGrade(79.2);
            book.AddGrade(92.3);
            book.AddGrade(84.5);
            book.AddGrade(97.1);
            book.AddGrade(64.3);
            book.ShowStatistics();
        }
    }
}
