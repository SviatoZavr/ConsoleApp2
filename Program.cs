//Задание1 Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

Console.WriteLine("Введите минимальную температуру в течении дня");
double mintemp = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите максимальную температуру в течении дня");
double maxtemp = Convert.ToDouble(Console.ReadLine());
double averagetemp = (mintemp + maxtemp) / 2;

Console.WriteLine($"Средняя температура в течении дня {averagetemp}");


//Заданиие2 Запросить у пользователя порядковый номер текущего месяца и вывести его название.

Console.WriteLine("Введите название месяца");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
        Console.WriteLine("Январь");
        break;
    case 2:
        Console.WriteLine("Февраль");
        break;
    case 3:
        Console.WriteLine("Март");
        break;
    case 4:
        Console.WriteLine("Апрель");
        break;
    case 5:
        Console.WriteLine("Май");
        break;
    case 6:
        Console.WriteLine("Июнь");
        break;
    case 7:
        Console.WriteLine("Июль");
        break;
    case 8:
        Console.WriteLine("Август");
        break;
    case 9:
        Console.WriteLine("Сентябрь");
        break;
    case 10:
        Console.WriteLine("Октябрь");
        break;
    case 11:
        Console.WriteLine("Ноябрь");
        break;
    case 12:
        Console.WriteLine("Декабрь");
        break;
    default:
        Console.WriteLine("Такого месяца еще не придумали)))");
        break;
}
//Задание 5 Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».

    if (a == 1 && a==2 && a==12 && averagetemp > 0)
    {
        Console.WriteLine("Дождливая зима");
    }
    else
    {
        return;
    }






// Задание3 Определить, является ли введённое пользователем число чётным.

//Console.WriteLine("Введите число");
//int a= Convert.ToInt32(Console.ReadLine());
//if (a % 2 == 0)
//{
//    Console.WriteLine("Число четное");
//}
//else
//{
//    Console.WriteLine("Число нечетное");
//}

//Задание 4 Для полного закрепления понимания простых типов найдите любой чек,
//либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
//только за место динамических, по вашему мнению, данных
//(это может быть дата, название магазина, сумма покупок) подставляйте переменные,
//которые были заранее заготовлены до вывода на консоль

//string a = "Хлеб";
//string b = "Сыр";
//string c = "Мороженое";
//double aa = 50;
//double bb = 120;
//double cc = 160;
//Console.WriteLine(@$"
//КАССОВЫЙ ЧЕК

//ООО МАГАЗИН

//{DateTime.Now}

//1. {a}={aa} рублей
//2. {b}={bb} рублей
//3. {c}={cc} рублей
//Итого:{aa+bb+cc} рублей

//");


