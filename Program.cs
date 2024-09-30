Console.WriteLine("Task 1");
Console.WriteLine("Enter a number");
var number = Convert.ToInt32(Console.ReadLine());
if(number%5==0){
    Console.WriteLine("Yes, number is divisible by 5");
} else Console.WriteLine("No, number is not divisible by 5");

Console.WriteLine("Task 2");
Console.WriteLine("Enter two numbers line by line");
var X = Convert.ToInt32(Console.ReadLine());
var Y = Convert.ToInt32(Console.ReadLine());
var greaterOrEqualNum = X > Y ? X : Y;
var lessThanEqualNum = X + Y - greaterOrEqualNum;
Console.WriteLine("X+Y=" + (X + Y));
Console.WriteLine("X*Y=" + (X * Y));
var divisionResult = "Not Allowed To Divide By Zero";
if(lessThanEqualNum!=0) divisionResult = (greaterOrEqualNum / lessThanEqualNum).ToString();
if(greaterOrEqualNum==Y){
Console.WriteLine("Y-X=" + (Y-X));
Console.WriteLine("Y/X=" + divisionResult);

}
else {
Console.WriteLine("X-Y=" + (X-Y));
Console.WriteLine("X/Y=" + divisionResult);

}

Console.WriteLine("Task 3");
Console.WriteLine("Enter two numbers line by line");
var x = Convert.ToInt32(Console.ReadLine());
var y = Convert.ToInt32(Console.ReadLine());
var temp = y;
y = x;
x = temp;
Console.WriteLine("x=" + x);
Console.WriteLine("y=" + y);

Console.WriteLine("Task 4");
Console.WriteLine("Enter a number");
var inputNumber = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<10; i++){
    Console.WriteLine($"{inputNumber}*{i}={inputNumber*i}");
}

Console.WriteLine("Task 5");
Console.WriteLine("Enter a number");
var n = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<n; i++){
    if(i%2==0) Console.WriteLine(i*i);
}

