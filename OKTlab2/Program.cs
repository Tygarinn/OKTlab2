
//using System.IO;
//class HelloWorld
//{
//    static void Main()
//    {
//        double a, b, c, v;

//        Console.WriteLine("Введіть значення a: ");
//        a = Convert.ToDouble(Console.ReadLine()); //Тестове значення 5
//        Console.WriteLine("Введіть значення b: ");
//        b = Convert.ToDouble(Console.ReadLine());//Тестове значення 4
//        Console.WriteLine("Введіть значення c: ");
//        c = Convert.ToDouble(Console.ReadLine());//Тестове значення 3

//        v = a * b * c;
//        //V=60
//        Console.WriteLine("об'єм паралелепіпеда = " +v);
//    }
//}
//// Обчисліть об'єм паралелепіпеда, якщо відома довжина, ширина, висота. 

//class HelloWorld
//{
//    static void Main()
//    {
//        double x, y, z, u, num, denum;
//        x = -4.5;
//        y = 0.75 * Math.Pow(10, -4);
//        z=0.845*Math.Pow(10, 2);
//        num = (Math.Cbrt(8 + Math.Pow(Math.Abs(x - y), 2) + 1));
//        denum = (Math.Pow(x, 2) + Math.Pow(y, 2) + 2);
//        u = (num / denum - Math.Pow(Math.E, Math.Abs(x - y))) * Math.Pow(Math.Pow(Math.Tan(z), 2)+1, x);
//        Console.WriteLine($"результат: {u} для порівняння u=-55.6848");
//    }
//}

//class HelloWorld
//{
//    static void Main()
//    {
//        double x, y, b = 0;

//        double f(double x)
//        {
//            return Math.Pow(x, 2);
//        }

//        Console.WriteLine("Введіть значення х: ");
//        x = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Введіть значення y: ");
//        y = Convert.ToDouble(Console.ReadLine());


//        if (x == 0)
//        {
//            b = Math.Pow(Math.Pow(f(x), 2) + y, 3);
//        }
//        else if (y == 0)
//        {
//            b = 0;
//        }
//        else if (x / y > 0)
//        {
//            b = Math.Log10(f(x)) + Math.Pow(Math.Pow(f(x), 2) + y, 3);
//        }
//        else if (x / y < 0)
//        {
//            b = Math.Log10(Math.Abs(f(x) / y)) + Math.Pow(f(x) + 3, 3);
//        }
//        else
//        {
//            b = double.NaN;
//        }


//        Console.WriteLine($"результат: {b}");
//    }
//}


//class HelloWorld
//{
//    static void Main()
//    {
//        Console.Write("Введите число N: ");
//        int N = int.Parse(Console.ReadLine());

//        Console.Write("Введите число K: ");
//        int K = int.Parse(Console.ReadLine());

//        int quotient = 0;
//        int remainder = N;

//        while (remainder >= K)
//        {
//            remainder -= K;
//            quotient++;
//        }

//        Console.WriteLine($"Частка: {quotient}");
//        Console.WriteLine($"Залишок: {remainder}");
//    }
//}