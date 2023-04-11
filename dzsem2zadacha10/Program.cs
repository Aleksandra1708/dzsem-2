int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt ("Введите 3ч-значное число >");
if (number < 100 || number >= 1000)
{
    Console.WriteLine ("Введенное число не является 3-х значным, пожалуйста повторите ввод");
    return;
}
Console.WriteLine ($"Введенное число '{number}'");
int secondRank = number / 10 % 10 ;
Console.WriteLine ($"Вторая цифра '{secondRank}'");