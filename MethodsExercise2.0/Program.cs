namespace MethodsExercise2._0;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine(Add(2, 4));
        Console.WriteLine(Multiply(5, 3));
        Console.WriteLine(Subtract(8, 4));
        Console.WriteLine(Divide(10, 5));
    }
    
    static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    static int Multiply(int number3, int number4)
    {
        return number3 * number4;
    }

    static int Subtract(int number5, int number6)
    {
        return number5 - number6;
    }

    static int Divide(int number7, int number8)
    {
        return number7 / number8;
    }
    
}