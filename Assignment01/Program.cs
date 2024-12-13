namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Q1
            //1. Write a program that allows the user to enter a number then print it.

            int Number = 6;
            Console.WriteLine(Number);

            #endregion
            #region Q2

            //2.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            int Value1 = 5;
            int Value2;
            Value2 = Value1; //5

            Value1 = 10;

            Console.WriteLine(Value1); // 10
            Console.WriteLine(Value2); // 5

            #endregion


            #region Q3

            //3.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            object obj1 = new object();
            obj1 = 2;

            object obj2 = new object();
            obj2 = obj1; //2


            obj1 = 4;
            Console.WriteLine(obj1); // 4

            Console.WriteLine(obj2); // 2

            #endregion
        }
    }
}
