/*
Используя Visual Studio, создайте проект по шаблону Console Application.                                  
Создать программу для определения гипотенузы прямоугольного треугольника, используя формулу,
где с – гипотенуза, а b и a катеты прямоугольного треугольника. 
Ввод катетов должен осуществлять пользователь. 
*/


Console.WriteLine("Введите длину первого катета: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите длину второго катета: ");
int b = int.Parse(Console.ReadLine());

int c = (int)(Math.Sqrt(a * a + b * b));

Console.WriteLine("Длина гипотенузы равна " + c);
Console.ReadKey();