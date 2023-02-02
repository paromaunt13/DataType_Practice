/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу расчета объема - V и площади поверхности -S цилиндра. Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле:. 
Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR(R+h). Результаты расчетов выведите на экран.
Пользователь должен иметь возможность вводит r – радиус цилиндра и h – высоту цилинда.
*/

Console.WriteLine("Введите радиус цилиндра: ");
int r = int.Parse(Console.ReadLine());

Console.WriteLine("Введите высоту цилиндра: ");
int h = int.Parse(Console.ReadLine());

const double pi = Math.PI;

var s = 2 * pi * r * (r + h);
var v = pi * h * Math.Pow(r,2);

Console.Write($"Площадь поверхности цилиндра: {s} \nОбъем цилиндра: {v}");
Console.ReadKey(); 
