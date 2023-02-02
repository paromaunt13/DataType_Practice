/*
Используя Visual Studio, создайте проект по шаблону Windows Forms (.Net framework).
Создайте программу для расчета возраста пользователя, 
по введенному им году рождения необходимо вывести его текущий возраст (использовать DateTime).
*/

Console.WriteLine("Введите год Вашего рождения: ");
int birthYear = int.Parse(Console.ReadLine());

int currentYear = DateTime.Now.Year;
int age = currentYear - birthYear;

Console.WriteLine($"Ваш возраст - {age}");
Console.ReadKey();


/*
Console.WriteLine("Введите год Вашего рождения: ");
int birthYear = int.Parse(Console.ReadLine());

int[] yearsOld_1 = { 21, 31, 41, 51 };
int[] yearsOld_2 = { 22, 23, 24, 32, 33, 34, 42, 43, 44, 52, 53, 54 };

int currentYear = DateTime.Now.Year;
int age = currentYear - birthYear;

string yearsOld;

if (yearsOld_1.Contains(age))
{
    yearsOld = "год!";   
}
else if (yearsOld_2.Contains(age))
{
    yearsOld = "года!";
}
else
{
    yearsOld = "лет!";    
}

Console.WriteLine($"Ваш возраст - {age} {yearsOld}");
Console.ReadKey();
*/




