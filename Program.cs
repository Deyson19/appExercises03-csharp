// See https://aka.ms/new-console-template for more information
using appExercises03.Exercises;

Console.WriteLine("Hello, World!");

//Convertir 212 F a celsius
var result = LogicProblems.ReverseCase("Hello World");
Console.WriteLine($"Result: {result}");

Console.WriteLine($"Result from page: {LogicProblems.ReverseCase("Happy Birthday")}");
Console.WriteLine($"Result from page: {LogicProblems.ReverseCase("MANY THANKS")}");
Console.WriteLine($"Result from page: {LogicProblems.ReverseCase("sPoNtAnEoUs")}");

//Evitar que se cierre el programa
//Console.ReadKey();