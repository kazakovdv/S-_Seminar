Console.WriteLine("Введите трехзначное число ");
int n = 0;
while(n < 1000)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }
