namespace Heroes.FrontEnd.DTOs;

public class Hero
{
    public int ID { get; set; }
    public string HeroName { get; set; } = string.Empty;
    public string AlterEgo { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Info { get; set; } = string.Empty;
    public int ComicID { get; set; }
    public Comic Comic { get; set; }
}

