Console.WriteLine();
Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
Console.WriteLine();
int[] massiv = new int[8];
void FillArray(int[] massiv)
    {
    Console.WriteLine($"Формируем массив из {massiv.Length} элементов");
    for (int i = 0; i < massiv.Length; i++) 
    {
    massiv[i] = new Random().Next(-11,20);
    }
    return;
    }
FillArray(massiv);

void Print(int[] massiv)
    {
    int i = 0;
    Console.Write($"Итоговый массив: [ {massiv[i]}");
    for (i = 1; i < massiv.Length; i++)
    {
    Console.Write($", {massiv[i]}");
    }
    Console.Write(" ]");
    return;
    }

Print(massiv);

