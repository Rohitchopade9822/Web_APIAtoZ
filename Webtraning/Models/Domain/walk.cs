namespace Webtraning.Models.Domain
{
    public class walk
    {
        public Guid Id { get; set; }

        public string name { get; set; }

        public string Description { get; set; }

        public float LengthInKm { get; set; }

        public string? WalkImageUrl { get; set; }

       

        public Guid DifficultyId { get; set; }

        public Guid RegionId {  get; set; }

        
        //navigation properties

        public Difficulty Difficulty { get; set; }

        public Region Region { get; set; }

    }
}
