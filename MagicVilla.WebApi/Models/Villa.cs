namespace MagicVilla.WebApi.Models
{
    public record Villa
    {
        public int Id { get; set; }
        public required string VillaName { get; set; }
    }
}