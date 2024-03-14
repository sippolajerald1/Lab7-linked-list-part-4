using System;
using System.Text;
using System.Collections.Generic;


namespace Lab7d2
{






    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the link list
            string[] games = { "Zelda", "Supermario", "Madden", "Finalfantasy", "Contra" };
            LinkedList<string> gameList = new LinkedList<string>(games);
            Console.WriteLine("Original game list");
            foreach (string game in gameList)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine();

            Console.WriteLine($"The first item in the list is:{gameList.First.Value}");
            Console.WriteLine();
            Console.WriteLine($"The last item in the list is: {gameList.Last.Value}");
            Console.WriteLine();


            gameList.AddLast("Rygar");
            gameList.AddLast("Metroid");

            // retreiving the node associated with Madden
            LinkedListNode<string> targetLocation = gameList.Find("Madden");
            // using the next property of LinkedListNode < T > to display the value of the next game
            Console.WriteLine("The current game in the list after Madden is {0}", targetLocation.Next.Value);
            Console.WriteLine();
            gameList.AddAfter(targetLocation, "Dragon Age");
            gameList.AddBefore(targetLocation, "Ghost Recon");
            Console.WriteLine("List with additions");
            foreach (string game in gameList)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine();
            gameList.RemoveFirst();
            gameList.RemoveLast();
            Console.WriteLine("List after deletions");
            foreach (string game in gameList)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine();

            // create an array with the same number of 
            // elements as the linked list.
            string[] gameArray = new string[gameList.Count];
            gameList.CopyTo(gameArray, 0);
            Console.WriteLine("Games list is now game array");
            foreach (string gs in gameArray)
            {
                Console.WriteLine(gs, 0);
            }

            // Relaese all node
            gameList.Clear();



        }
    }
}

