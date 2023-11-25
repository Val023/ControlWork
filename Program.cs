// Алгоритм решения задачи
Console.Write("Введите количество элементов массива: ");
int temp = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [temp];
void Array(string [] stringArray)
{
    for (int i = 0;i<stringArray.Length;i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        stringArray[i] = Console.ReadLine();
    }
}
string [] symbol(string [] stringArray)
{
    int count = 0;
    for (int i = 0;i<stringArray.Length;i++)
    {
        if(stringArray[i].Length <=3)
        count++;
    }
    string [] result = new string [count];
}

