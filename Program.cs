internal class Program
{
    private static void Main(string[] args)
    {
        void Zadacha_10()
        {
            Console.WriteLine("Task 10.");
            Console.WriteLine("Input three digit number");
            int number = Convert.ToInt32(Console.ReadLine());
            int answer = number / 10 % 10;
            Console.Write("Second digit of your number is " + answer);

        }
        //Zadacha_10();

        void Zadacha_13()
        {
            Console.WriteLine("Task 13.");
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number/10 < 10)
            {
                Console.WriteLine("There is no third digit in number"); 
            }
            if(10 <= number/10 & number/10 <= 99)
            {
                Console.WriteLine("The third number is " + number % 10); 
            }
            if(100 <= number/10 & number/10 <= 999)
            {
                Console.WriteLine("The third number is " + (number % 100)/10); 
            }
            if(1000 <= number/10 & number/10 <= 9999)
            {
                Console.WriteLine("The third number is " + (number % 1000)/100); 
            }
            if(10000 <= number/10 & number/10 <= 99999)
            {
                Console.WriteLine("The third number is " + (number % 10000)/1000); 
            }
            if(100000 <= number/10 & number/10 <= 999999)
            {
                Console.WriteLine("The third number is " + (number % 100000)/10000); 
            }
            if(1000000 <= number/10 & number/10 <= 9999999)
            {
                Console.WriteLine("The third number is " + (number % 1000000)/100000); 
            }
            if(10000000 <= number/10 & number/10 <= 99999999)
            {
                Console.WriteLine("The third number is " + (number % 10000000)/1000000); 
            }
        }
        //Zadacha_13();
        void Zadacha_15()
        {
            Console.WriteLine("Task 15");
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number == 6 || number == 7)
            {
                Console.WriteLine("Yes, it is weekend, go get drunk");
            }
            else if (number > 0 & number <= 5)
            {
                Console.WriteLine("No, sorry, it is not weekend");
            }
            else 
            {
                Console.WriteLine("Wrong number. There are 7 days in the week");
            }
        }
        //Zadacha_15();
    }
}