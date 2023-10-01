internal class Program
{
    public static int Menu(params string[] strings)
    {
        int index = 0;


        dynamic choice;
        while (true)
        {
            Console.Clear();
            for (int i = 0; i < strings.Length; i++)
            {
                if (index == i)
                    Console.Write("->");
                Console.WriteLine(strings[i]);
            }
            choice = Console.ReadKey();
            if (index == 0 && choice.Key == ConsoleKey.UpArrow)
            {
                index = strings.Length - 1;
            }
            else if (choice.Key == ConsoleKey.UpArrow)
            {
                index--;
            }
            else if (index == strings.Length - 1 && choice.Key == ConsoleKey.DownArrow)
            {
                index = 0;
            }
            else if (choice.Key == ConsoleKey.DownArrow)
            {
                index++;
            }
            else if (choice.Key == ConsoleKey.Enter) return index;
        }

    }

    public static double Multiply(double num_1,double num_2)=>num_1*num_2;
    public static double Subtraction(double num_1,double num_2)=> num_1-num_2;
    public static double Addition(double num_1,double num_2)=> num_1 + num_2;
    public static double Division(double num_1, double num_2)
    {
        if (num_2 == 0)
        {
            Console.WriteLine("Cannot divide to zero.");
            return 0;
        }
        return num_1 / num_2;
    }


    private static void Main(string[] args)
    {
        int index= Menu("Addition", "Subtraction", "Multiply", "Divide");
        Console.Clear();
        Console.Write("Enter first number: ");
        double num_1=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num_2 = Convert.ToDouble(Console.ReadLine());
        double answer = 0;
        if (index==0)
        {
            answer=Addition(num_1,num_2);
            Console.WriteLine(num_1+" + "+num_2+" = "+answer);
        }
        else if(index==1)
        {
            answer=Subtraction(num_1,num_2);
            Console.WriteLine(num_1+" - "+num_2+" = "+answer);
        }
        else if(index==2)
        {
            answer=Multiply(num_1,num_2);
            Console.WriteLine(num_1+" * "+num_2+" = "+answer);
        }
        else if(index==3)
        {
            answer=Division(num_1 ,num_2);
            Console.WriteLine(num_1+" / "+num_2+" = "+answer);
        }
    }

}