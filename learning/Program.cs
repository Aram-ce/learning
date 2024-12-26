// See https://aka.ms/new-console-template for more information
using learning;
using System;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Sum.Sum4Number();
//FOR.SumByFor();
//ForZoj.ForByZoj2();

Console.WriteLine("reshteh vared konid:");
string input = Console.ReadLine();

// معکوس کردن رشته
string reversed = ReverseString(input);

Console.WriteLine($"reshte makos shodeh: {reversed}");

// منتظر ماندن برای دریافت ورودی از کاربر قبل از بستن کنسول
Console.WriteLine("enter ra feshar dahid.");
Console.ReadLine();
        

        static string ReverseString(string s)
{
    char[] charArray = s.ToCharArray(); // تبدیل رشته به آرایه ی کاراکترها
    Array.Reverse(charArray); // معکوس کردن آرایه
    return new string(charArray);
     } // تبدیل آرایه معکوس شده به رشته


























