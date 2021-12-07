// See https://aka.ms/new-console-template for more information
//Console.WriteLine("**************** Welcome To Generics *********************");
using Generics;
Console.Write("Select Number:\n1)IntegerMax\n");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        int output = MaximumNum.MaximumIntNumber(10, 20, 30);
        Console.WriteLine("Maximum Number:" + output);
        break;
}