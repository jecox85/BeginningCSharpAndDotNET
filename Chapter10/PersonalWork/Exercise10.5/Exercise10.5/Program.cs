//This program is to solve exercise 10.5 on page 263 of the text, but I modified it to keep looping until I get a flush.
using System;
using Ch10CardLib;

namespace Exercise10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            bool flush = false;
            while (!flush)
            {
                myDeck.Shuffle();
                for (int i = 0; i < 50; i += 5)
                {
                    Card[] tempCards =
                    {
                        myDeck.GetCard(i),
                        myDeck.GetCard(i + 1),
                        myDeck.GetCard(i + 2),
                        myDeck.GetCard(i + 3),
                        myDeck.GetCard(i + 4),
                    };
                    if (tempCards[0].suit == tempCards[1].suit &&
                        tempCards[0].suit == tempCards[2].suit &&
                        tempCards[0].suit == tempCards[3].suit &&
                        tempCards[0].suit == tempCards[4].suit)
                    {
                        flush = true;
                        Console.WriteLine("Flush!");
                        Console.WriteLine(tempCards[0].ToString() + ", " + tempCards[1].ToString() + ", " + tempCards[2].ToString()
                            + ", " + tempCards[3].ToString() + ", " + tempCards[4].ToString());
                        break;
                    }
                    else if(i == 45)
                    {
                        Console.WriteLine("No flush.");
                    }
                }                
            }

        }
    }
}
