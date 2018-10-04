using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{   
    class Program
    {
        static void Main(string[] args)
        {
            //1)Типы
            /*
            //a
            bool d = true;
            double c = .05;
            int b = 4;
            string a = "Hello";
            Console.WriteLine(a + " " + b + " " + c + " " + d);
            Console.ReadLine();

            //b.1
            int i = 5;           
            long i1 = i;

            int i2 = 6;
            float i3 = i2;

            int i4 = 7;
            double i5 = i4;

            float i6 = 2.07F;
            double i7 = i6;

            byte p = 55;
            int p1 = p;

            //b.2
            double a2 = 2.37;
            int a1 = (int)a2;;

            byte a3 = 123;
            char a4 = (char)a3;

            int a5 = 15;
            char a6 = (char)a5;

            int a7 = 16;
            byte a8 = (byte)a7;

            int a9 = 19;
            short a10 = (short)a9;


            //c
            int j = 123;
            object o = j;
            o = 123;
            j = (int)o;

            byte j1 = 12;
            object o1 = j1;
            o1 = 12;
            j1 = (byte)o1;

            double j3 = 8.8;
            object o2 = j3;
            o2 = 8.8;
            j3 = (double)o2;

            bool j4 = true;
            object o3 = j4;
            o3 = true;
            j4 = (bool)o3;


            //d
            var g2 = 5;
            //var g1 = (g1 = 5); //Ошибка, так как переменные, объявленные с помощью var, не могут использоваться в выражении инициализации
            int g3 = (g3 = 5);
            


            //e
            int? с1 = null;
            double? с2 = null;
            bool? c3 = null; 
            */

            //2)Строки
            /*
            //a
            string a = "Это";
            string a1 = "Совсем";
            if (a == a1)
            {
                Console.WriteLine(a + " = " + a1);
            }
            else Console.WriteLine(a + " !== " + a1);

            //b
            string b = "bb";
            string b1 = "b1b1";
            string b2 = "b2b2";
            //Сцепление
            string b3 = b + b1 + b2;
            //Копирование
            string b4 = b3.Substring(0, 1);
            Console.WriteLine(b4);
            //Выделение подстроки
            string[] b5 = b3.Split(new char[] { 'b' }); // или string b4 = b3.Substring(0, 3);
            Console.WriteLine(b5);
            //Разделение строки на слова
            string b6 = "bb b1b1 b2b2";
            string[] b7 = b6.Split(new char[] { ' ' });
            Console.WriteLine(b7[0]);
            Console.WriteLine(b7[1]);
            //встака подстроки в заданную позицию
            string b8 = b3.Insert(1, b2);
            Console.WriteLine(b8);
            //удаление заданной подстроки
            string b9 = b8.Remove(1, 4);
            Console.WriteLine(b9);

            //c
            string c = "";
            string c1 = null;
            Console.WriteLine(c + c1 + 'a');//Выше описаны действия, которые можно делать с этими строками

            //d
            StringBuilder sb = new StringBuilder("Привет мир");
            Console.WriteLine("Длина строки: {0}", sb.Length);
            Console.WriteLine("Емкость строки: {0}", sb.Capacity);
            sb.Insert(0, '1');
            sb.Insert(sb.Length, '9');
            Console.WriteLine(sb);

            */
            /*
            //3)
            //a
            int[,] myArr = new int[4, 5];
            Random ran = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            //б
            string[] b = {"one", "two", "three"};
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i] + " ");
            }
            Console.WriteLine(b.Length);
            Console.WriteLine("Какой элемент по счету вы бы хотели поменять?");
            string x0 = Console.ReadLine();
            int x = Convert.ToInt32(x0);
            Console.WriteLine("Введите новое значение элемента");
            var x1 = Console.ReadLine();
            string x2 = b[x];
            b[x] = x1;
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i] + " ");
            }
            //c

    int[][] jagged = new int[3][]; 
    jagged[0] = new int[4]; 
    jagged[1] = new int[3]; 
    jagged[2] = new int[5];
    for(var i=0; i < 4; i++)
      jagged[0][i] = Convert.ToInt32(Console.ReadLine());
    for(var i=0; i < 3; i++)
        jagged[1][i] = Convert.ToInt32(Console.ReadLine());
    for(var i=0; i < 5; i++)
        jagged[2][i] = Convert.ToInt32(Console.ReadLine());
    for(var i=0; i < 4; i++)
      Console.Write(jagged[0] [i] + " ") ;
    Console.WriteLine();
    for (var i=0; i < 3; i++)
      Console.Write(jagged[1][i] + " ");
    Console.WriteLine() ;
    for(var i=0; i < 5; i++)
      Console.Write(jagged[2] [i] + " ") ;
    Console.WriteLine() ;                        

            //d
    var array = new object[0];
    var str = "";

            */

            //4
          /*  
            //a, b
           
          var tuple = (chislo:23, stroka:"Bob", simvol:'A', stroka1:"bob1", chislo1:189);
             //c
            Console.WriteLine(tuple.chislo + " " + tuple.stroka + " " + tuple.simvol + " " + tuple.stroka1 + " " + tuple.chislo1);
            Console.WriteLine("Вывести 1, 3 или 4 элемент?");
            int a1 = Convert.ToInt32(Console.ReadLine());
            if (a1 == 1) 
            {
                Console.WriteLine(tuple.chislo);
            }
            else if (a1 == 3) 
            {
                Console.WriteLine(tuple.simvol);
            }
            else if (a1 == 4)
            {
                Console.WriteLine(tuple.stroka1);
            }

			//d
			var d = tuple.chislo;
			var d1 = tuple.stroka;
			var d2 = tuple.simvol;
			var d3 = tuple.stroka1;
			var d4 = tuple.chislo1;
			if (d == d4)
			{
				Console.WriteLine(d + " = " + d4);
			}
			else if (d < d4)
			{
				Console.WriteLine(d + " < " + d4);
			}
			else
			{
				Console.WriteLine(d + " > " + d4);
			}
           
           
            
           
           
            

            Console.WriteLine();
		*/

    
    //5
            /*
        Func<int[], string, Tuple<int, int, int, char>> fun = (arr, str) => arr.Aggregate(Tuple.Create(Int32.MinValue, Int32.MaxValue, 0, str[0]), (y, x) => Tuple.Create(Math.Max(y.Item1, x), Math.Min(y.Item2, x), y.Item3 + x, y.Item4));
        Console.WriteLine(fun(new int[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, 0 }, "Abracadabra"));
            */
    
            Console.ReadLine();

    
    
        }
    }
}
