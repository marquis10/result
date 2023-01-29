Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine()), count = 0, dlina = 3;
string? [] array1 = new string[size];
for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    array1[i] = Console.ReadLine();
}
Console.WriteLine($"Начальный массив array1: [{string.Join(", ", array1)}]");
// Определяем длину 2 массива, посчитав количество элементов <= 3
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i]?.Length <= dlina)
        count++;
}
string? [] array2 = new string[count];
// Заполняем 2 массив
for (int i = 0, j = 0; i < array1.Length; i++)
{
    if (array1[i]?.Length <= dlina)
        {
            array2[j] = array1[i];
            j++;
        }
}
Console.Write($"array2: [{string.Join(", ", array2)}]");