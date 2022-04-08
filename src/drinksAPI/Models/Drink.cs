namespace drinksAPI.Models
{
    public record Drink(
        string uuid,
        string name,
        string brand,
        string country,
        string state,
        string type,
        string subType,
        int age,
        int year,
        string visual,
        string scents,
        string taste,
        Array harmonization,
        string observation
    );
}
