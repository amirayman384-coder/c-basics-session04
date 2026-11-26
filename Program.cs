
//using System;

//class Program
//{
//    static void Main()
//    {
//  // Question 1:
// // Create a one-dimensional array double[] prices
// // with the values 25.5, 40.0, 33.75.
//  // Print the second price (index 1).

//  // double[] prices = { 25.5, 40.0, 33.75 };
//       // Console.WriteLine(prices[1]);


//  // Question 2:
//  // Create a 2x2 multidimensional array int[,] shelfCopies
//  // where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.
//        // Print the number of copies on shelf 1, slot 0.

//        int[,] shelfCopies =
//        {
//            { 3, 5 },
//            { 1, 4 }
//        };

//        Console.WriteLine(shelfCopies[1, 0]);


//        // Question 3:
//        // Write a method called PrintWelcomeMessage that takes
//        // no parameters and prints "Welcome to the Library!".
//        // Call it from Main.

//        PrintWelcomeMessage();


//        // Question 4:
//        // Write a method PrintBookTitle(string title) that prints
//        // "Book title: " + title. Call it with "Clean Code".

//        PrintBookTitle("Clean Code");


//        // Question 5:
//        // Write a method AddBonusPages(int pages) that adds 50
//        // to pages. Call it with a variable int pages = 400;
//        // and print pages afterward. What do you expect to see,
//        // and why?

//        int pages = 400;
//        AddBonusPages(pages);
//        Console.WriteLine(pages);


//        // Question 6:
//        // Write a method ApplyDiscount(double[] prices) that
//        // subtracts 5 from prices[0]. Call it with
//        // double[] prices = { 25.5, 40.0 };
//        // and print prices[0] afterward. What do you expect
//        // to see, and why?

//        double[] discountPrices = { 25.5, 40.0 };
//        ApplyDiscount(discountPrices);
//        Console.WriteLine(discountPrices[0]);


//        // Question 7:
//        // Rewrite the method from question 5 as
//        // AddBonusPagesByRef(ref int pages) using ref.
//        // Call it and print pages afterward.
//        // How is the result different from question 5?

//        int pagesByRef = 400;
//        AddBonusPagesByRef(ref pagesByRef);
//        Console.WriteLine(pagesByRef);


//        // Question 8:
//        // Write a method ReplaceArray(ref double[] prices)
//        // that replaces prices entirely with a new array
//        // { 10.0, 12.5, 15.0 }.
//        // Call it with your prices array and print
//        // prices.Length afterward.

//        ReplaceArray(ref prices);
//        Console.WriteLine(prices.Length);


//        // Question 12:
//        // Write a method PrintAllTitles(params string[] titles)
//        // that prints each title on its own line.
//        // Call it with three book titles.

//        PrintAllTitles(
//            "Clean Code",
//            "C# Programming",
//            "The Pragmatic Programmer"
//        );
//    }


//    // Answer 3
//    static void PrintWelcomeMessage()
//    {
//        Console.WriteLine("Welcome to the Library!");
//    }


//    // Answer 4
//    static void PrintBookTitle(string title)
//    {
//        Console.WriteLine("Book title: " + title);
//    }


//    // Answer 5
//    static void AddBonusPages(int pages)
//    {
//        pages += 50;
//    }


//    // Answer 6
//    static void ApplyDiscount(double[] prices)
//    {
//        prices[0] -= 5;
//    }


//    // Answer 7
//    static void AddBonusPagesByRef(ref int pages)
//    {
//        pages += 50;
//    }


//    // Answer 8
//    static void ReplaceArray(ref double[] prices)
//    {
//        prices = new double[] { 10.0, 12.5, 15.0 };
//    }


//    // Answer 12
//    static void PrintAllTitles(params string[] titles)
//    {
//        foreach (string title in titles)
//        {
//            Console.WriteLine(title);
//        }
//    }
//}
