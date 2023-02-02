/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Написать программу для расчета скидки за покупку, скидку и цену товара должен осуществлять пользователь. 
*/

Console.WriteLine("Введите цену товара, грн.: ");
int price = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размер скидки, %: ");
int discount = int.Parse(Console.ReadLine());

float priceWithDiscount = price - (price * discount / 100f);

Console.WriteLine("Итоговая стоимость товара: " + priceWithDiscount + " грн.");
Console.ReadKey();