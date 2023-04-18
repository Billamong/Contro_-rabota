void ZapolnenieStoki(string[] one, string[] two)
{   
    int j = 0;
    for (int i = 0; i < one.Length; i++)
    {
        Console.Write($"{one[i]}, ");
        if (one[i].Length <= 3)
        {
            two[j] += one[i];
            j++;
        }
    }
}

Console.Clear();
string[] massiv = { "12355", "2", "Tu",
      "Wednesday", "Join", "151", "-5" };
string[] fin = new string[massiv.Length];
ZapolnenieStoki(massiv, fin);
Console.WriteLine();
Console.Write(string.Join(" ", fin));


