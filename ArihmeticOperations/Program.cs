/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте две целочисленные переменные и выведите на экран результаты всех арифметических операций над этими двумя переменными.
*/
int a = 13, b = 9;
int addition = a + b;
int subtract = a - b;
int multiply = a * b;
float division = (float) a / b;

Console.WriteLine($"Результат сложения {a} и {b} равен " + addition);
Console.WriteLine($"Результат вычитания {a} и {b} равен " + subtract);
Console.WriteLine($"Результат умножения {a} и {b} равен " + multiply);
Console.WriteLine($"Результат деления {a} и {b} равен " + division);

Console.ReadKey(); 
