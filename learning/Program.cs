// See https://aka.ms/new-console-template for more information
using learning;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Sum.Sum4Number();
//FOR.SumByFor();
//ForZoj.ForByZoj2();string s;

double a, b;
string operitor;

Console.WriteLine("amaliat ra vared konid ");
operitor = Console.ReadLine();

Console.WriteLine("adad aval ra vared konid:");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("adad dovom ra vared konid:");
b = Convert.ToDouble(Console.ReadLine());

if (operitor == "+")
    Console.WriteLine("jam: " + (a + b));
else if (operitor == "-")
    Console.WriteLine("tafrigh: " + (a - b));
else if (operitor == "*")
    Console.WriteLine("zarb: " + (a * b));
else if (operitor == "/")
    Console.WriteLine("taghsim: " + (a / b));
else
    Console.WriteLine("operitor na shenakht shod.");
    
    




















