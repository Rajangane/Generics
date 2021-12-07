// See https://aka.ms/new-console-template for more information
//Console.WriteLine("**************** Welcome To Generics *********************");
using Generics;
Console.Write("Select Number:\n1)IntegerMax\n2)FloatMax\n3)StringMax\n4)SortMaxNum\n5)GenericMaxNum\n6)Refactor1\n7)Refactor2");
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
    case 6:
        Refactor1Generic findMax = new Refactor1Generic();
        findMax.findMaximum<int>(12, 13, 14);
        findMax.findMaximum<float>(2.2f, 6.6f, 7.4f);
        findMax.findMaximum<char>('M', 'S', 'D');
        break;
    case 7:
        Refactor2Generic<int> maxInt = new Generics.Refactor2Generic<int>(22, 33, 44);
        maxInt.findMaximum();
        Refactor2Generic<float> maxFloat = new Refactor2Generic<float>(8.8f, 7.0f, 9.96f);
        maxFloat.findMaximum();
        Refactor2Generic<string> maxStr = new Refactor2Generic<string>("i", "can", "do");
        maxStr.findMaximum();
        break;

    default:
        Console.WriteLine("Invalid Choice");
        break;


}