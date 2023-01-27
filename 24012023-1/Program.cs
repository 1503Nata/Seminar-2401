Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵), 2, 4 -> 16");
Console.WriteLine(" ");
int A, B;
Console.Write("Введите целое число: ");
while (!Int32.TryParse(Console.ReadLine(), out A))
    Console.Write("Неправильный ввод. Введите целое число: ");
Console.Write("Введите целое число: ");
while (!Int32.TryParse(Console.ReadLine(), out B))
    Console.Write("Неправильный ввод. Введите целое число: ");

int Exponent(int A, int B)
{
int result = 1;
for (int i=1; i<=Math.Abs(B); i++ )
  { 
    result = result * A;
  }
    return result;
}

int Exp = Exponent(A, B);

Console.WriteLine($"Результатом возведения числа {A} в натуральную степень {Math.Abs(B)} будет число - {Exp}.");  

