global using System.Text.RegularExpressions;



// GoodVsEvilKata.Run();
// DirectionReductionKata.Run();
//CustomMath.Run();
//SquareEveryDigit.Run();
//DescendingOrder.Run();
//DuplicateEncoder.Run();
//FindIntAppearingOddTimes.Run();
//TribonacciSequence.Run();
//ListFiltering.Run();
//SplitStringIntoPair.Run();
//YoureASquare.Run();
//MovingZerosToEnd.Run();
Console.WriteLine("Kata Started");
var snail = new Snail();
var result = snail.Run();
foreach (var num in result)
{
    Console.Write($"{num}  ");
}

/*  TO DO
    *  
    * NEED TO LEAN REGEX
    * StripComment.Run();
    * 
*/