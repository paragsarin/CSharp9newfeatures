using System;
using System.Collections.Generic;
using CSharp9newfeatures;
//C# 9 Features

//1- Top Level Program
Console.WriteLine("Hello World! - I am Top Level Program");

//2- Start Init-props 
InitOnlyProps props1 = new InitOnlyProps();
props1.Address= "";
//Not allowed
//props.Name="Parag"

//Allowed
InitOnlyProps props2 = new InitOnlyProps { Name = "Parag", Address = "USA" };

//Allowed
InitOnlyProps props3 = new InitOnlyProps ("Parag", "USA" );

//End Init-props 

//3-shorthand instantiation
InitOnlyProps shorthandinstantiation = new("Parag", "USA");


//4- Start Pattern Matching 
List<PatternMatching> lst = new List<PatternMatching>();
PatternMatching pm = new(23, "c1");
lst.Add(pm);

pm = new(0, "c2");
lst.Add(pm);

pm = new(-1, "c3");
lst.Add(pm);

pm = new(51, "c4");
lst.Add(pm);

pm = new(31, "c5");
lst.Add(pm);

pm = new(41, "c6");
lst.Add(pm);

PatternMatching.ShowSummary(lst);
Console.WriteLine("Weather forecast for cities");
foreach (var lstvalues in lst)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{lstvalues.City} : {lstvalues.Temp} : {lstvalues.Summary}");
}


//4- End Pattern Matching 

//5- Start Record type
//similar to class with some caveats 
//Immutable
//ToString implementation is different
//ToString
//Equals would give diff results for record and class
IdRecords id1 = new ("Parag", "USA");
//Not allowed
//id1.Address = "1233";

Console.ForegroundColor = ConsoleColor.DarkMagenta;

IdRecords id2 = new("Parag", "USA");

InitOnlyProps classid1 = new InitOnlyProps("Parag", "USA");

InitOnlyProps classid2 = new InitOnlyProps("Parag", "USA");

Console.WriteLine($"ToString record - {id1.ToString()}");

Console.WriteLine($"ToString class - {classid1.ToString()}");

Console.WriteLine($"Equals record - {id1.Equals(id2)}");

Console.WriteLine($"Equals class - {classid1.Equals(classid2)}");
//5- End Record type

Console.ReadLine();
