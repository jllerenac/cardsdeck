using System;
using System.Collections.Generic;

// This little program simulates a deck of cards
// It has 2 main functions, first one is the shuffling
// which will reorder the array randomly and the other
// is to deliver cards to player, the base game for this
// is a game called "burro" which is better when played
// between four and eight players, each player receives 5 cards 
// from the shuffled deck of cards
class CardsDeck 
{
    // This array corresponds to the standards deck of cards
    // which as we know is divided in 52 cards and four groups
    // the groups being Clubs, Diamonds, Hearts and Spades
    // Each group consisting of 13 cards which is Ace, numbers 2-10, 
    // Jack, Queen and King
    // Values in array starts with capital group initial, followed by the number
    // or capital letter in case of Ace (A), Jack (J), Queen(Q) and King(K)
    // I am making an exception in order to keep the array values lenght the same
    // and for number 10, it will be renamed to Ten(T)
    // The constant array represents a newly bought deck of cards thats why I do it constant
    public readonly string []cardsDeck = { "C2","C3","C4","C5","C6","C7",
                                  "C8","C9","CT","CJ","CQ","CK","CA"
                                  ,"D2","D3","D4","D5","D6","D7",
                                  "D8","D9","DT","DJ","DQ","DK","DA"
                                  ,"H2","H3","H4","H5","H6","H7",
                                  "H8","H9","HT","HJ","HQ","HK","HA"
                                  ,"S2","S3","S4","S5","S6","S7",
                                  "S8","S9","ST","SJ","SQ","SK","SA" };
    // receives the value from console to be converted to int
    public static int numberOfPlayers;
    // this variable receives the number of players from console
    public static string inputNumberOfPlayers;
    // Next 2 vars used to validate number of records to be printed in a row in console
    public static string partialDeck = "";
    public static int partialCounter = 0;
// The shuffling could also be done using the constructor when instantiating because here is when 
// you actually start the game and the first step in this game is shuffling  
/*    public CardsDeck ()
    {
       Random shuffle = new Random();
        for (int i=0;i<52;i++)
        {           
            int randomValue = i + shuffle.Next(52 - i); 
            // This next 3 lines is used to swap the values
            string tempValue = cardsDeck[randomValue]; 
            cardsDeck[randomValue] = cardsDeck[i]; 
            cardsDeck[i] = tempValue; 
        }
    }
*/
    public void ShuffleDeck ()
    {
        Random shuffle = new Random();
        // This loop will perform the random sorting 
        for (int i=0;i<52;i++)
        {
            // What this next instruction does is the following:
            //  * if i = 0, random is from 0 to (52-0=52) and i index gets random value of 
            //    (ex i=0 + random 41 = 41) and random index (41 as ex) gets index i = 0 value 
            //    therefore index i = 0 will no longer receive another value
            //  * if i = 15, random is from 0 to (52-15=37) and i index gets random value of 
            //    (ex i=15 + random 31 = 46) and random index (46 as ex) gets index i = 15 value
            //    therefore index i = 15 and lesser will no longer receive another value
            //  * if i = 35, random is from 0 to (52-35=17) and i index gets random value of 
            //    (ex i=35 + random 8 = 43) and random index (43 as ex) gets index i = 35 value
            //    therefore index i = 35 and lesser will no longer receive another value
            //  * if i = 48, random is from 0 to (52-48=4) and i index gets random value of index 
            //    (ex i=48 + 3 = 51) and random index (51 as ex) gets index i = 48 value
            //    therefore index i = 48 and lesser will no longer receive another value
            int randomValue = i + shuffle.Next(52 - i); 
            // This next 3 lines is used to swap the values
            string tempValue = cardsDeck[randomValue]; 
            cardsDeck[randomValue] = cardsDeck[i]; 
            cardsDeck[i] = tempValue; 
        }

    }
    public void GiveCards ()
    {
        // Here an array of type list is created, so each
        // index of the array corresponding to a player will have
        // a list of the five cards delivered to the player
        List<String>[] totalPlayers = new List<String>[numberOfPlayers];
        // this list is to populate with the deck to remove after giving to players
        List<String> remainingDeck = new List<String>() ;
        for (int i=0;i<52;i++)
        {
            remainingDeck.Add(cardsDeck[i]);
        }  
        // first loop is for each player
        Console.WriteLine("Giving cards to each player\n..............."); 
        Console.WriteLine(".............................."); 
        for (int i=0;i<numberOfPlayers;i++)
        {
            // only used to display in console
            string receivedCards = "";
            totalPlayers[i] = new List<String>();
            // this loop is for giving 5 cards to each player from outer loop
            // each player receives all the five cards
            // instead of each player one card by one 
            for (int j=0;j<5;j++)
            {
                totalPlayers[i].Add(remainingDeck[0]); 
                receivedCards += remainingDeck[0] + " ";
           //   It is always index 0 because when removing index 1 becomes index 0
                remainingDeck.RemoveAt(0);
            }
            Console.WriteLine("Player "+ (i+1) + " has the cards: " + receivedCards + " ");
        }
        // Remaining deck is being showed
                Console.WriteLine("\nThe remaining cards to be picked during the game are:\n..............."); 
        ShowDeck(remainingDeck.Count);
    //    for (int i=0;i<remainingDeck.Count;i++)
      //      {
        //        Console.WriteLine(remainingDeck[i]);
          //  }
    }
    public void ShowDeck (int deckLength)
    {
                for (int i=0;i<deckLength;i++)
                {
                    partialCounter++;
                    partialDeck+= cardsDeck[i] + " ";
                    // This is only for printing 13 records in one row
                    if (partialCounter % 13 == 0)
                    {
                        Console.WriteLine(partialDeck);
                        partialDeck = "";
                        partialCounter = 0;
                    }
                }
                Console.WriteLine(partialDeck);  
    }
    static public void Main(String[] args) 
    { 
        Console.Write("Enter integer: ");
        inputNumberOfPlayers = Console.ReadLine();
        try 
        {
            numberOfPlayers = Convert.ToInt32(inputNumberOfPlayers);
            if (numberOfPlayers > 3 && numberOfPlayers < 9 )
            {
                Console.WriteLine("Shuffling Cards\n..............."); 
                Console.WriteLine("..............................\n"); 
                CardsDeck newGame = new CardsDeck();
                newGame.ShowDeck(newGame.cardsDeck.Length);
                newGame.ShuffleDeck();
                Console.WriteLine("Cards are shuffled\n..............."); 
                Console.WriteLine("..............................\n"); 
                newGame.ShowDeck(newGame.cardsDeck.Length);
                // Here each player will be given 5 cards in order from the shuffled deck
                newGame.GiveCards();
            }
            else
            {
                Console.WriteLine("Number of players must be between 4 and 8");
            }
        }
        catch (FormatException ) 
        {
            Console.WriteLine($"Please insert a number between 4 and 8");
            Console.WriteLine($"Exiting");
            Console.WriteLine($"...........");
            Console.WriteLine($".......................");
        }
    } 

}