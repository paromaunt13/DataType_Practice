/*
Используя Visual Studio, создайте проект по шаблону Console Application.                                  
Создайте программу для перевода метров в сантиметры (1м = 100см), ввод метров должен осуществлять пользователь.
*/

Console.WriteLine("Введите количество метров: ");
int meteres = int.Parse(Console.ReadLine());

int centimeters = meteres * 100;

Console.WriteLine($"Количество сантиметров в {meteres} метрах: " + centimeters);

Console.ReadKey();
