// See https://aka.ms/new-console-template for more information
//Console.WriteLine("**************** Welcome To Generics *********************");
using Generics;
Console.Write("Select Number:\n1)IntegerMax\n2)FloatMax");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        int output = MaximumNum.MaximumIntNumber(10, 20, 30);
        Console.WriteLine("Maximum Number:" + output);
        break;
    case 2:
        float output1 = MaximumNum.MaxFloatNumber(1.1f, 2.2f, 3.3f);
        Console.WriteLine("Maximum Number:" + output1);
        break;

}