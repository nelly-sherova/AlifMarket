using System;
namespace lesson3
{
    public class Programm
    {
        static void Main()
        {

            decimal userBalance = 300m;
            string basket = "";
            string erroBalanceMessage = "У вас недостаточно средств";

        start: //Метка "start"

            System.Console.WriteLine($"Ваш баланс - {userBalance}");

            if (userBalance <= 0)
            {
                System.Console.WriteLine(erroBalanceMessage);
                goto End;
            };

            System.Console.WriteLine("" +
            "1 Кола - 10 сомон\n" +
            "2 Сникерс - 7 сомон\n" +
            "3 Марс - 9 сомон\n" +
            "4 M&Ms - 4 сомон\n" +
            "5 Чипсы - 14 сомон\n" +
            "6 Выход\n" +
            "Ваш выбор (1-6):");

            int choice = int.Parse(Console.ReadLine());

            // goto start; //идти к метке "start"
            switch (choice)
            {
                case 1:
                    {
                        if (userBalance - 10 >= 0)
                        {
                            basket += "Кола,";
                            userBalance -= 10;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Вы хотите продолжить? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    break;
                    case 2:
                    {
                        if (userBalance - 7 >= 0)
                        {
                            basket += "Сникерс,";
                            userBalance -= 7;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Вы хотите продолжить? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    break;
                    case 3:
                    {
                        if (userBalance - 9 >= 0)
                        {
                            basket += "Марс,";
                            userBalance -= 9;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Вы хотите продолжить? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    break;
                    case 4:
                    {
                        if (userBalance - 4 >= 0)
                        {
                            basket += "M&Ms,";
                            userBalance -= 4;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Вы хотите продолжить? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    break;
                    case 5:
                    {
                        if (userBalance - 14 >= 0)
                        {
                            basket += "Чипсы,";
                            userBalance -= 14;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Вы хотите продолжить? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    break;
                case 6: goto End;
                default: goto start;
                break;
            }

        End:
            System.Console.WriteLine($"Ваши покупки:{basket}\nВаш баланс:{userBalance}");
            Console.ReadKey();
        }
    }
}