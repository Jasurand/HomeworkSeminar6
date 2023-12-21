// Задача 1. Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива

string NewString(char[,] array)
{
    string myString = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) myString += array[i, j];
    }
    return myString;
}

char[,] array = new char[,] { { 'x', '4', '&' }, { '@', 'b', '8' } };
string MyString = NewString(array);
Console.WriteLine(MyString);