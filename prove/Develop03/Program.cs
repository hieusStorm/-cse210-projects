using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        int hideNumber = 1;
        //Set up scripture to memorize
        Reference psalmsReference = new Reference("psalms", 23, 4);
        Scripture memorizeScripture = new Scripture(psalmsReference, "Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me.");

        //set up process to memorize the scripture
        do
        {
            Console.Clear();
            Console.WriteLine(memorizeScripture.GetDisplayText());
            Console.WriteLine("Please press enter to continue or type 'quit' to finish");
            response = Console.ReadLine();
            //Hide some words
            memorizeScripture.HideWords(hideNumber);
            hideNumber++;
        } while (response != "quit" || hideNumber > memorizeScripture.getLength());

    }
}