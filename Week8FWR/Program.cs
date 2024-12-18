string[] tvShows = { "Firefly", "Office", "The Last of Us", "Friends", "Twin Peaks", "House", "Stranger Things" };
string[] food = { "sushi", "pizza", "Chinese takeaway", "burger and chips", "chicken wings", "chips", "popcorn" };
string[] drinks = { "mineral water", "Coca-Cola", "apple juice", "milk", "beer" };

string randomMovie = PickRandomFromArry(tvShows);
string randomFood = PickRandomFromArry(food);
string randomDrink = PickRandomFromArry(drinks);

Console.WriteLine($"I recommend you to watch {randomMovie} tonight.");
Console.WriteLine($"Order some {randomFood} and {randomDrink}.");

static string PickRandomFromArry(string[] someArry)
{
    Random rnd = new Random();

    int randomIndex = rnd.Next(0, someArry.Length);
    string randomElement = someArry[randomIndex];
    return randomElement;
}