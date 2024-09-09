// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Transactions;

int numberOfSandwiches;
int numberOfToppings;
double totalSandwichCost;
double totalToppingCost;
double baseCost;
double orderCost;
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

double tip;
Console.WriteLine("Enter the number of sandwiches: ");
numberOfSandwiches = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of toppings: ");
numberOfToppings = int.Parse(Console.ReadLine());
Console.WriteLine("Enter tip: ");
tip = double.Parse(Console.ReadLine());

totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;
orderCost = tip + baseCost * (1 - DISCOUNT_AMOUNT);

Console.WriteLine("Total Cost:");
Console.WriteLine(orderCost);
  