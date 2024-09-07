int k = 0;
double num1 = 0, num2 = 0, data = 0;
while (k == 0)
{
    Console.Clear();
    Console.WriteLine(" "); Console.WriteLine("КАЛЬКУЛЯТОР"); Console.WriteLine("Возможные операции:"); Console.WriteLine(" ");
    Console.WriteLine("+"); Console.WriteLine("-"); Console.WriteLine("*"); Console.WriteLine("/"); Console.WriteLine("%"); Console.WriteLine("1/x"); Console.WriteLine("x^2"); Console.WriteLine("x^1/2"); Console.WriteLine("M+"); Console.WriteLine("M-"); Console.WriteLine("MR");
    Console.WriteLine(" "); Console.WriteLine("Введите знак операции (x, M и R вводятся на английском языке) или 0 для выхода из программы:");
    string? a = Console.ReadLine(), flag;
    int danet = 0;
    switch (a)
    {
        case "0":
            k = 1;
            break;
        case "+":
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: {0}", num1 + num2);
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
        case "-":
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: {0}", num1 + num2);
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
        case "*":
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: {0}", num1 * num2);
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
        case "/":
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = Convert.ToDouble(Console.ReadLine());
            while (num2 == 0)
            {
                Console.WriteLine("Нельзя делить на 0, введите заново");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Ответ: {0}", num1 / num2);
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
        case "%":
            Console.WriteLine("Введите число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: {0}", num1 / 100);
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
        case "1/x":
            Console.WriteLine("Введите число");
            num1 = Convert.ToDouble(Console.ReadLine());
            while (num1 == 0)
            {
                Console.WriteLine("Нельзя делить на 0, введите заново");
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Ответ: {0}", 1 / num1);
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
        case "x^2":
            Console.WriteLine("Введите число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: {0}", Math.Pow(num1, 2));
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
        case "x^1/2":
            Console.WriteLine("Введите число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: {0}", Math.Pow(num1, 0.5));
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
        case "M+":
            Console.WriteLine("Введите число");
            num1 = Convert.ToDouble(Console.ReadLine());
            data += num1;
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
        case "M-":
            Console.WriteLine("Введите число");
            num1 = Convert.ToDouble(Console.ReadLine());
            data -= num1;
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
        case "MR":
            Console.WriteLine("Значение из памяти: {0}", data);
            Console.WriteLine("Очистить значение? если да - введите 1, если нет - 0");
            danet = Convert.ToInt32(Console.ReadLine());
            if (danet == 1)
            {
                data = 0;
            }
            Console.WriteLine("Нажмите enter для возвращения");
            flag = Console.ReadLine();
            break;
    }
}