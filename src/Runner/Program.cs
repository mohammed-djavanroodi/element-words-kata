using Core;

while (true)
{
    Console.WriteLine("Enter a 5 letter word or q to exit: ");
    var input = Console.ReadLine() ?? string.Empty;
    if (input.Equals("q", StringComparison.InvariantCultureIgnoreCase))
        break;

    var results = ElementalWords.ElementalForms(input);

    Console.WriteLine($"Input word: {input}");
    foreach(var result in results)
        Console.WriteLine($"\t{string.Join(" ", result)}");

    Console.WriteLine($"--- Finished ---{Environment.NewLine}");
}

return 0;