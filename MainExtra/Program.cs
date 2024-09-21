#region BT01

// Console.WriteLine("Enter days: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int weeks = number / 7;
// int days = number % 7;
// Console.WriteLine($"{number} days = {weeks} weeks and {days} days ");

#endregion

#region BT02

// //input
// Console.Write("input Total order values: ");
// int total = Convert.ToInt32(Console.ReadLine());
// Console.Write("input percentage reduction: ");
// int reduction = Convert.ToInt32(Console.ReadLine());

// //process
// int discount = total * reduction / 100;// ???
// int sum = total - discount;

// //output
// Console.WriteLine($"Discount amount: {discount} \nSum: {sum}");

#endregion

#region  BT03

// //input
// Console.Write("Enter the number of minutes: ");
// int minutesTotal = Convert.ToInt32(Console.ReadLine());

// //process
// int hour = minutesTotal / 60;
// int minutes = minutesTotal % 60;

// //output
// Console.WriteLine($"{minutesTotal} minutes = {hour} hour and {minutes} minutes");

#endregion

#region BT04

// //input
// Console.Write("Enter the money ($): ");
// int money = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the VAT (%): ");
// int vat = Convert.ToInt32(Console.ReadLine());

// //process
// int sum = money + money*vat/100;

// //output
// Console.Write("The total amount payable: " + sum);

#endregion

#region 
//input
Console.Write("Enter the money (USD): ");
int moneyUsd = Convert.ToInt32(Console.ReadLine());
Console.Write("The exchange rate converts USD to VND: ");
int exchange = Convert.ToInt32(Console.ReadLine());
//precess
int moneyVnd = moneyUsd*exchange;
//output
Console.Write($"{moneyUsd} USD = {moneyVnd} VND");

#endregion