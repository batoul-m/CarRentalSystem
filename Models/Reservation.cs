public class Reservation
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public int CarId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}