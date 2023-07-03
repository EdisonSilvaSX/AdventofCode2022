int Result(string strategy)
{
/*
A, B, C
X(1), Y(2), Z(3)

A>Z
B>X
C>Y

*/

    return strategy switch
    {
        "A Z" => 0 + 3,
        "B X" => 0 + 1,
        "C Y" => 0 + 2,
        "A X" => 3 + 1,
        "B Y" => 3 + 2,
        "C Z" => 3 + 3,
        "A Y" => 6 + 2,
        "B Z" => 6 + 3,
        "C X" => 6 + 1,
        _ => 0
    };
}

int Result2(string strategy)
{
    //X = PERDER
    //Y = EMPATAR
    //Z = VITORIA

    var st = strategy.Split();

    return st[1] switch
    {
        "Z" => st[0] switch
        {
            "A" => 6 + 2,
            "B" => 6 + 3,
            "C" => 6 + 1,
            _ => 0
        },
        "Y" => st[0] switch
        {
            "A" => 3 + 1,
            "B" => 3 + 2,
            "C" => 3 + 3,
            _ => 0
        },
        "X" => st[0] switch
        {
            "A" => 0 + 3,
            "B" => 0 + 1,
            "C" => 0 + 2,
            _ => 0
        },
        _ => 0
    };
}


var file = File.ReadAllText("adventofcode.com_2022_day_2_input.txt");

var dados = file.Split("\n", StringSplitOptions.RemoveEmptyEntries);

// Console.WriteLine(Result("A Y"));
// Console.WriteLine(Result("B X"));
// Console.WriteLine(Result("C Z"));
// Console.WriteLine(Result("A Y") + Result("B X") + Result("C Z"));

var total = dados.Sum(strategy => Result(strategy));

Console.WriteLine("Fist result is " + total);

// Console.WriteLine(Result2("A Y"));
// Console.WriteLine(Result2("B X"));
// Console.WriteLine(Result2("C Z"));
// Console.WriteLine(Result2("A Y") + Result2("B X") + Result2("C Z"));

var total2 = dados.Sum(strategy => Result2(strategy));

Console.WriteLine("Second result is " + total2);