var file = File.ReadAllText("adventofcode.com_2022_day_1_input.txt");

var data = file.Split("\n\n");

var elves = data.Select(bag => bag.Split('\n', StringSplitOptions.RemoveEmptyEntries))
                       .Select(foodsInBag => foodsInBag.Sum(food => int.Parse((string)food)))
                       .ToList();

var top = elves.OrderByDescending(c => c).Take(3).ToList();

Console.WriteLine("Max calories is "+ top.Max());
Console.WriteLine("The total of TOP 3 calories is "+ top.Sum());

