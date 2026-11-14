public class Film {
    public string Name;
    public int Data;
    public string Genre;
    public double Rating;
    public string Status;

    public Film (string name, int data, string genre, double rating)
    {
        Name = name;
        Data = data;
        Genre = genre;
        Rating = rating;
        Status = "Доступен";
    }
}