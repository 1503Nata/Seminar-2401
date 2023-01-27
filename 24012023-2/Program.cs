Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
int number;
Console.Write("Введите целое число: ");
while (!Int32.TryParse(Console.ReadLine(), out number))
    Console.Write("Неправильный ввод. Введите целое число: ");

int Summa(int numder)
{
int sum=0;
int num = number;
while(num!=0) 
    {
        sum=sum+num%10;
        num=num/10;    
    }
return sum;
}

int summa = Summa (number);
 Console.WriteLine($"Cумма цифр в числе {number}  равна {summa}.");