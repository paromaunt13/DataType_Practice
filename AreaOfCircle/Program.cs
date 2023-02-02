/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r. Используя формулу πR 2 , вычислите площадь круга и выведите результат на экран.
*/
const double pi = Math.PI;
int r = 13;

float areaOfCircle = (float)(pi * Math.Pow(r,2));

Console.WriteLine("Площадь круга: " + areaOfCircle);
Console.ReadKey();


