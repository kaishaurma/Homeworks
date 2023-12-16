#region Task1
/*
var number = Console.ReadLine();
int chooseNumber = Convert.ToInt32(number);
var x = chooseNumber %5;

if (x == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/
#endregion

#region Task2

var chooseNumber1 = Console.ReadLine();
int x = Convert.ToInt32(chooseNumber1);
var chooseNumber2 = Console.ReadLine();
int y = Convert.ToInt32(chooseNumber2);

var add = x + y;
Console.WriteLine(add);

var sub = x > y ? x - y : y - x;
Console.WriteLine(sub);

var mult = x * y;
Console.WriteLine(mult);

var div = x > y ? x / y : y / x;
Console.WriteLine(div);            //divide by 0 exception

#endregion

#region Task3
/*
var chooseX = Console.ReadLine();
int x = Convert.ToInt32(chooseX);
var chooseY = Console.ReadLine();
int y = Convert.ToInt32(chooseY);
Console.WriteLine(y);
Console.WriteLine(x);
*/
#endregion

#region Task4
/*
var chooseX = Console.ReadLine();
int x = Convert.ToInt32(chooseX);
var n = 1;
while (n < 10)
{
    Console.WriteLine(n * x);
    n++;
}
*/
#endregion

#region Task5
/*
var chooseN = Console.ReadLine();
int n = Convert.ToInt32(chooseN);
int x;
for (x = 2; x <= n; x+=2)
{
    Console.WriteLine(x * x);
}
*/
#endregion