
//A case(with extra variable)
Console.WriteLine("case 1");
int a = 10;
int b = 20;
Console.WriteLine(a);
Console.WriteLine(b);
int temp = a;
a= b;
b= temp;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();
//B case (without extra varibale)
Console.WriteLine("case 2");
int a1 = 10;
int b1 = 20;
Console.WriteLine(a1);
Console.WriteLine(b1);
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine();
//3th case
Console.WriteLine("case 3");
int a2= 10;
int b2= 20;
Console.WriteLine(a2);
Console.WriteLine(b2);
(a2, b2) = (b2, a2);
Console.WriteLine(a2);
Console.WriteLine(b2);
Console.WriteLine();