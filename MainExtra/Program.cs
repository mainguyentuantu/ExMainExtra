Console.WriteLine("Enter days: ");
int number = Convert.ToInt32(Console.ReadLine());
int weeks = number / 7;
int days = number % 7;
Console.WriteLine($"{number} days = {weeks} weeks and {days} days ");