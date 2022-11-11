


// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
        
      string NumbersRec(int a,int b)
       {
            if(a <= b) return  NumbersRec((a + 1), b) + $" {a} ";
            else return String.Empty;
        }

       System.Console.WriteLine(NumbersRec(1,10));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int sum = 0;
                    Console.Write(RecursSum(a,b, sum));


  int RecursSum(int a, int b, int sum)
        {
            if (a <= b)
            {
                sum = sum + a;
                a++;
                return RecursSum(a, b, sum);
            }
            return sum;
        }


Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29


static uint A(uint n, uint m) // целые неотрицательные числа
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

System.Console.WriteLine(A(4,2));
