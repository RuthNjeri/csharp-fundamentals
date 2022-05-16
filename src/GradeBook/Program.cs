// See https://aka.ms/new-console-template for more information

if(args.Length > 0 )
{
    Console.WriteLine($"Hello, {args[0]} !");
}
else
{
    var numbers = new double[3];
    numbers[0] = 12.7;
    numbers[1] = 11.9;
    numbers[2] = 9;

    Console.WriteLine($"The{numbers[2]} sum is: {numbers[2] + numbers[1] + numbers[0]}");
}
