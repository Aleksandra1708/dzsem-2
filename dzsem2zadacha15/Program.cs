﻿int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekDay (int number)
{
    if ( number > 0 && number <=7)
    {
        return true;
    }
    Console.WriteLine ("ЭТО не день недели!");
    return false;
}

int weekDay = Prompt( "Введите день недели >");
if (ValidateWeekDay(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine ("Наконец выходной");
    }
    else
    {
        Console.WriteLine ("Работай пока");
    }
}