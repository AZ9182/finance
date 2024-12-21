// See https://aka.ms/new-console-template for more information
using Finance;

Console.WriteLine("Hello, World!");

double p = 0;
double r = 0;
double n = 0;

Console.WriteLine("Enter Principle Amount12");
p = double.Parse(Console.ReadLine());
Console.WriteLine(" Annual Enter Interest ");
r = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Tenure in months");
n = double.Parse(Console.ReadLine());

double  mr = r / 12/100;

double mysr = Math.Pow((1 + mr), n) / ((Math.Pow((1 + mr), n)) - 1);
double seconfrr= Math.Pow((1 + mr), (n - 1));


double emi = 0;
emi = p * mr * mysr;
double updatedP = p;
int un = 0;
do
{
    double mnthintsrt = updatedP * mr;
    double reducingPrincipal = emi - mnthintsrt;
    updatedP = updatedP - reducingPrincipal;
    updatedP -= 2000;
    un++;


} while (updatedP > 0);
parent obj = new child();
obj.print();
Console.WriteLine("Your Emi is :  " + emi);
Console.WriteLine("Your total term is :  " + un);



