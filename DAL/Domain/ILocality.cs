namespace DAL.Domain
{
    public interface ILocality
    {
        int Id { get; set; }
        string Postcode { get; set; }
        string State { get; set; }
        string Suburb { get; set; }
    }
}