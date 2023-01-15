using System.ComponentModel.DataAnnotations;

namespace Sample.Data.Entities;

public class Person
{
    public int PersonId { get; set; }

    [MaxLength(30)]
    public string? Prefix { get; set; }

    [MaxLength(30)]
    public string FirstName { get; set; }

    [MaxLength(30)]
    public string? MiddleName { get; set; }

    [MaxLength(30)]
    public string LastName { get; set; }

    [MaxLength(30)]
    public string? Suffix { get; set; }

    public List<Address> Addresses { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Addresses = new List<Address>();
    }

}