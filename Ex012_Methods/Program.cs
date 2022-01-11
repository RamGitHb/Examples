﻿// Если запустился бесконечный цикл жми "Ctrl + C" в консоли для остановки
Console.Clear();

// Вид 1--------------------------------------------------------------------------------------------------------------------------------------------------------
// Эти методы ничего не принимают и не возвращают

// void Method1()
// {
//     Console.WriteLine("Ram"); // Указываем имя автора программы
// }
// Method1(); // вызов этого метода

// Вид 2--------------------------------------------------------------------------------------------------------------------------------------------------------
// Эти методы ничего не возвращают, но могут принимать аргументы

// void Method2(string msg) // Выведет сообщение "Текст" в консоль
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст");

// void Method21(string msg, int count) // Выведет сообщение "Текст" в консоль 4 раза
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 4); // Не явное присвоение значений(Текст) аргументам(msg)
// Method21(msg: "Текст", count: 4); //Явное присвоение значений аргументам
//Method21(count: 4, msg: "Новый текст"); // Если использовать именованные аргументы(msg), можно писать их не по порядку

// Вид 3--------------------------------------------------------------------------------------------------------------------------------------------------------
// Эти методы что-то возвращают, но не принимают аргументы

// int Method3() // Выведет текущий год
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year); 

// Вид 4--------------------------------------------------------------------------------------------------------------------------------------------------------
// Эти методы принимают и возвращают

// string Method4(int count, string c) // Будет возвращать строку (С) - (Count) раз, друг за другом
// {
//     int i = 0;
//     string result = ""; // Выдаст в рузультате пустую строку. Лучше вместо ("") записать так: (String.Empty)

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, " asda "); // Выдаст "asda" 10 раз в строку
// Console.WriteLine(res);

// Добавляем цикл (for) Он собирает все в одном месте
// string Method4(int count, string c) 
// {
//     string result = ""; // Выдаст в рузультате пустую строку. Лучше вместо ("") записать так: (String.Empty)
//     for(int i = 0; i < count; i++)
//     {
//         result = result + c;
//     }
//     return result;
// }
// string res = Method4(10, " asda "); // Выдаст "asda" 10 раз в строку
// Console.WriteLine(res);

//Вывод цикла в цикле
// Выведем таблицу умножения
// for (int i = 2; i <= 10; i++) // (<=) - Значит "меньше или равен" 
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine(); // Переход на новую строку
// }

// Работа с текстом--------------------------------------------------------------------------------------------------------------------------------------------------------------
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить "К", большие "С" заменить маленькими "с".
// Метод будет принимать строку и старый символ который нужно заменить на новый

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, " // Этот текст будет возвращатьсся с изменениями
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue) // string text - текст, char oldValuе - старый символ, char newValue - новый символ
// {
//     string result = String.Empty; // Инициализация пустой строки
//     int length = text.Length; // Показывает длину строки
//     for(int i = 0; i < length; i++)//Цикл For. Проходим от первого символа до конца строки
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}"; // (==) - значит "Совпадает". Если текущий символ совпал с тем символо который нужно заменить, 
//         // то в результат нужно положить новый символ
//         else result = result + $"{text[i]}";// Если совпадений нет, то в рузультат нужно положить текущий символ
//     }

//     return result; // Возвращает результат
// }
// string newText = Replace(text, ' ', '|');// В новом тексте заменить "пробелы" на "|"

// Console.WriteLine(text);// Старый тект
// Console.WriteLine();
// Console.WriteLine(newText); // Заменили пробелы
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');//Заменили регистр всех маленьких (К)
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');//Заменили регистр всех маленьких (С)
// Console.WriteLine(newText);
// Console.WriteLine();

//Алгоритм сортировки выбором------------------------------------------------------------------------------------------------------------------------------------------------

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// далее пишем метод который выведет этот массив на экран
void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// Метод будет упорядочивать массив
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length -1 ; i++)
    {
        int minPosition = i;
        
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    Console.WriteLine();
}




PrintArray(arr);
SelectionSort(arr);


PrintArray(arr);