
// string[] array (string[] args)
// {
//     // Инициализация массива строк
//     string[] daysOfWeek = { "Sunday", "Monday", "Tuersday",
//       "Wednesday", "Thirsday", "Friday", "Saturday" };

//     // Вывод массива строк AS в цикле
//     for (int i = 0; i < args.Length; i++)
//         Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);
//     Console.ReadKey();
// }

Console.Clear();
string[] massiv = { "Sunday", "Monday", "Tu",
      "Wednesday", "Thi", "Friday", "Saturday" };
string[] array = new string[10];
int j =0;
for (int i = 0; i < massiv.Length; i++)
{
    Console.Write($"{massiv[i]}, ");
        if (massiv[i].Length <= 3){
            array[j] += massiv[i];
            j++;
        }
}

Console.WriteLine();
for (int i = 0; i < array.Length; i++){
    if(array !=0)
        Console.Write($"{array[i]}, ");
}

