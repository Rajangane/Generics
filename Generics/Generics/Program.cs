﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("**************** Welcome To Generics *********************");
using Generics;
Console.Write("Select Number:\n1)IntegerMax\n2)FloatMax\n3)StringMax\n4)SortMaxNum\n5)GenericMaxNum");
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
    case 3:
        String output2 = MaximumNum.MaximumStringNumber("111", "222", "333");
        Console.WriteLine("Maximum Number:" + output2);
        break;
    case 4:
        int[] output3 = { 111, 222, 333, 444, 555 };
        SortMaxNum<int> checkInt1 = new SortMaxNum<int>(output3);
        int i = checkInt1.MaxValue(output3);
        Console.WriteLine(i);
        break;
    case 5:
        int[] intArray = { 10, 20, 30, 40, 50 };
        GenericMaxNum<int> checkInt2 = new GenericMaxNum<int>(intArray);
        checkInt2.PrintMaxValue();

        float[] floatArray = { 1.1f, 1.2f, 1.3f, 1.4f, 1.5f };
        GenericMaxNum<float> checkFloat2 = new GenericMaxNum<float>(floatArray);
        checkFloat2.PrintMaxValue();

        string[] stringArray = { "555", "666", "777", "888", "999" };
        GenericMaxNum<string> checkString2 = new GenericMaxNum<string>(stringArray);
        checkString2.PrintMaxValue();
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;


}