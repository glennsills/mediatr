namespace Sample.Data.Entities;

public class Address
{
    public int AddressId { get; set; }
    public Person Person { get; set; } = null!;
    public string Line1 { get; set; }
    public string? Line2 { get; set; } = null;
    public string City { get; set; }
    public string StateProvince { get; set; } = null!;
    public string Country { get; set; }

    public Address(string line1, string city, string country = "USA")
    {
        Line1 = line1;
        City = city;
        Country = country;
 
    }
}