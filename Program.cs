// Adam Ishak
namespace GA_Boolean_AdamIshak
{
    internal class Program
    {
        // Entry point of our C# program
        static void Main(string[] args)
        {
            Console.WriteLine("true");

            bool isAdult = true;

            Console.WriteLine(isAdult);

            if (isAdult)
             Console.WriteLine("You are an adult.");

            isAdult = false;
            Console.WriteLine(isAdult);

            bool hasLicense = true;
            if (isAdult && hasLicense)
                Console.WriteLine("You are an adult and have a license.");
            
            else 
            Console.WriteLine("Condition not met.");


        }
       
       
        
        

            
        

        

    }
}
