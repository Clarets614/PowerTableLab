internal class Program
{
    private static void Main(string[] args)
    {
        bool runTable = true;
        while (runTable)
        {
            //Main code of the program here



            Console.WriteLine("Please Enter an Integer");

            int number = int.Parse(Console.ReadLine());



            Console.WriteLine("Number \tSquared\tCubed\t");
            Console.WriteLine("=======\t=======\t======");


            //for loop begins here to complete calculation for as many times as the number the user entered.


            for (int i = 1; i <= number; i++)
            {
                //get the calculations for the number squared and cubed
                double numberSq = Math.Pow(i, 2);
                double numberCu = Math.Pow(i, 3);
                Console.WriteLine($"{i}\t{numberSq}\t{numberCu}");

            }
            //end of what runs in the main program
            while (true)
            {
                Console.WriteLine("Would you like to continue? y/n");
                string choice = Console.ReadLine().ToLower();
                if (choice == "y")
                {
                    break;
                }
                else
                {
                    runTable = false;
                    break;
                }
                
            }

        }
    }
}