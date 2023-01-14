namespace SampleData.Entities;

public class Address
{
    public int AddressId { get; set; }
    public Person Person { get; set; }
    public string Line1 { get; set; }
    public string? Line2 { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public Address(string line1, string city, string stateProvice, Person person, string? line2 = null, string country = "USA")
    {
        Line1 = line1;
        City = city;
        StateProvince = stateProvice;
        Line2 = line2;
        Country = country;
        Person = person;
    }

}