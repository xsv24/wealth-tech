WealthTeach(Enumerable.Range(1, 100));

// Separate function to generate the item string to make the code more testable.
string GetWord(int num) {
    var word = "";
    
    if (num % 3 == 0) {
        word += "Wealth";
    }

    if (num % 5 == 0) {
        word += "Tech";
    }

    return $"{num}: {word}\n";
}


void WealthTeach(IEnumerable<int> numbers) {
    Console.WriteLine(string.Join("", numbers.Select(GetWord)));
}