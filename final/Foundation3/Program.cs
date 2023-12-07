using System;
class Program
{
    static void Main()
    {
        
        Lecture lectureEvent = new Lecture("The Future of Artificial Intelligence", "An informative lecture", DateTime.Now.AddDays(7), "2:00 PM",
                                           new Address("123 Main St", "Cityville", "State", "12345"), "David Gage", 100);

        Reception receptionEvent = new Reception("Grand Reception", "A Wedding Celebration", DateTime.Now.AddDays(14), "6:00 PM",
                                                 new Address("456 Oak St", "Townsville", "State", "67890"), "rsvp@example.com");

        OutdoorGathering outdoorEvent = new OutdoorGathering("Nature Gathering", "A day in the park", DateTime.Now.AddDays(21), "11:00 AM",
                                                             new Address("789 Pine St", "Villageland", "State", "54321"), "Sunny skies expected");

        
        Console.WriteLine(lectureEvent.GenerateStandardDetails());
         Console.WriteLine();
        Console.WriteLine(lectureEvent.GenerateFullDetails());
         Console.WriteLine();
        Console.WriteLine(lectureEvent.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine(receptionEvent.GenerateStandardDetails());
         Console.WriteLine();
        Console.WriteLine(receptionEvent.GenerateFullDetails());
         Console.WriteLine();
        Console.WriteLine(receptionEvent.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine(outdoorEvent.GenerateStandardDetails());
         Console.WriteLine();
        Console.WriteLine(outdoorEvent.GenerateFullDetails());
         Console.WriteLine();
        Console.WriteLine(outdoorEvent.GenerateShortDescription());
    }
}
