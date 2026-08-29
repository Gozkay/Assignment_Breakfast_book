using System;

class Program
{
    static void Main()
    {
        // Assignment 1
        // 1-dimensional string array containing breakfast from Monday-Friday
        string[] groceries = { "Okpa", "Bread and Tea", "Egg and Bread", "Akara and Bread", "Yam and Sauce" };


        // Assignment 2
        // 1-dimensional int array containing how satisfied you were
        int[] satisfaction = { 5, 3, 4, 5, 2 };


        // Assignment 3
        // Printing sentences using elements from both arrays

        Console.WriteLine("The food I had on Monday was " + groceries[0] +
                          " and it was " + satisfaction[0] + " stars.");

        Console.WriteLine("The food I had on Tuesday was " + groceries[1] +
                          " and it was " + satisfaction[1] + " stars.");

        Console.WriteLine("The food I had on Wednesday was " + groceries[2] +
                          " and it was " + satisfaction[2] + " stars.");

        Console.WriteLine("The food I had on Thursday was " + groceries[3] +
                          " and it was " + satisfaction[3] + " stars.");

        Console.WriteLine("The food I had on Friday was " + groceries[4] +
                          " and it was " + satisfaction[4] + " stars.");


        // Assignment 4
        // 2-dimensional string array
        // 3 rows = 3 books
        // 4 columns = title, author, publishing date, genre

        string[,] library =
        {
            { "Things Fall Apart in Nigeria 2", "E. B. Tinz", "1958", "Historical Fiction" },
            { "Psyco The Rapist", "Oginidi Naeme", "1988", "Adventure" },
            { "E be Things ", "Unago C. Shege", "2006", "Historical Fiction" }
        };


        // Print the genre of the second book
        Console.WriteLine("The genre of the second book is: " + library[1, 3]);

        // Print the publishing date of the third book
        Console.WriteLine("The publishing date of the third book is: " + library[2, 2]);
    }
}