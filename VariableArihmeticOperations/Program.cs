/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Имеется 3 переменные типа int x = 10, y = 12, и z = 3; 
Выполните и рассчитайте результат следующих операций для этих переменных: 

x += y - x++ * z;  
z = --x - y * 5; 
y /= x + 5 % z; 
z = x++ + y * 5; 
x = y - x++ * z;
*/

int x = 10, y = 12, z = 3;

int firstOperation = x += y - x++ * z;
int secondOperation = z = --x - y * 5;
int thirdOperation = y /= x + 5 % z;
int fourthOperation = z = x++ + y * 5;
int fifthOperation = x = y - x++ * z;

Console.WriteLine($"Результат первой операции: {firstOperation}");
Console.WriteLine($"Результат второй операции: {secondOperation}");
Console.WriteLine($"Результат третей операции: {thirdOperation}");
Console.WriteLine($"Результат четвертой операции: {fourthOperation}");
Console.WriteLine($"Результат пятой операции: {fifthOperation}");

