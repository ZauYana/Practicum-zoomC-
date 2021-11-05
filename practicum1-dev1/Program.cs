// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные


// задали массив

int GetRandom(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}

//заполняет массив
int[] A = new int[10];
int index = 0;
while (index < 10)
{
    A[index] = GetRandom(10, 100);
    index++;
}
index = 0;
// печатаем массив
while (index < 10)
{
    Console.WriteLine(A[index]);
    index++;
}
Console.WriteLine("Напечатали случайный массив");
Console.WriteLine();

// исключение элементов нарушения возрастания
index = 1;
int fe = A[0];
Console.WriteLine(fe);
Console.WriteLine("напечатали первый элемент массива для сл массива");
Console.WriteLine();


while (index < 10)
{
    if (A[index] > fe)
    {
        Console.WriteLine(A[index]);
        fe = A[index];

    }

    index++;

}
Console.WriteLine("новый массив, содержит значения по возрастанию");
Console.WriteLine();


// Задача ---больше среднего арифметического элементов A
// создать массив В
// определить элементы А
// определить среднеарифметическое из элементов А
// найти числа из массива А, которые больше вышенайденного значения и будут перемещены в массив В

//создать массив В

//создала еще раз сама массив и вывела его на печать (практика)
int[] A1 = new int[3];
int ind = 0;
while (ind < 3)
{
    A1[ind] = GetRandom(10, 56);
    ind++;

}
ind = 0;
while (ind < 3)
{
    Console.WriteLine(A1[ind]);
    ind++;
}
Console.WriteLine("создала просто так новый массив А1");
Console.WriteLine();

//выбираем элементы из ранее определенного массива А

int[] A2 = { A[3], A[6], A[9] };
int ind1 = 0;
while (ind1 < 3)
{
    Console.WriteLine(A2[ind1]);
    ind1++;
}
Console.WriteLine("выбрала три элемента из массива А");
Console.WriteLine();

// считаем среднеарифмитическое из найденного массива А2


int y = ((A2[0] + A2[1] + A2[2]) / A2.Length);
Console.WriteLine(y);

Console.WriteLine("посчитали среднеарифметическое");
Console.WriteLine();

// найти числа в массиве А больше среднеарефмитического значения и перенести в массив В

index = 0;
while (index < 10)
{
    if (A[index] > y)
    {
        Console.WriteLine(A[index]);

    }
    index++;
}

Console.WriteLine("Выбрали все элементы из массива А,которые больше среднеарифметического значения");
Console.WriteLine("Я смогла!");
