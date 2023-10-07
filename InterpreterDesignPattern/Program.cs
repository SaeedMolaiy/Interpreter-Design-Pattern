﻿using InterpreterDesignPattern.Expressions;

Expression number1 = new NumberExpression(1);
Expression number2 = new NumberExpression(2);
Expression number3 = new NumberExpression(3);

Expression addExpression = new AddExpression(number1, number2);
Expression subtractExpression = new SubtractExpression(addExpression, number3);

var result = subtractExpression.Interpret();

Console.WriteLine("Result: " + result);

Console.ReadKey();