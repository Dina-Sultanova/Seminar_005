// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int [] array = new int[12];
Random rand = new Random();

int sumP = 0; // сумма положительных элементов
int sumN = 0; // сумма отрицательных элементов

for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(-9,10);

if (array[i] > 0)
{
    sumP = sumP + array[i]; // sumP += array[i]
}
else 
{
    sumN = sumN + array[i]; // sumN += array[i]
}
}

Console.WriteLine (string.Join(", ", array));
Console.WriteLine ($"Сумма положительных чисел = {sumP}");
Console.WriteLine ($"Сумма отрицательных чисел = {sumN}");