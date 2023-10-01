using System;
class Program
{
    static void Main()
    {
        //A
        //1. true
        //2.false
        //3. true
        //4.false
        //5. false
        //6. false
        //B
        //1.
        int x = 0;
        int y = 0;
        Console.WriteLine("choose tow numbers: ");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());      
        Console.WriteLine(x == y);
        //2.
        Console.WriteLine("choose number: ");
        x = int.Parse(Console.ReadLine());
        if (x >= 0)
        {
            Console.WriteLine("its positive number like your life:)");

        }
        else
        {
            Console.WriteLine("its negativ number like your life:(");
        }
        //3.
        Console.WriteLine("choose number: ");
        x = int.Parse(Console.ReadLine());
        if (x % 2==0)
        {
            Console.WriteLine("its even number ");
        }
        else
        {
            Console.WriteLine("its odd number ");
        }
        //4. כל 1 אינץ' שווה ל2.54 סנטמטר
        Console.WriteLine("right your height");
        float f = float.Parse(Console.ReadLine());
        Console.WriteLine(f/2.54);
        //5.
        Console.WriteLine("choos three numbers");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        if((x > y)&& (x> z))
        {
            Console.WriteLine(x + "is the biggest");
        }
        else if ((y > z)&& (y> x))
        {
            Console.WriteLine(y + "is the biggest");
        }
        else 
        {
            Console.WriteLine(z + "is the biggest");


        }
        //C
        //1.
        Console.WriteLine("insert your name");
        string name = Console.ReadLine();
        Console.WriteLine("insert your age");
        f = float.Parse(Console.ReadLine());
        Console.WriteLine("right your height");
        float f2 = float.Parse(Console.ReadLine());
        Console.WriteLine("right your job");
       string job = Console.ReadLine();
        Console.WriteLine("right your favotit color");
        string color = Console.ReadLine();
        Console.Write("your name is " + name);
        Console.Write(", your age is " + f);
        Console.Write(", your height is " + f2);
        Console.Write(", your job is " + job);
        Console.WriteLine(", your favorit color is " + color);
        //2.
        if (f < 45)
        {
            Console.WriteLine("you are young");
        }
        else
        {
            Console.WriteLine("you are old");
        }
        //3
        if ((f2 >=150)&&(f2 <= 160))
        {
            Console.WriteLine(" you are short");
        }
        else if ((f2 >=161)&&(f2 <= 180))
        {
            Console.WriteLine(" you are medium");
        }
        else if ((f2 >=181)&&(f2 <= 190))
        {
            Console.WriteLine(" you are tall");
        }
        else
        {
            Console.WriteLine(" freaky!");
        }


    }
}
