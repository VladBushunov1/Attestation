string [] my_str = ["3 nums", "1_n", "t","a lot of symbols", "123", "1234",":-)"];
string [] new_str = new string [my_str.Length];
int j = 0;
for (int i = 0; i < my_str.Length; i++)
{
    if (my_str[i].Length <= 3)
    {
    new_str[j] = my_str[i];
    Console.Write($"{new_str[j]} ");
    j++;
    }
}

