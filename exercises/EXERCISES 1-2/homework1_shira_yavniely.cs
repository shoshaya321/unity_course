
namespace Homework1 
{
    class Homework1 
    {
        static void Main(string[] args)
        {
            // variabels:
            //1.
            int x = 1;
            //2.
            int y;
            //3.
            float f1;
            float f2;
            //4
            string s;
            //5
            bool b1 = true;
            bool b2 = false;
            //6
            f1 = 2.5f;
            f2 = 3.5f;
            //7
            s = "shira";
            //8
            y = x;
           
            
            //operators:
            //1.
            bool b3, b4;
            float f3, f4;
            int i3, i4;
            string s3, s4;
            //2.
            b3 = true;
            b4 = false;
            f3 = f1;
            f4 = f2;
            i3 = 3;
            i4 = 4;
            s3 = "the queen ";
            s4 = "shira";
            Console.WriteLine(b3==b4);
            Console.WriteLine(f3/f4);
            Console.WriteLine(i3-i4);
            Console.WriteLine(s3+s4);
            
            
            //more opraters
            //1.
            Console.WriteLine("hello");
            string name = "shira";
            Console.WriteLine(name);
            //2.
            int i = 2;
            int j = 3;  
            Console.WriteLine(i+j);
            //3.
            Console.WriteLine(j/(float)i);
            //4.
            Console.WriteLine((1 + 2 + 3 + 4 )/ (float)4);
            //5.
            for (int k = 0; k < 3; k++)
            {
                i++;
                Console.WriteLine(i);
            }
            //6.
            for (int k = 0; k < 3; k++)
            {
                i--;
                Console.WriteLine(i);
            }

        }
    }
}
