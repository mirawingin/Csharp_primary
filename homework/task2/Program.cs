﻿
// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90].  массив [10 21 14 93 23] => 2
// int[] nambers = new int [10 21 14 93 23];
// int nambers > 10


/* Создаем одномерный массив
int[] numbers = { 10, 20, 14, 65, 73, 88, 25, 33, 16, 90, 23 };

// Переменная для хранения количества элементов в отрезке [20, 90]
int count = 0;

// Проходим по каждому элементу массива
foreach (int num in numbers)
{
    // Проверяем, лежит ли значение в отрезке [20, 90]
    if (num >= 20 && num <= 90)
    {
        // Если значение в отрезке, увеличиваем счетчик
        count++;
    }
}

// Выводим количество элементов, значения которых лежат в отрезке [20, 90]
Console.WriteLine("Количество элементов в отрезке [20, 90]: " +  (count - 1));

Задача 2: Задайте массив на 10 целых чисел.
Напишите программу, которая определяет
количество чётных чисел в массиве.*/
// Задаем массив из 10 целых чисел

/*int[] numbers = { 5, 10, 12, 7, 15, 20, 8, 3, 6, 11 };

// Переменная для хранения количества чётных чисел
int countEven = 0;

// Проходим по каждому элементу массива
foreach (int num in numbers)
{
    // Проверяем, является ли число чётным
    if (num % 2 == 0)
    {
        // Если число чётное, увеличиваем счетчик
        countEven++;
    }
}

// Выводим количество чётных чисел
Console.WriteLine("Количество чётных чисел в массиве: " + countEven);*/

// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив[1.22 4.5 3.33] => 3.28

/* Задаем массив вещественных чисел
double[] numbers = {2.2, 0.4, 9.11, 7.2, 78.98 };

// Инициализируем переменные для хранения минимального и максимального элементов
double min = numbers[0];
double max = numbers[0];

// Находим минимальный и максимальный элементы массива
foreach (double num in numbers)
{
    if (num < min)
    {
        min = num;
    }
    if (num > max)
    {
        max = num;
    }
}

// Находим разницу между максимальным и минимальным элементами
double difference = max - min;

// Выводим разницу
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);*/

// Дано натуральное число
// в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.

// Ввод натурального числа
int number = 98768;

/* Определяем количество цифр в числе
int numLength = (int)Math.Floor(Math.Log10(number)) + 1;

// Создаем массив для хранения цифр числа
int[] digits = new int[numLength];

// Заполняем массив цифрами числа с помощью цикла for
for (int i = 0; i < numLength; i++)
{
    digits[numLength - i - 1] = number % 10;
    number /= 10;
}

// Выводим массив цифр
Console.WriteLine("Массив цифр числа:");
foreach (int digit in digits)
{
    Console.Write(digit + " ");
}
*/
// Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)[1 3 5 6 7 8] => [8 7 6 5 3 1]

// Исходный массив
int[] array = { 1, 3, 5, 6, 7, 8 };

// Вывод исходного массива
Console.WriteLine("Исходный массив:");
PrintArray(array);

// Переворачиваем массив
ReverseArray(array);

// Вывод перевернутого массива
Console.WriteLine("Перевернутый массив:");
PrintArray(array);


// Метод для переворачивания массива
static void ReverseArray(int[] arr)
{
    int start = 0;
    int end = arr.Length - 1;

    while (start < end)
    {
        // Обмен значений между первым и последним элементами,
        // вторым и предпоследним и т.д.
        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        start++;
        end--;
    }
}

// Метод для вывода массива
static void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

