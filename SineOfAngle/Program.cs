/*
Используя Visual Studio, создайте проект по шаблону Console Application.                                  
Создать программу для определения синуса угла, ввод угла должен осуществлять пользователь.
*/

Console.WriteLine("Введите величину угла: ");
int angleValue = int.Parse(Console.ReadLine());

var angleSineValue = Math.Sin(angleValue);

Console.WriteLine("Величина синуса угла: " + angleSineValue);
Console.ReadKey();