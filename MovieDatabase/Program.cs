using MovieDatabase;

//make list of all movies
List<Movie> movies = new List<Movie>();
movies.Add(new Movie("A Bug's Life", "Animated", 95, 1998, "Dave Foley"));
movies.Add(new Movie("Toy Story", "Animated", 81, 1995, "Tom Hanks"));
movies.Add(new Movie("Shrek", "Animated", 90, 2001, "Mike Myers"));
movies.Add(new Movie("Titanic", "Drama", 194, 1997, "Leonardo DiCaprio"));
movies.Add(new Movie("The Godfather", "Drama", 175, 1972, "Marlon Brando"));
movies.Add(new Movie("Friday The 13th", "Horror", 95, 1980, "Betsy Palmer"));
movies.Add(new Movie("The Evil Dead", "Horror", 85, 1981, "Bruce Campbell"));
movies.Add(new Movie("I, Robot", "Scifi", 115, 2004, "Will Smith"));
movies.Add(new Movie("Jurrasic Park", "Scifi", 127, 1993, "Sam Neill"));
movies.Add(new Movie("Alien vs. Predator", "Scifi", 115, 2004, "Sanaa Lathan"));
//make list of movies categories
List<string> categoryList = new List<string>();
movies.ForEach(x => categoryList.Add(x.Category));
categoryList = categoryList.Distinct().ToList();
Console.WriteLine("Welcome to the movie database!");
bool runprogram = true;
while(runprogram)
{
    //display list of movie categories
    Console.WriteLine(string.Format("{0, -5}{1, -10}", "#", "Category"));
    Console.WriteLine("==============");
    categoryList.ForEach(x => Console.WriteLine(string.Format("{0, -5}{1, -10}", $"{categoryList.IndexOf(x) + 1}", $"{x}")));
    string category = "";
    while (true)
    {
        //prompt user for category and validate input
        Console.WriteLine("What category of movie are you looking for? Enter a category name or number");
        category = Console.ReadLine().ToLower().Trim();
        if (int.TryParse(category, out int num) && (num > 0 && num < categoryList.Count + 1))
        {
            category = categoryList[num - 1].ToLower();
        }
        if (categoryList.Where(x => x.ToLower() == category).ToList().Count() != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Unaccepted input. Try Again");
        }
    }
    //make a list of movies in selected category and sort alphabetically
    List<Movie> selectedCategory = new List<Movie>();
    selectedCategory = movies.Where(x => x.Category.ToLower() == category).ToList();
    List<Movie> sorted = selectedCategory.OrderBy(x => x.Title).ToList();
    //display movies and info
    sorted.ForEach(x => x.giveInfo());
    if (!Validator.Validator.GetContinue())
    {
        runprogram = false;
    }
}
