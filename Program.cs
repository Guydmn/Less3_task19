// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите пятизначное число :  ");
int N = Convert.ToInt32(Console.ReadLine());

int x1 = N%10;
int x2 = (N%100)/10;
int x3 = (N%1000)/100;
int x4 = (N%10000)/1000;
int x5 = (N%100000)/10000;    

if (N > 10000 && N < 100000 && x1==x5 && x2==x4 && x3==x3)

{
    Console.Write($"число явлется палиндромом {N}");
}

else
{
    Console.Write($"число {N} не явлется палиндромом ");
}



// int[] num1 = {x1, x2, x3, x4, x5};
// int[] num2 = {x5, x4, x3, x2, x1};
// if (num1 == num2)
// {
//     Console.Write($"число явлется палиндромом {N}");
// }

// Console.WriteLine(x1);
// Console.WriteLine(x2);
// Console.WriteLine(x3);
// Console.WriteLine(x4);
// Console.WriteLine(x5);

// int x1 = 0;
// int x2 = 0;
// int x3 = 0;
// int x4 = 0;
// int x5 = 0;

// int f1 = Convert.ToInt32(Console.ReadLine());
// int f2 = Convert.ToInt32(Console.ReadLine());
// int f3 = Convert.ToInt32(Console.ReadLine());
// int f4 = Convert.ToInt32(Console.ReadLine());
// int f5 = Convert.ToInt32(Console.ReadLine());

// int[] num = {f1, f2, f3, f4, f5};
// int i = num.Length;

// foreach (var n in num)
// {
//     Console.Write(n);
// }

// int N = Convert.ToInt32(Console.ReadLine());
// int N = Console.ReadLine(());
// int[] nums = Console.ReadLine(());
//int[] nums = new int[5];

//Console.WriteLine(num[i]);

//int first = int.Parse(N[0].ToString());





// int x1 = 0;
// int rev2 = 0;
// int rev1 = 0;
// int d = 10000;



// if (N > 10000 && N < 100000 )

//         while (d < 10)
//     {
//         x1 = N/d;
//         rev1 = N%10;
//         d = d / 10;

//     }

// Console.WriteLine(x);
// Console.WriteLine(y);

// if (N < 10000 || N > 100000)
// {
//     Console.Write($"Неверное число");
// }
// else
// {
//      Console.Write(N);
// }