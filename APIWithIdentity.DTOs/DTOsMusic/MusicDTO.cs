namespace APIWithIdentity.DTOs.MusicDTOs
{
    public class MusicDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ArtistDTO Artist { get; set; }
    }
}