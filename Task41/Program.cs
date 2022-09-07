// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел происходит через Enter, останавливается при введении слова "stop"

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

System.Console.WriteLine("Введите М (количество) чисел:");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

int[] EnterArray(int m)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите чило {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;

}

int[] arr = EnterArray(m);

int MoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
MoreZero(arr);

System.Console.WriteLine($"{string.Join(", ", array)} → {MoreZero(arr)}");


