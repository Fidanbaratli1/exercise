string num1;
string num2;
int num;
do
{
    Console.WriteLine("Reqemi daxil et");
    num1 = Console.ReadLine();
    num = Convert.ToInt32(num1);
    if (!(num >= 10 && num <= 20))
    {
        Console.WriteLine("Error var,davam etmek isteyirsinizmi?");
        num2 = Console.ReadLine();
        if (num2.ToLower() == "yes")
        {
            continue;
        }
    }
    else
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("Reqem cut ededdir");
        }
        else if (num % 2 == 1)
        {
            Console.WriteLine("Reqem tek ededdir");
        }
        break;

    }
}
while (!(num >= 10 && num <= 20));
