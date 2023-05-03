﻿using ClassroomExercise;

var myInput01 = new UserInput("1,2");
myInput01.GetParts();
var myInput02 = new UserInput("1,");
myInput02.GetParts();
var myInput03 = new UserInput("1,a");
myInput03.GetParts();
var myInput04 = new UserInput("-1,b");
myInput04.GetParts();
var myInput05 = new UserInput("-1,5");
myInput05.GetParts();

static void logger(UserInput message)
{
    var checker = new SetupChain().GetChain;
    Console.WriteLine(message.GetUserString() + " \n" + message.GetNumbers());
    Console.WriteLine($"{checker.ProcessRequest(message).Item2}\n");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("========================================================================\n");
    Console.ResetColor();
}

logger(myInput01);
logger(myInput02);
logger(myInput03);
logger(myInput04);
logger(myInput05);