using System;
using System.Linq;

public static class GoodVsEvilKata
{
    static void good()
    {
        Console.WriteLine("good");
        var expectedResults = "Battle Result: Good triumphs over Evil";
        var actualResults = GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0");
        Console.WriteLine($"{expectedResults == actualResults} => {expectedResults} | {actualResults}");
    }
    static void ShouldBeATie()
    {
        Console.WriteLine("tie");
        var expectedResults = "Battle Result: No victor on this battle field";
        var actualResults = GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0");
        Console.WriteLine($"{expectedResults == actualResults} => {expectedResults} | {actualResults}");
    }
    static void EvilShouldWin()
    {
        Console.WriteLine("evil");
        var expectedResults = "Battle Result: Evil eradicates all trace of Good";
        var actualResults = GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1");
        Console.WriteLine($"{expectedResults == actualResults} => {expectedResults} | {actualResults}");
    }

    static string GoodVsEvil(string good, string evil)
    {
        var goodWorth = new int[] { 1, 2, 3, 3, 4, 10 };

        var evilWorth = new int[] { 1, 2, 2, 2, 3, 5, 10 };

        var goodNumbers = good.Split(' ').Select(x => Int32.Parse(x)).ToArray();
        var evilNumbers = evil.Split(' ').Select(x => Int32.Parse(x)).ToArray();

        var goodScore = 0;
        var evilScore = 0;

        for (int i = 0; i < goodWorth.Length; i++)
        {
            goodScore += goodWorth[i] * goodNumbers[i];
        }
        for (int i = 0; i < evilWorth.Length; i++)
        {
            evilScore += evilWorth[i] * evilNumbers[i];
        }
        return goodScore > evilScore
        ? "Battle Result: Good triumphs over Evil"
        : evilScore > goodScore
        ? "Battle Result: Evil eradicates all trace of Good"
        : "Battle Result: No victor on this battle field";
    }

    public static void Run()
    {
        // good();
        EvilShouldWin();
        // ShouldBeATie();
    }
}