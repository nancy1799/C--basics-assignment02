using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
            //Book Book01 = new Book();
            //Book01.Title = "harry potter";
            //Book01.pages = 250;
            //object obj = Book01;
            //Console.WriteLine(obj);
            #endregion

            #region Using the Book class above, print the result of calling ToString(), Equals() (compare book   with itself), GetHashCode(), and GetType() on book.
            //Book Mybook = new Book();
            //Mybook.Title = "harry potter";
            //Mybook.pages = 250;
            //Console.WriteLine(Mybook.ToString());
            //Console.WriteLine(Mybook.GetHashCode());
            //Console.WriteLine(Mybook.GetType());
            //Console.WriteLine(Mybook.Equals(Mybook));
            #endregion

            #region Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot  divide by zero", and then prints "Done" in a finally block.
            //int grade = 0;
            //int score = 10;
            //try
            //{

            //    int avg = score / grade;
            //    Console.WriteLine(avg);
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}


            #endregion

            #region Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double Newpages = pages;
            //Console.WriteLine(Newpages);
            #endregion

            #region Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int intprice = (int)price;
            //Console.WriteLine(intprice);

            #endregion

            #region Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagestext = "464";
            //int pages = Convert.ToInt32(pagestext);
            //Console.WriteLine(pages);
            #endregion


            #region Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =   "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //string yearText = "2023";
            //int year = int.Parse(yearText);
            //Console.WriteLine(year);

            //string badText = "abc";
            #endregion

            #region Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.

            //int Pages = 464;
            // string Newpages = Pages.ToString();
            //Console.WriteLine(Newpages);
            //Console.WriteLine(Newpages.GetType());
            #endregion

            #region Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.

            //int copies = 100;
            //object obj = copies;
            //int newcopies = (int)obj;
            //Console.WriteLine(copies);
            //Console.WriteLine(newcopies);
            #endregion


            #region Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its  value.

            //int? year = null;
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year.Value);
            #endregion


            #region Declare a string? reviewer = null;. Print whether it is null.
            //string? reviewer = null;
            //if (reviewer is null)
            //    Console.WriteLine(true);
            #endregion

            #region Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and print the result.

            //Book? book = null;
            //if (book is not null)
            //    Console.WriteLine(book.Title);
            #endregion


            #region Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= to assign title the value "Untitled" only if it's still null.

            //Book? book = null;

            //Console.WriteLine(book?.Title ?? "Untitled");



            #endregion

            #region Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable  string confirmedName using the ! operator.

            //string? name = "Ahmed";
            //string confirmedname = name!;
            //Console.WriteLine(confirmedname);
            #endregion
        }
    }
}
