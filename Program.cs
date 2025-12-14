namespace AdvancedCsharp;

// Delegate : a reference to a function, the delegate must have the same the signature as the methods 
internal class Program
{
    static void Main(string[] args)
    {
        // main to consume the Delegate 

        // Old 
        Calculate(5, 7, delegate (int num1, int num2) { return num1 * num2; });

        // Lampda expression -> preferred and 
        Calculate(5, 7, (num1, num2) => num1 * num2);


    }

    // consumer for the CalculateDelegate 
    static void Calculate(int num1, int num2, CalculateDelegate dlg)
    {
        // calculate value 
        int res = dlg(num1, num2);
        // print result 
        System.Console.WriteLine(res);
    }

    // Delegate 
    delegate int CalculateDelegate(int num1, int num2);


    // methods to point at using the CalculateDelegate
    static int Add(int num1, int num2) => num1 + num2;

    static int Subtract(int num1, int num2) => num1 - num2;

    static int Multiply(int num1, int num2) => num1 * num2;

    static int Divide(int num1, int num2) => num1 / num2;

}

