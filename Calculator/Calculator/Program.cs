// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

var calc = new Calculator.Models.CalculatorV2();
calc.GetInput();
var valid = calc.ParseInput();
Console.WriteLine(calc.Total);


//var other = new Calculator.Calculator();
//other.MyCalculator();


