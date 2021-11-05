// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные
 

// задали массив

int GetRandom (int minValue, int maxValue)
{
    return new Random().Next (minValue,maxValue);
}

//заполняет массив
int [] A = new int [10];
int index = 0;
while (index<10)
{
    A[index] = GetRandom(10,100);
    index++;
}
index = 0;
// печатаем массив
while (index<10)
{
    Console.WriteLine(A[index]);
    index++;
}
Console.WriteLine();
// исключение элементов нарушения возрастания
index = 1;
int fe = A[0];
Console.WriteLine (fe);


while (index<10)
{
    if (A[index]>fe)
    {
        Console.WriteLine (A[index]);
        fe = A[index];
        
    }
    
    index++;

}
