// Из имеющегося массива строк программа формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

Console.WriteLine("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
string [] userArray = new string [lines];
int max = 3;

for (int i = 0; i < lines; i++)
{
    Console.WriteLine($"Введите строку {i+1}: ");
    userArray[i] = Console.ReadLine();
}
Console.Write("Массив пользователя: ");
for (int i = 0; i < lines; i++)
{
    Console.Write(userArray[i] + ", ");
}
Console.WriteLine();
Console.Write("Массив новый: ");

int j = 0;
for (int i = 0; i < lines; i++)
{
    string [] newArray = new string [j+1];
    if(userArray[i].Length <= max)
    {
        newArray[j] = userArray[i];
        Console.Write(newArray[j] + ", ");
        j++;
    }
}