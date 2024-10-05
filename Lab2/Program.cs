using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //Console.WriteLine(program.Task_3_2(3,2,1));
        //Console.WriteLine(program.Task_2_1(10));
        //Console.WriteLine(program.Task_2_2(5, 1, 3, 1));
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_2_1(10);
        //program.Task_1_10(0.9);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //Console.WriteLine(program.Task_2_3(8));
        //Console.WriteLine(program.Task_2_5(6, 30));
        //Console.WriteLine(program.Task_2_5(10, 30));
        //program.Task_2_5(10, 30);
        //Console.WriteLine(program.Task_2_11(10));
        //Console.WriteLine(program.Task_2_10(10));
        //Console.WriteLine(program.Task_2_7(4));
        //Console.WriteLine(program.Task_2_2(5, 1, 3, 1));
        //Console.WriteLine(program.Task_2_7(5));
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(10);
        //Console.WriteLine(program.Task_3_5(30));
        //Console.WriteLine(program.Task_2_9(10));
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //Console.WriteLine(program.Task_2_9(10));
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        Console.WriteLine(program.Task_3_8());
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y){
        return Math.Abs((x * x + y * y - 4)) <= 0.001 ? true : false;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        if (y >= 0 && y + Math.Abs(x) <= 1) answer = true;
        return answer;
    }
    public double Task_1_3(double a, double b){ return a > 0 ? Math.Max(a, b) : Math.Min(a, b);}
    public double Task_1_4(double a, double b, double c){return Math.Max(Math.Min(a, b), c);}
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        if (Math.Sqrt(r / Math.PI) * 2  >= Math.Sqrt(s) * Math.Sqrt(2)) { answer = true; }
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        if (Math.Sqrt(r / Math.PI) * 2 < Math.Sqrt(s)) answer = true;

        return answer;
    }
    public double Task_1_7(double x){ return Math.Abs(x) > 1 ? 1 : Math.Abs(x);}
    public double Task_1_8(double x) { return Math.Abs(x) >= 1 ? 0 : x * x - 1; }
    public double Task_1_9(double x)
    {
        double y = 0;
        if (-1 < x && x <= 0) y = 1 + x;
        if (x > 0) y = 1;
        return y;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 1;
        if ((-1 < x) && (x <= 1)) answer = -x;
        if (x > 1) answer = -1;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        for (int i = 0; i < n; i++) answer += int.Parse(Console.ReadLine());

        return answer / n;
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distanceSquared = (x - a) * (x - a) + (y - b) * (y - b);
            if (distanceSquared <= r * r) answer += 1;
        }

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        for (int i = 0; i < n; i++)
        {
            double ves = double.Parse(Console.ReadLine());

            if (ves < 30)
            {
                answer += 200;
            }
        }

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer / 1000;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse((Console.ReadLine()));
            double y = double.Parse((Console.ReadLine()));
            double d = Math.Sqrt(x * x + y * y);
            if (r1 <= d && d <= r2) answer += 1;
        }

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double go = double.Parse((Console.ReadLine()));
            answer = go < norm ? answer + 1 : answer;
        }

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }//�� �����������
    public int Task_2_6(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y)) answer += 1;
        }

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(((Console.ReadLine())));
            double y = double.Parse(((Console.ReadLine())));
            if (x > 0 && y > 0) answer1 += 1;
            if (x < 0 && y < 0) answer3 += 1;
        }

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        for (int i = 0; i < n ; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double d = Math.Sqrt(x * x + y * y);
            if (d < answerLength)
            {
                answer = i + 1;
                answerLength = d;
            }
        }

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        for (int i = 0; i < n; i ++)
        {
            double y = double.Parse(Console.ReadLine());
            if (y < answer) answer = y;
        }
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            if (num1 > 3 && num2 > 3 && num3 > 3 && num4 > 3) answer++;
        }

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        for (int i = 0; i < n; i++)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            if (num1 == 2 || num2 == 2 || num3 == 2 || num4 == 2)
            {
                answer++;
            }
            avg += (num1 + num2 + num3 + num4);
        }

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg / (n * 4));
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        if (r <= 0) return 0;

        if (type == 0) answer = r * r;
        else if (type == 1) answer = Math.PI * r * r;
        else if (type == 2) answer = Math.Sqrt(3) * r * r / 4;


        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A <= 0 || B <= 0) return 0;

        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = B * B * Math.PI - Math.PI * A * A;
                if (A > B) answer = 0;
                break;
            case 2:
                answer = Math.Sqrt(B * B - (A * A)/4) * A / 2;
                break;
        }

        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        
        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        string x; string y;
        double true_or_false = 1;
        int answer = 0;
        while (true)
        {
            x = Console.ReadLine();
            y = Console.ReadLine();
            if (!double.TryParse(x, out true_or_false) || !double.TryParse(y, out true_or_false)) break;
            double distanceSquared = (double.Parse(x) - a) * (double.Parse(x) - a) + (double.Parse(y) - b) * (double.Parse(y) - b);
            if (distanceSquared <= r * r) answer += 1;

        }
        return answer;
        

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;
        double true_or_false = 1;
        string speed = Console.ReadLine();

        while (double.TryParse(speed, out true_or_false))
        {
            answer = double.Parse(speed) < norm ? answer + 1 : answer;
            speed = Console.ReadLine();
        }

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;
        double true_or_false = 1;

        string x = Console.ReadLine();
        string y = Console.ReadLine();
        int count = 1;

        while (double.TryParse(x, out true_or_false) && double.TryParse(y, out true_or_false))
        {
            double d = Math.Sqrt(double.Parse(x) * double.Parse(x) + double.Parse(y) * double.Parse(y));
            if (d < answerLength)
            {
                answer = count;
                answerLength = d;
            }
            count++;
            x = Console.ReadLine();
            y = Console.ReadLine();
        }
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        int true_or_false = 1;

        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        string num3 = Console.ReadLine();
        string num4 = Console.ReadLine();

        while (int.TryParse(num1, out true_or_false) && int.TryParse(num2, out true_or_false) && int.TryParse(num3, out true_or_false) && int.TryParse(num4, out true_or_false))
        {
            if (int.Parse(num1) == 2 || int.Parse(num2) == 2 || int.Parse(num3) == 2 || int.Parse(num4) == 2)
            {
                answer++;
            }
            avg += (int.Parse(num1) + int.Parse(num2) + int.Parse(num3) + int.Parse(num4));
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();
            num3 = Console.ReadLine();
            num4 = Console.ReadLine();

        }

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_12 answer

        return answer;
    }
    public double Task_3_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
