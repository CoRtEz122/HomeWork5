// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] array = new int[4];
// int del = 0;
// int res = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     res = array[i]%2;
   

//     if (res ==0)
//     {
//         del++;
//     }
// }
// Console.WriteLine(String.Join(",",array));
// Console.Write(del);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int[] array = new int[10];
//  int sum = 0;

// for (int i = 0; i < array.Length; i++)
//  {
//      array[i] = new Random().Next(0,10);

     
//  }
//  for (int j = 1; j < array.Length;j+=2)
//      {
//         sum = sum + array[j];
        
//      }
     

//  Console.WriteLine(String.Join(",",array));
// Console.WriteLine(sum);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76




int[] array = new int[10];
int max = 0;
int min = 0;

for (int i = 0; i < array.Length; i++)
  {
      array[i] = new Random().Next(-10,10);
  }  
  Console.WriteLine(String.Join(",",array));

  for (int j = 0; j < array.Length; j++)
  {

    if(array[j]>max)
    {
        max = array[j];
    }
    else
    {
        min = array[j];
    }
  }
  int res = max - min;
  Console.WriteLine(max);
  Console.WriteLine(min);
  Console.WriteLine(res);
   