using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine($"Please Your preference from the list of scriptures below:");
        Console.Write("1. 1 Nephi 1:1  \n2. Moroni 10:3-5\nEnter your choice here: ");
        string input = Console.ReadLine();
        int choice = int.Parse(input);

        if (choice == 1)
        {
            Reference f1 = new Reference("1Nephi", 1 ,1);
            string scriptureText = ("I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days..");

            Scripture scripture = new Scripture(f1, scriptureText);
            // Console.WriteLine( scripture.GetDisplayText());

            string response;
            do
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("\nPress 'ENTER' to hide words or type 'QUIT' to quit: ");
                response = Console.ReadLine();

                if (!(scripture.IsCompletelyHidden()))
                {
                    scripture.HideRandomWords(2);
                    Console.WriteLine("\n" + scripture.GetDisplayText());
                    Console.Clear();
                }
                else if (scripture.IsCompletelyHidden())
                {
                    break;
                }
            } while (!(response == "quit" || response == "QUIT"));
        }

        else if (choice == 2)
        {
            Reference f2 = new Reference("Moroni", 3, 4, 5);
            string scriptureText = ("3 Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts"+
                                     "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost"+
                                     "And by the power of the Holy Ghost ye may know the truth of all things.");
            Scripture scripture = new Scripture(f2, scriptureText);
            // Console.WriteLine( scripture.GetDisplayText());

            string response;
            do
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("\nPress 'ENTER' to hide words or type 'QUIT' to quit: ");
                response = Console.ReadLine();

                if (!(scripture.IsCompletelyHidden()))
                {
                    scripture.HideRandomWords(2); 
                    Console.WriteLine("\n" + scripture.GetDisplayText());
                    Console.Clear();
                }
                else if (scripture.IsCompletelyHidden())
                {
                    break;
                }
            } while (!(response == "quit"  || response == "QUIT"));
        }

        else{
            Console.WriteLine("Please restart and choose one of the options.");
        }
    }
}
        