/*Cформировать случайным образом целочисленный массив a из натуральных двузначных чисел. Создать на его основе масив b, отбрасывая те, которые
*чётные* (оставляем те что нечётные)
*нарушают порядок возрастания(должны остаться числа в порядке возрастания)    
*больше среднего арифметического элементов a(оставляем те что меньше)*/


int[] a = new int[10]; //определяем массив А
int i = 0;
int[] b = new int[a.Length];//определяем массив В
int indexB = 0;
Random r = new Random();
Console.Write("Массив А = ");
for (i = 0; i < a.Length; i++)
{
    a[i] = r.Next(1, 100);

    Console.Write(" " + a[i]);//заполняем массив А
}

for (i = 0; i < a.Length; i++)
{
    if (a[i] % 2 != 0)
    {
        b[indexB++] = a[i];//наполняем массив В нечётными числами массива А
    }
}
Console.WriteLine();
Console.Write("Массив В = ");

for (i = 0; i < indexB; i++)
{
    Console.Write(" " + b[i]);//выводим массив В
}

int Current = b[0];

i = 1;
Console.WriteLine();
Console.Write("Числа в порядке возрастания = ");
Console.Write(Current);
while (i <= 9)
{
    if (b[i] > Current)
    {
        Console.Write(" " + b[i]);//выводим числа из массива В в порядке возрастания
        Current = b[i];
    }
    ++i;

}

Console.WriteLine();
Console.Write("Среднее арифметическое = ");
double sred = 0;
for (i = 0; i < a.Length; i++)
{
    sred = sred + a[i];

}
sred = sred / 10;//определяем среднее арифметическое

Console.Write(sred);

Console.WriteLine();
Console.Write("Отсеиваем элементы меньше среднего арифметического, и получаем массив В =   ");
i = 0;

    if (sred > b[i])
    { 
        Console.Write(" " + b[i]); ++i;
    }
    else
    {
        Console.Write("Нет подходящих элементов");
    } 

