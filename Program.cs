// ======================================================Домашняя работа==============================================================


// Задача 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

// Console.WriteLine("Введите несколько чисел через пробел" );
// int Nums = int.Parse(Console.ReadLine()!);


// ------------------методы---------------------------


// int[] stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries){

//     int numS = 0;
//     string num = Convert.ToString();    

//     int[] numArray = new int[num.Length];
//     for(int i = 0; i < num.Length; i++){
//         if(i > 0){
//             numS += 1;
//         }

//     } 
// }




// Задача 43. Написать программу, которая на вход принимает массив из любого
// количества элементов(не менее 6) в промежутке от 0 до 100, а на выходе 
// выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему)

int[] arr = GetArray(8, 0, 100);
Console.WriteLine($"[{String.Join(",", arr)}]");

SelectionSort(arr);
Console.WriteLine($"[{String.Join(",", arr)}]");

// --------------------методы------------------------

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }           
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
        
}


