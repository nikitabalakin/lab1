using static System.Math;
using System.Linq;


/*//Первое задание
{
    Console.WriteLine("Введите логарифм");
    double logarifm = Convert.ToDouble(Console.ReadLine());//Вводим логарифм
    Console.WriteLine("Введите Основание");
    double osnovanie = Convert.ToDouble(Console.ReadLine());//Вводим основание
    Console.WriteLine("До какого n знака округлять");
    int round_to = Convert.ToInt32(Console.ReadLine());//Вводим до скольки округляем
    double itog = Log(logarifm, osnovanie);//Используем log, для подсчета логарифма
    double vivod = Round(itog, round_to);//используем round для округления
    Console.WriteLine(vivod);//выводим результат
}*/

/*//Второе задание
{
    Console.WriteLine("Меню");
    Console.WriteLine("1. Из градусов в радианы");
    Console.WriteLine("2. Из радианов в градусы");
    int menu = Convert.ToInt32(Console.ReadLine());//Вводим пункт меню
    const double Pi = 3.14;//Делаем константу пи для работы
    const double col_vo_gradusov = 180;//создаем вторую константу для работы
    if (menu == 1)
    {
        Console.WriteLine("Конвертация из градусов в радианы выбрана");
        Console.WriteLine("Введите Градусы");
        int gradus = Convert.ToInt32(Console.ReadLine());//Вводим градусы
        double itog = gradus * Pi / col_vo_gradusov;//Используем формулу для получения градусов
        Console.WriteLine("До какого n знака округлять");
        int round_to = Convert.ToInt32(Console.ReadLine());// Вводим значения для округления
        double vivod = Round(itog, round_to);//Округляем
        Console.WriteLine(vivod);//выводим
    }    
    else if (menu == 2)
    {
        Console.WriteLine("Конвертация из радианов в градусы выбрана");
        Console.WriteLine("Введите радианы");
        int radian = Convert.ToInt32(Console.ReadLine());//Вводим радианы
        double itog = radian * col_vo_gradusov / Pi;
        Console.WriteLine("До какого n знака округлять");//Используем формулу для получения радиан
        int round_to = Convert.ToInt32(Console.ReadLine());
        double vivod = Round(itog, round_to);// Вводим значения для округления
        Console.WriteLine(vivod);//выводим
    }
    else Console.WriteLine("Только 1 или 2");
}*/



//Третье задание
{
    
    
    Console.WriteLine("Первый параллелограмм");//Вводим первую фигуру
    Console.WriteLine("Введите вершину а, x координату");
    double a1x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину а, y координату");
    double a1y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину b, x координату");
    double b1x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину b, y координату");
    double b1y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину c, x координату");
    double c1x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину c, y координату");
    double c1y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину d, x координату");
    double d1x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину d, y координату");
    double d1y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Второй параллелограм");//Вводим первую фигуру
    Console.WriteLine("Введите вершину а2, x координату");
    double a2x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину а2, y координату");
    double a2y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину b2, x координату");
    double b2x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину b2, y координату");
    double b2y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину c2, x координату");
    double c2x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину c2, y координату");
    double c2y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину d2, x координату");
    double d2x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вершину d2, y координату");
    double d2y = Convert.ToDouble(Console.ReadLine());

    var DOWN = Sqrt(Pow(a1x - d1x, 2.0) + Pow(a1y - d1y, 2.0));//на основе введённой информации считаем размер всех сторон
    var UP = Sqrt(Pow(b1x - c1x, 2.0) + Pow(b1y - c1y, 2.0));
    var Levo = Sqrt(Pow(a1x - b1x, 2.0) + Pow(a1y - b1y, 2.0));
    var Pravo = Sqrt(Pow(c1x - d1x, 2.0) + Pow(c1y - d1y, 2.0));

    var DOWN2 = Sqrt(Pow(a2x - d2x, 2.0) + Pow(a2y - d2y, 2.0));
    var UP2 = Sqrt(Pow(b2x - c2x, 2.0) + Pow(b2y - c2y, 2.0));
    var Levo2 = Sqrt(Pow(a2x - b2x, 2.0) + Pow(a2y - b2y, 2.0));
    var Pravo2 = Sqrt(Pow(c2x - d2x, 2.0) + Pow(c2y - d2y, 2.0));
    //Проверяем на наложение фигур
    if(a1x == a2x || b1x == b2x || c1x == c2x || d1x == d2x || a1y == a2y || b1y == b2y || c1y == c2y || d1y == d2y)
    {
        Console.WriteLine("Недопустимые фигуры");
        return;
    }
    if (a1x >= a2x && a1x <= b2x && a1y >= a2y && a1y <= b2y || b1x >= a2x && a1x <= c2x && b1y >= a2y && a1y <= c2y || c1x >= a2x && a1x <= d2x && c1y >= a2y && a1y <= d2y || d1x >= a2x && a1x <= a2x && d1y >= a2y && a1y <= a2y)
    {
        Console.WriteLine("Наложение");
        Environment.Exit(0);
    }

    if (a1x >= b2x && b1x <= b2x && a1y >= b2y && b1y <= b2y || b1x >= b2x && b1x <= c2x && b1y >= b2y && b1y <= c2y || c1x >= b2x && b1x <= d2x && c1y >= b2y && b1y <= d2y || d1x >= b2x && b1x <= a2x && d1y >= b2y && b1y <= a2y)
    {
        Console.WriteLine("Наложение");
        Environment.Exit(0);
    }

    if (a1x >= c2x && c1x <= b2x && a1y >= c2y && c1y <= b2y || b1x >= c2x && c1x <= c2x && b1y >= c2y && c1y <= c2y || c1x >= c2x && c1x <= d2x && c1y >= c2y && c1y <= d2y || d1x >= c2x && c1x <= a2x && d1y >= c2y && c1y <= a2y)
    {
        Console.WriteLine("Наложение");
        Environment.Exit(0);
    }

    if (a1x >= d2x && d1x <= b2x && a1y >= d2y && d1y <= b2y || b1x >= d2x && d1x <= c2x && b1y >= d2y && d1y <= c2y || c1x >= d2x && d1x <= d2x && c1y >= d2y && d1y <= d2y || d1x >= d2x && d1x <= a2x && d1y >= d2y && d1y <= a2y)
    {
        Console.WriteLine("Наложение");
        Environment.Exit(0);
    }


    Console.WriteLine("Первая фигура");//Если стороны равны выводим
        if (Levo == Pravo || UP == DOWN && Levo == Pravo || UP == DOWN)
        {
            Console.WriteLine("Фигура построена");
        }
        else if (Levo == UP && Pravo == DOWN && a1x < d1x || b1x < c1x || a1x == d1x || b1x == c1x)
        {
            Console.WriteLine("Ошибка");
        }
        else//Если ничего не подходит выводим ошибку, там франкинштейн
        {
            Console.WriteLine("Ошибка при построении неизвестной фигуры");
        }
        Console.WriteLine("Вторая фигура");//Если стороны равны выводим
        if (Levo2 == Pravo2 || UP2 == DOWN2 && Levo2 == Pravo2 || UP2 == DOWN2)
        {
            Console.WriteLine("Фигура построена");
        }
        else if (Levo2 == UP2 && Pravo2 == DOWN2 && a1x < d2x || b2x < c2x || a2x == d2x || b2x == c2x) 
    {
            Console.WriteLine("Ошибка");
        }
        else//Если ничего не подходит выводим ошибку, там франкинштейн
        {
            Console.WriteLine("Ошибка при построении неизвестной фигуры");
        }
}

/*
// четвертое задание
{
    Console.WriteLine("Введите уравнение"); char modul = '|';//оставил что-бы строк было 42
    string? vvod = Console.ReadLine();
    char[] vvod_mas = vvod.ToCharArray();//Засовываем всю строку в массив 
    int index_x = Array.IndexOf(vvod_mas, 'x');//Находим икс
    int index_modul1 = Array.IndexOf(vvod_mas, '|') + 1;//находим первую скобку
    int index_modul2 = Array.IndexOf(vvod_mas, modul, index_modul1 + 1);//находим вторую скобку
    int modul_distanse = index_modul2 - index_modul1;//находим разницу в их местопложении
    char[] mas = new char[modul_distanse];//делаем новый массив на их основе
    Array.Copy(vvod_mas, index_modul1, mas, 0, modul_distanse);//срезаем массив в нужных местах
    string vvod1 = String.Concat<char>(mas);//Переносим массив в строку
    int vvod2 = Convert.ToInt32(vvod1);//Конвертируем в инт
    Console.WriteLine($"|{vvod2}| Модуль числа {Abs(vvod2)}");//используем абс для получения модуля
    char[] mas1 = new char[index_x+1];//делаем новый массив на количество слов от x
    Array.Copy(vvod_mas, 0, mas1, 0, index_x+1);//заполняем массив
    Array.Reverse(mas1);//Инвертируем его для поиска
    int plus = Array.IndexOf(mas1, '+');//находим ближайший плюс 
    int minus = Array.IndexOf(mas1, '-');//находим ближайший минус
    if (plus < minus)//Если плюс меньше минуса, значит мы словили, ближайший наш плюс.
    {
        char[] mas2 = new char[plus + 1];//Делаем еще один массив по размеру от плюса
        Array.Copy(mas1, 0, mas2, 0, plus + 1);//заполняем новый массив срезая нужные символы
        Array.Reverse(mas2);//инвертируем для нормального вывода
        string result = String.Concat<char>(mas2);//переводим в строку
        string result2 = result.Replace("x", "");//заменяем исксы на воздух
        Console.WriteLine($"{result2} Множитель");//выводим работу
    }
    else if (minus < plus)//Если минус меньше плюса, значит мы словили, ближайший наш минус.
    {
        char[] mas2 = new char[minus+1];//Делаем новый массив по размеру от минуса
        Array.Copy(mas1, 0, mas2, 0, minus + 1);//заполняем срезав ненужные символы
        Array.Reverse(mas2);//инвертируем для нормального вывода
        string result = String.Concat<char>(mas2);//переводим в строку
        string result2 = result.Replace("x", "");//заменяем иксы на воздух
        Console.WriteLine($"{result2} Множитель");//выводим работу.

    }
    else if(plus == minus)// если мы получили равенство значит x стоял первый
    {
        Array.Reverse(mas1); string result3 = String.Concat<char>(mas1); string result4 = result3.Replace("x", "");//переворачиваем строку и выводим результат
        Console.WriteLine($"{result4} множитель");
    }
}*/

//Пятое задание
/*
{
    Random rng = new Random();//объявление рандома для дальнейшего использования 
    double[,] mas = new double[5, 10];// создание массива в формате дабл, что-бы использовать дальше
    HashSet<int> known = new HashSet<int>();//Задаем ГЛОБАЛЬНЫЙ хешсет
                                            //Генерация массива.
    for (int i = 0; i < 5; i++)//Столб
    {
        for (int j = 0; j < 10; j++)//Строка
        {
            int newElement;//делаем новую переменную в которой будут храниться значения
            newElement = rng.Next(-100, 100);//заполняем его случайным элементом
            while (known.Contains(newElement))//если элемент уже есть пересоздаем его
            {
                newElement = rng.Next(-100, 100);
            }
            known.Add(newElement);//если элемента нету добавляем его в хешсет
            mas[i, j] = newElement;//добавляем в массив
        }
    }
    Console.WriteLine("Оригинальный массив");
    //вывод чистого массива.
    for (int i = 0; i < 5; i++)//столбцы
    {
        for (int j = 0; j < 10; j++)//строки
        {
            Console.Write("{0}\t", mas[i, j]);//выводим массив по заданным перемененным.
        }
        Console.WriteLine();//для красоты
    }
    //Первое задание
    Console.WriteLine("--------------------Первое задание--------------------");
    Console.WriteLine("--------------------Минимальные значения--------------------");
    for (int i = 0; i < 5; i++)//строки
    {
        double min = int.MaxValue;//перменная
        for (var j = 0; j < 10; j++)//столбцы
        {
            if (mas[i, j] < min)//проверка самого маленького
            {
                min = mas[i, j];// самое маленькое записываем
            }

        }
        Console.WriteLine(min);//выводим все минимальные
        for (int j = -10; j < 10; j++)//цикл для счета синуса, косинуса, тангенса
        {
            if (j == 0)// на нуле пишем что прошли его, косинус нуля и так ноль.
            {
                Console.WriteLine("Ноль пройден, дальше положительные");
            }
            else//для всего не равного нулю считаем его.
            {
                double sin = Math.Sin(j * min);//каждое значение в строке ложем сюда 
                double cos = Math.Cos(j * min);//множим на минимальное,пройдём диапазон от -10 до 10
                double tan = Math.Tan(j * min);
                double sin_r = Math.Round(sin, 2);//Округляем получившийся результат
                double cos_r = Math.Round(cos, 2);//Округляем получившийся результат
                double tan_r = Math.Round(tan, 2);//Округляем получившийся результат
                Console.Write($"{sin_r} С|");//выводим синус
                Console.Write($"{cos_r} К|");//выводим косинус
                Console.Write($"{tan_r} Т|");// выводим тангенс
                Console.WriteLine();//делаем отступ
            }
        }
    }
    Console.WriteLine("--------------------Максимальное значения--------------------");
    for (int i = 0; i < 5; i++)//столбцы
    {
        double max = int.MinValue;//задаем минимальное для максимального
        for (var j = 0; j < 10; j++)//строки
        {
            if (mas[i, j] > max)//находим максимальное из минимальных
                max = mas[i, j];//записываем его
        }
        Console.WriteLine(max);// выводим его
        for (int j = -10; j < 10; j++)//
        {
            if (j == 0)//как только принимает ноль пишем что он пройден.
            {
                Console.WriteLine("Ноль пройден, дальше положительные");
            }
            else
            {
                double sin = Math.Sin(j * max);//находим синус 
                double cos = Math.Cos(j * max);//находим косинус
                double tan = Math.Tan(j * max);//находим тангенс
                double sin_r = Math.Round(sin, 2);//округляем 
                double cos_r = Math.Round(cos, 2);//еще раз округляем
                double tan_r = Math.Round(tan, 2);//снова округляем
                Console.Write($"{sin_r} С|");//выводим округлённый синус
                Console.Write($"{cos_r} К|");//косинус
                Console.Write($"{tan_r} Т|");//тангенс
                Console.WriteLine();
            }
        }
    }
    Console.WriteLine("--------------------Второе задание--------------------");
    double[] mas2 = new double[5];//создаем новый массив
    for (int i = 0; i < 5; i++)//перебираем столбцы
    {
        double mas_1 = 0;//делаем новую перменную для добавления туда значений 
        for (int j = 0; j < 10; j++)// перебираем строки
        {
            mas_1 += Math.Abs(mas[i, j]);//складываем из строки все значения

        }
        mas_1 /= 10;//делим на количество
        mas2[i] = mas_1;//присваиваем в новый массив
    }
    for (int i = 0; i < 5; i++)//выводим средне арифметическое
    {
        Console.WriteLine(mas2[i]);
    }
    Console.WriteLine("--------------------Третье задание--------------------");
    double min1 = double.MaxValue;//новые перменные для максимального и минимального
    double max1 = double.MinValue;
    for (int i = 0; i < 5; i++)//находим минимальное
    {
        if (mas2[i] < min1)
        {
            min1 = mas2[i];
        }

    }
    for (int i = 0; i < 5; i++)//находим максимальное
    {
        if (mas2[i] > max1)
        {
            max1 = mas2[i];
        }
    }
    Console.WriteLine($"{min1} Минимальное");
    Console.WriteLine($"{max1} Максимальное");
    using StreamWriter file = new("test.txt", append: true);
    for (int j = -10; j < 10; j++)//выводит от максимального
    {
        double sin = Math.Sin(j * max1);//находим синус 
        double cos = Math.Cos(j * max1);//находим косинус
        double tan = Math.Tan(j * max1);//находим тангенс
        double sin_r = Math.Round(sin, 2);//округляем 
        double cos_r = Math.Round(cos, 2);//еще раз округляем
        double tan_r = Math.Round(tan, 2);//снова округляем
        Console.Write($"{sin_r} С|");//выводим округлённый синус
        Console.Write($"{cos_r} К|");//косинус
        Console.Write($"{tan_r} Т|");//тангенс
        Console.WriteLine();
        string sin_s = Convert.ToString(sin_r);//конвертируем в строку для вывода в текстовый формат
        string cos_s = Convert.ToString(cos_r);
        string tan_s = Convert.ToString(tan_r);
        await file.WriteLineAsync($"{sin_s}|{cos_s}|{tan_s}");
        //выводим в текстовый формат с разделителем
    }
}
*/