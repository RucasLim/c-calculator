using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace cal_Kohyun
{
    class Calculator

    {
        static void Main()
        {

            double oprand1 = 0, oprand2 = 0, oprand3 = 0, sum = 1;

            string operaTor;
            int n;
            string moreData = "";

            do
            {
                WriteLine("Please input the operator");
                operaTor = ReadLine();

                while (int.TryParse(operaTor, out n) == false || operaTor == "+" || operaTor == "-" || operaTor == "*" || operaTor == "/" || operaTor == "MAX+")
                {
                    if (operaTor == "+")
                    {

                        WriteLine("You want to add two numbers together, please input the first oprand: ");
                        oprand1 = double.Parse(ReadLine());

                        WriteLine("Please input 2nd operand");
                        oprand2 = double.Parse(ReadLine());

                        sum = oprand1 + oprand2;

                        WriteLine("The calculation result is");
                        WriteLine("{0} + {1} = {2}", oprand1, oprand2, sum);

                        WriteLine();
                        WriteLine("Do you want to another calculation? Type Y to continue and anyother key th exit :");
                        moreData = ReadLine();

                        return;
                    }
                    else if (operaTor == "-")
                    {

                        WriteLine("You want to subtract two numbers, please input the first oprand: ");
                        oprand1 = double.Parse(ReadLine());

                        WriteLine("Please input 2nd operand");
                        oprand2 = double.Parse(ReadLine());
                        sum = oprand1 - oprand2;

                        WriteLine("The calculation result is");
                        WriteLine("{0} - {1} = {2}", oprand1, oprand2, sum);

                        WriteLine();
                        WriteLine("Do you want to another calculation? Type Y to continue and anyother key th exit :");
                        moreData = ReadLine();
                    }
                    else if (operaTor == "*")
                    {

                        WriteLine("You want to multply two numbers, please input the first oprand: ");
                        oprand1 = double.Parse(ReadLine());

                        WriteLine("Please input 2nd operand");
                        oprand2 = double.Parse(ReadLine());

                        sum = oprand1 * oprand2;

                        WriteLine("The calculation result is");
                        WriteLine("{0} * {1} = {2}", oprand1, oprand2, sum);

                        WriteLine();
                        WriteLine("Do you want to another calculation? Type Y to continue and anyother key th exit :");
                        moreData = ReadLine();
                    }
                    else if (operaTor == "/")
                    {

                        WriteLine("You want to divide two numbers, please input the first oprand: ");
                        oprand1 = double.Parse(ReadLine());

                        WriteLine("Please input 2nd operand");
                        oprand2 = double.Parse(ReadLine());

                        sum = oprand1 / oprand2;

                        WriteLine("The calculation result is");
                        WriteLine("{0} / {1} = {2}", oprand1, oprand2, sum);

                        WriteLine();
                        WriteLine("Do you want to another calculation? Type Y to continue and anyother key th exit :");
                        moreData = ReadLine();

                    }
                    else if (operaTor == "MAX")
                    {

                        WriteLine("You want to find the max among three operands, please in put the first oprand :");
                        oprand1 = double.Parse(ReadLine());

                        WriteLine("Please input 2nd operand");
                        oprand2 = double.Parse(ReadLine());

                        WriteLine("Please input 3nd operand");
                        oprand2 = double.Parse(ReadLine());


                        WriteLine("The calculation result is");
                        if (oprand1 > oprand2 || oprand1 > oprand3)
                        {
                            WriteLine("MAX({0},{1},{2})={3}", oprand1, oprand2, oprand3, oprand1);

                        }
                        else if (oprand2 > oprand1 || oprand2 > oprand3)
                        {
                            WriteLine("MAX({0},{1},{2})={3}", oprand1, oprand2, oprand3, oprand2);

                        }
                        else if (oprand3 > oprand1 || oprand3 > oprand2)
                        {
                            WriteLine("MAX({0},{1},{2})={3}", oprand1, oprand2, oprand3, oprand3);

                        }

                        moreData = ReadLine();

                    }

                }
            }
            while ((moreData == "y" || moreData == "Y"));
            ReadKey();

        }
    }
}








