using System;

namespace CloudCommercePro.ConsoleApp.Messages
{
    // These would go in a resource file..
    internal static class ConsoleMessages
    {
        internal static void Greeting()
        {
            Console.WriteLine("");
            Console.WriteLine(ConsoleString.Greeting1);
            Console.WriteLine(ConsoleString.Greeting2);
            Console.WriteLine(ConsoleString.Greeting3);
            ConsoleMessages.ContinueMessage();           
        }

        internal static void ContinueMessage()
        {
            Console.WriteLine("");
            Console.WriteLine(ConsoleString.Continue);
            Console.ReadLine();
        }

        internal static void CaveatMessage()
        {
            Console.WriteLine(ConsoleString.Caveat1);
            Console.WriteLine(ConsoleString.Caveat2);
            Console.WriteLine(ConsoleString.Caveat3);
            Console.WriteLine(ConsoleString.Caveat4);
            ConsoleMessages.ContinueMessage();        
        }

        internal static void DevMessages()
        {
            Console.WriteLine(ConsoleString.DevNotes1);
            Console.WriteLine(ConsoleString.DevNotes2);
            Console.WriteLine(ConsoleString.DevNotes3);
            Console.WriteLine(ConsoleString.DevNotes4);
            Console.WriteLine(ConsoleString.DevNotes5);
            Console.WriteLine(ConsoleString.DevNotes6);
            ConsoleMessages.ContinueMessage();
        }

    }
}
