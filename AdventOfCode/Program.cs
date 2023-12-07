﻿using Aoc2023;
namespace AdventOfCode;

internal class Program
{
    static void Main(string[] args)
    {
        //new _2023Day1(Path.Combine(Globals.Input2023, "Day1.txt")).Run();
        //new _2023Day2(Path.Combine(Globals.Input2023, "Day2.txt")).Run();
        //Day3 PlaceHolder
        //new _2023Day4(Path.Combine(Globals.Input2023, "Day4.txt")).Run();
        //new _2023Day5(Path.Combine(Globals.Input2023, "Day5.txt")).Run();
        //new _2023Day6(Path.Combine(Globals.Input2023, "Day6.txt")).Run();
        new _2023Day7(Path.Combine(Globals.Input2023, "Day7.txt")).Run();
        string readFile = File.ReadAllText(Path.Combine(Globals.Input2023, "Day7.txt"));
        Day07 day07 = new Day07(readFile);
        Console.WriteLine(day07.Part1());
        Console.WriteLine(day07.Part2());

    }
}