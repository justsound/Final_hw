// Console.Clear();

//Написать программу,которая из имеющего массива строк формирует массив из строк, длина которых меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнени алгоритма.

string[] CreateTextMassive(int count)
{
    string[] array = new string[count];
    for (int i = 0; i < count; i ++)
    {
        Console.WriteLine($"Введите {i+1}-ю строку");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

Console.WriteLine("Введите количество строк(размер массива): ");
int num = int.Parse(Console.ReadLine()!);
string[] text = CreateTextMassive(num);

void PrintTextMassive(string[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i].Length <= 3) Console.WriteLine(array[i]);
    }
}
PrintTextMassive(text);