namespace homework5;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1 method
        Console.WriteLine("Please input two integers");
        int integer1 = GetInteger();
        int integer2 = GetInteger();
        int largest = FindLarger(integer1, integer2);
        Console.WriteLine("The largest number is: " + largest);

        // Call Q2 method
        Console.WriteLine("Please input four integers");
        int a = GetInteger();
        int b = GetInteger();
        int c = GetInteger();
        int d = GetInteger();
        int biggest = FindLargest(a, b, c, d);
        Console.WriteLine("The largest number is: " + biggest);

        //Call Q3 method
        createAccount();
    }

    // Q1 Method
    static int GetInteger()
    {
        string str_input = Console.ReadLine();
        int int_input = Convert.ToInt16(str_input);
        return int_input;
    }

    static int FindLarger(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    // Q2 Method
    static int FindLargest(int num1, int num2, int num3, int num4)
    {
        int max1 = FindLarger(num1, num2);
        int max2 = FindLarger(num3, num4);
        int max = FindLarger(max1, max2);
        return max;
    }

    //Q3 Method
    static bool checkAge(int birthYear){
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        return age >=18;
    }
    
    static void createAccount(){
        Console.WriteLine("input username: ");
        string user = Console.ReadLine();

        Console.WriteLine("input password: ");
        string password = Console.ReadLine();

        Console.WriteLine("input password again: ");
        string password_twice = Console.ReadLine();

        Console.WriteLine("input birthyear: ");
        int birth_year = Convert.ToInt16(Console.ReadLine());
        bool checkAgeResult=checkAge(birth_year);
        if (checkAgeResult)
        {
            if (password == password_twice){
                Console.WriteLine("Account is created successfully");
            }
            else{
                Console.WriteLine("wrong passoword");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account.");
        }
        }
    }