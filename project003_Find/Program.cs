﻿//Программа по нахождению элемента массива равному переменной

int[] array = {1, 2, 8, 3, 4, 5, 6, 7, 8};

int n = array.Length;
int find = 8;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}