// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int[10];
Random rand = new Random();
int ev = 0;

for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(100,1000);
}

Console.WriteLine (string.Join(", ", array));

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
    
    {
        ev = ev + 1;
    }

}

Console.WriteLine ($"Количество четных чисел в массиве = {ev}");