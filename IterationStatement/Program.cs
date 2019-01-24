using System;

namespace IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer between 1 and 100");

            try
            {

                string Input = Console.ReadLine();
                int valueofinput = int.Parse(Input);


                if ((valueofinput > 0) && (valueofinput < 10))
                    for (int i = 0; i < valueofinput; i++)
                    {
                        Console.WriteLine("You have entered" + valueofinput.ToString() + "This is the current integer value in the loop:" + i.ToString());
                    }
                {

                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
                {
                }
            }




            catch
            {
            }


        
        }
    }
} 
