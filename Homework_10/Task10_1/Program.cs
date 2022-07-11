/*Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1*/
string[] GenerateArray(int linesNumber)
{
    string allLetters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
    string[] randomArray = new string[linesNumber];
    for (int i = 0; i < linesNumber; i++)
        for (int j = 0; j < 3; j++)
            randomArray[i] += allLetters[new Random().Next(0, linesNumber)];

    return randomArray;
}

int CheckVowels(string[] array)
{
    int count = 0;
    string vowels = "a e o u y i";
    string[] vowelsArray = vowels.Split(" ");

    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < vowelsArray.Length; j++)
            if (array[i][0] == Convert.ToChar(vowelsArray[j]))
                count++;

    return count;
}

void PrintArray(string[] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(i + 1 + ". " + array[i]);

    Console.WriteLine();
}

Console.Clear();

Console.Write("Enter the number of lines in the array: ");
bool sucsessNumber = int.TryParse(Console.ReadLine(), out int number);

if (sucsessNumber && number > 0)
{
    string[] newArray = GenerateArray(number);
    PrintArray(newArray);
    Console.WriteLine("Number of words with first vowel: " + CheckVowels(newArray));

    Console.WriteLine();
}
else Console.WriteLine("Input correct numbers");
