namespace StillsApp.DL;

//SOLID Single Responsibility Principle: Each software module or a class should have one and only one reason to change. Adding an address or experience does not require changes to Distillery. Changing a review or a photo does not require changes to any other classes.
public class Address
{
    public int Id { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public string? Phone { get; set; }
    public int DistilleryId { get; set; }
}

public class Brand
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public List<Recipe>? Recipes { get; set; }
    public int DistilleryId { get; set; }
}
public class Distillery
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Address>? Addresses { get; set; }
    public List<Experience>? Experiences { get; set; }
    public List<Brand>? Brands { get; set; }
    public List<Photo>? Photos { get; set; }
    public List<Review>? Reviews { get; set; }
    public int OwnerId { get; set; }
}

public class Experience
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public List<Ticket>? Tickets { get; set; }
    public Distillery? Distillery { get; set; }
    public int DistilleryId { get; set; }
    public int BrandId { get; set; }
}

public class Owner
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<Distillery>? Distilleries { get; set; }
}

public class Photo
{
    public int Id { get; set; }
    public string? FileName { get; set; }
    public string? Base64Encoding { get; set; }
    public string? Category { get; set; }
    public int DistilleryId { get; set; }
}

public class Recipe
{
    public int Id { get; set; }
    public int BottleProof { get; set; }
    public string? BarrelProof { get; set; }
    public string? PercentCorn { get; set; }
    public string? PercentWheat { get; set; }
    public string? PercentBarley { get; set; }
    public string? PercentRye { get; set; }
    public int BrandId { get; set; }
}

public class Review
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int DistilleryId { get; set; }
}

public class Ticket
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Price { get; set; }
    public int ExperienceId { get; set; }
}