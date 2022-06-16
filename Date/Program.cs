//Задание 5
//Пользователь вводит с клавиатуры дату. Приложе-
//ние должно отобразить название сезона и дня недели. 
//Например, если введено 22.12.2021, приложение должно 
//отобразить Winter Wednesday.

int k;
do
{
    Console.WriteLine("Input date (template - 22.12.2021) ");
    DateTime dtu = DateTime.Parse(Console.ReadLine());
    int mon = (dtu.Month);
    string seaz;
    if (mon > 11 || mon < 3)
    {
        seaz = "Winter";
    }
    else if (mon > 2 && mon < 6)
    {
        seaz = "Spring";
    }
    else if (mon > 5 && mon < 9)
    {
        seaz = "Summer";
    }
    else
    {
        seaz = "Fall";
    }
    Console.WriteLine(dtu.DayOfWeek+ " - " + seaz);
    Console.WriteLine("Int key - 1 - to continue, 0 - to exit");
    k = int.Parse(Console.ReadLine());
} while (k == 1);
return;