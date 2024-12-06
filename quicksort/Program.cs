// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Hello, World!");
var random = new Random();

var numbers = Enumerable.Range(1, 1000).OrderBy(x => random.Next()).ToList();

var sortedNumbers = Quicksort(numbers);

foreach (var number in sortedNumbers)
{
    Console.WriteLine(number);
}

List<int> Quicksort(List<int> numbers)
{
    if (numbers.Count == 0)
    {
        return numbers;
    }
    var lastNumber=numbers.Last();
    var smallerNumbers = new List<int>();
    var largerNumbers = new List<int>();
    foreach (var number in numbers)
    {
        if (number < lastNumber)
        {
            smallerNumbers.Add(number);
        }
        else if (number > lastNumber)
        {
            largerNumbers.Add(number);
        }
    }

    var tempNumbers = new List<int>();
    tempNumbers.AddRange(Quicksort(smallerNumbers));
    tempNumbers.Add(lastNumber);
    tempNumbers.AddRange(Quicksort(largerNumbers));

    return tempNumbers;
}