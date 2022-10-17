
Console.WriteLine("=======Задача 34==============");

/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int size1 = 4;
int minVolue1 = 100;
int maxVolue1 = 1000;

int[] firstTaskArray = GetArray(size1, minVolue1, maxVolue1);
Console.WriteLine($"Сгенерированный массив согласно условию => [{String.Join(",", firstTaskArray)}]");
Console.WriteLine($"Количество четных чисел в мссиве => {SolutionFirstTask(firstTaskArray)}");

Console.WriteLine("=======Задача 36==============");
/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int size2 = 4;
int minVolue2 = -10;
int maxVolue2 = 10;

int[] secondTaskArray = GetArray(size2, minVolue2, maxVolue2);
Console.WriteLine($"Сгенерированный массив согласно условию => [{String.Join(",", secondTaskArray)}]");
Console.WriteLine($"Сумма чисел с нечетными индексами в мссиве => {SolutionSecondTask(secondTaskArray)}");

Console.WriteLine("=======Задача 38==============");


int size3 = 4;
int minVolue3 = 0;
int maxVolue3 = 100;

int[] thirdTaskArray = GetArray(size3, minVolue3, maxVolue3);
Console.WriteLine($"Сгенерированный массив согласно условию => [{String.Join(",", thirdTaskArray)}]");
Console.WriteLine($"Разность максимального и минимального элементов в мссиве => {SolutionThirdTask(thirdTaskArray)}");

// =======МЕТОДЫ==============
int SolutionFirstTask(int[] simpleArray){
int count = 0;
    foreach (int i in simpleArray)
        {
            if (i % 2 == 0) count++;
        }
    return count;
}

int SolutionSecondTask(int[] simpleArray){
int sum = 0;
    for (int i = 0; i < simpleArray.Length; i++){
        if (i % 2 == 1) sum += simpleArray[i];
        }
    return sum;
}

int SolutionThirdTask(int[] simpleArray){
int minNum = simpleArray[0];
int maxNum = simpleArray[0];
//int maxNum = simpleArray[simpleArray.Length - 1];
for (int i = 0; i < simpleArray.Length; i++)
{
    if (simpleArray[i] < minNum) minNum = simpleArray[i];
    else if (simpleArray[i] > maxNum) maxNum = simpleArray[i];
}
int difference = maxNum - minNum;
return difference;
}

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
     result[i] = new Random().Next(minValue, maxValue + 1);   
    }
    return result;
}