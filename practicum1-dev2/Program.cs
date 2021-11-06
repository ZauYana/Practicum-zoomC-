/*Задача

Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
Создать на его основе масив B, отбрасывая те, которые нарушают порядок

 - возрастания
 - элементы, больше 8
 - знакочередования*/


//Create array
int minValue = -20;
int maxValue = 18;
int[] array = new int[15];
int index = 0;
while (index < array.Length)
{
    array[index] = new Random().Next(minValue, maxValue);
    index++;

}

index = 0;
while (index < array.Length)
{
    Console.WriteLine(array[index]);
    index++;
}
Console.WriteLine("Создали массив");
Console.WriteLine();


//Create array 2 with growing up numbers

int FE = array[0];
Console.WriteLine(FE);
index = 1;
while (index < 15)
{
    if (array[index] > FE)
    {
        Console.WriteLine(array[index]);
        FE = array[index];
    }

    index++;
}

Console.WriteLine("Создали массив по возрастанию из массива Array");
Console.WriteLine();

//only elements bigger than 8

index = 0;
while (index<15)
{
    if (array[index]>8)
    {
        Console.WriteLine (array[index]);
    }
    index++;

}

Console.WriteLine("Создали выборку всех элементов больше числа 8");
Console.WriteLine();

