// to exceed requirments I made it so that the program asks the user for the scripture to memorize before working on memorizing the scripture
using System;

class Program
{
    static void Main(string[] args)
    {
        string book;
        int chapter;
        int startVerse;
        int endVerse;
        string scriptureText;
        string quit;
        int hideNumber = 0;
        Reference memorizeReference;
        //Set up scripture to memorize
        Console.WriteLine("Welcome to the scripture memorizer!");
        Console.WriteLine("Please enter the book of the scripture you want to memorize");
        book = Console.ReadLine();
        Console.WriteLine("Please enter the Chapter");
        chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the start verse");
        startVerse = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the end verse (enter the start verse again if the same as start verse)");
        endVerse = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the text of your scripture to be memorized");
        scriptureText = Console.ReadLine();

        if (startVerse == endVerse)
        {
            memorizeReference = new Reference(book, chapter, startVerse);
        }
        else
        {
            memorizeReference = new Reference(book, chapter, startVerse, endVerse);
        }
        Scripture memorizeScripture = new Scripture(memorizeReference, scriptureText);
        int hideNumberMax = memorizeScripture.getLength();
        //set up process to memorize the scripture
        do
        {
            Console.Clear();
            Console.WriteLine(memorizeScripture.GetDisplayText());
            Console.WriteLine("Please press enter to continue or type 'quit' to finish");
            quit = Console.ReadLine();
            //Hide some words
            hideNumber++;
            memorizeScripture.HideWords(hideNumber);
        } while (quit != "quit" && memorizeScripture.getHiddenLength() < hideNumberMax);

    }
}