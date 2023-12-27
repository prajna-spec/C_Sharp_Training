using System.Runtime.InteropServices;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        string the_date="";
        DateTime parsedDate;
        DateTime Today=DateTime.Today;
        TimeSpan ts;
        Console.WriteLine(DateTime.TryParse(the_date,out parsedDate));
        do
        {
            Console.WriteLine("Enter the date or exit");
            the_date=Console.ReadLine();
            
            if(DateTime.TryParse(the_date,out parsedDate))
            {
                if(parsedDate<Today)
                {
                    ts=Today-parsedDate;
                    Console.WriteLine($"{Today} went by {ts.Days} ago ");
                }
                else if(parsedDate>Today)
                {
                    ts=parsedDate-Today;
                    Console.WriteLine($"{Today } will come in {ts.Days} ");
                }
                else if (parsedDate==Today)
                {
                    Console.WriteLine($"That date is today");
                }
            }
            else
            {
                Console.WriteLine("The date doesn't seem to be like a valid date");
            }


        } while(the_date!="exit");


     
}
}