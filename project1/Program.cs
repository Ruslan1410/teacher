// Begin2◦
// Дана сторона квадрата a. Найти его площадь S = a^2

            // Console.Write("Enter A: ");
            // int a = int.Parse(Console.ReadLine()!);
            // Console.WriteLine(a * 4);
// Begin 1. Дана сторона квадрата a. Найти его периметр P = 4·a

//  Даны стороны прямоугольника a и b. Найти его площадь S = a·b и
// периметр P = 2·(a + b)
// Дан диаметр окружности d. Найти ее длину L = π·d. В качестве
// значения π использовать 3.14.
// Console.Write("Enter number A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Enter number B: ");
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine ("S = " + a*b);
// Console.WriteLine ("P = " + 2*(a+b));
// Console.Write("Enter number D: ");
// int d = int.Parse(Console.ReadLine());


// Console.WriteLine ("L = " + 3.14*d);

// Дана длина ребра куба a. Найти объем куба V = a^3
// и площадь его
// поверхности S = 6·a^2

// Console.Write("Enter number A: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("V: " + a*a*a);
// Console.WriteLine("S: " + 6*a*a);

// Даны длины ребер a, b, c прямоугольного параллелепипеда. Найти
// его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c)

// Console.Write("Enter number A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Enter number B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Enter number C: ");
// int c = int.Parse(Console.ReadLine());
// Console.WriteLine("V = " + a*b*c);
// Console.Write("S = " + 2*(a*b + b*c + a*c));

// Begin7 Найти длину окружности L и площадь круга S заданного радиуса R: L = 2·π·R, S = π·R^2

// Console.Write("Enter number R: ");
// int r = int.Parse(Console.ReadLine());
// Console.WriteLine("L = " + 2*3.14*r);
// Console.WriteLine("S = " + 3.14*r*2);

// Begin8◦
// . Даны два числа a и b. Найти их среднее арифметическое: (a + b)/2.

// Console.Write ("Enter number A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write ("Enter number B: ");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine($"Arithmetic = {(a+b)/2} ");

// Begin9◦
// . Даны два неотрицательных числа a и b. Найти их среднее геометрическое, то есть квадратный корень из их произведения: √a·b

// Console.Write ("Enter number A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write ("Enter number B: ");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine($"Root = {Math.Sqrt(a*b)} ");


// Begin10◦ Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.

// Console.Write ("Enter number A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write ("Enter number B: ");
// int b = int.Parse(Console.ReadLine());
// int a2 = a*a;
// int b2 = b*b;
// Console.WriteLine($"Sum = {a2+b2}"); 
// Console.WriteLine($"Diff = {a2-b2}");
// Console.WriteLine($"Product = {a2*b2} ");
// Console.WriteLine($"Private = {a2/b2} ");

// Begin11◦ Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей.
// Console.Write ("Enter number A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write ("Enter number B: ");
// int b = int.Parse(Console.ReadLine());
// int mod = Math.Abs(a - b);
// Console.WriteLine($" Sum = {mod + mod}");
// Console.WriteLine($" Dif = {mod - mod}");
// Console.WriteLine($" Product = {mod * mod}");
// Console.WriteLine($"Private = {mod/mod} ");

// Begin12◦ Даны катеты прямоугольного треугольника a и b. Найти его гипотенузу c и периметр P:c =√a2 + b2, P = a + b + c.

// Console.Write ("Enter number A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write ("Enter number B: ");
// int b = int.Parse(Console.ReadLine());
// double c = Math.Sqrt(a*a * b*b);
// Console.WriteLine("C =" + c);
// Console.WriteLine($"P = {a+b+c}");

// Begin20 Найти расстояние между двумя точками с заданными координатами
// (x1, y1) и (x2, y2) на плоскости. Расстояние вычисляется по формуле q(x2 − x1)2 + (y2 − y1)2

// Console.Write ("Enter number x1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write ("Enter number y1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write ("Enter number x2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write ("Enter number y2: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.WriteLine ($"Range = {Math.Sqrt ((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1))}");

// Begin22◦ Поменять местами содержимое переменных A и B и вывести новые значения A и B

int a = 4;
int b = 5;
a = b;b = a;
Console.WriteLine (a);
Console.WriteLine (b);