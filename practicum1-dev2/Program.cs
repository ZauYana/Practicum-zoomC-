/*Задача

Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
Создать на его основе масив B, отбрасывая те, которые нарушают порядок

 - возрастания
 - элементы, больше 8
 - знакочередования*/

int minValue = 2;
int maxValue = 89;
int [] array = new int [15];
int index=0;
while (index<array.Length)
{
    array[index] = new Random ().Next(minValue,maxValue);
    index++;

}

index = 0;
while (index<array.Length)
{
    Console.WriteLine (array[index]);
    index++;
}
