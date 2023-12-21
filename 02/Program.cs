// Задача 2. Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные

Console.Write("Введите предложение: ");
string sentence = Console.ReadLine()!;
sentence = sentence.ToLower();
Console.WriteLine(sentence);