Console.Clear();
Console.Write("Задайте количество строк: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string [length];
Console.WriteLine("Введите значение строки: ");
int j = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    array[i] = Convert.ToString(Console.ReadLine());
    if(array[i].Length <= 3) j++;
}
string[] array2 = new string [j];
j = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (array[i].Length <= 3)
    {
        array2[j] = array[i];
        j++;
    }
}
PrintArray(array);
Console.Write(" - ");
PrintArray(array2);

void PrintArray(string [] array)  // Печатает массив
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
       Console.Write(array[i]  + " ");
    }
    Console.Write("]");
}