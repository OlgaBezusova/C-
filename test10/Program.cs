/* программа, принимает два числа, проверяет является второе число квадротом первого */


int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a * a == b){
Console.WriteLine("yes");
}
else{
Console.WriteLine("no");
}

