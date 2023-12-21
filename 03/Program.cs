// Задача 3. Задайте произвольную строку
// Выясните, является ли она палиндромом

bool palindrom(string str)
{
    string check = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return check.SequenceEqual(check.Reverse());
}

Console.Write("Введите предложение: ");
string sentence = Console.ReadLine()!;
bool ifitis = palindrom(sentence);
Console.WriteLine(ifitis ? "Да" : "Нет");