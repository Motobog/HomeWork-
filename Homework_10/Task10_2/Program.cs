/*Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}*/

string[] GenerateArray(int linesNumber)
{
    string allLetters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
    string[] randomArray = new string[linesNumber];
    for (int i = 0; i < linesNumber; i++)
        for (int j = 0; j < 3; j++)
            randomArray[i] += allLetters[new Random().Next(0, linesNumber)];

    return randomArray;
}

string[] MergeArray(string[] array)
{
    int length = array.Length / 2;
    string[] newArray = new string[length];
    for (int i = 0; i < length; i++)
        newArray[i] = array[i * 2] + array[i * 2 + 1];

    return newArray;
}

void PrintArray(string[] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(i + 1 + ". " + array[i]);

    Console.WriteLine();
}

Console.Clear();

Console.Write("Enter an even number of array rows: ");
bool sucsessNumber = int.TryParse(Console.ReadLine(), out int number);

if (sucsessNumber && number % 2 == 0)
{
    string[] newArray = GenerateArray(number);
    PrintArray(newArray);
    PrintArray(MergeArray(newArray));

    Console.WriteLine();
}
else Console.WriteLine("Input correct numbers");
