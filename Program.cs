/*// Task 2. Напишите программу, которая на вход принимает два числа и выдаёт большее число.

// Console.Write("Input the first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1<num2) Console.Write(num2+" - наибольшее");
// else Console.Write(num1+" - наибольшее");*/

/* //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/
Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

while ((num1 > num2) && (num1 > num3)) {
    Console.WriteLine(num1);
    if ((num2 > num3) && (num2 > num1)) {
        Console.WriteLine(num2);
    }
    else {
        Console.WriteLine(num3);
    }
}

