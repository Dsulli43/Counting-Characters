using System;
 
namespace CountingChar
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("I'll count characters");
             string message = Console.ReadLine();
            
             message = message.Replace(" ", string.Empty);

            while (message.Length > 0 )
            {

             Console.Write(message [0] + " : "); 
             int CharC = 0;
             for (int charCount = 0; charCount < message.Length;
             charCount++)
             {
                if (message[0] == message[charCount])
                {
                    CharC++;

                }
             }

                Console.WriteLine(CharC);
                message = message.Replace(message[0].ToString(),string.Empty);

             
            }

             Console.ReadKey();

            

        }
    }
}
