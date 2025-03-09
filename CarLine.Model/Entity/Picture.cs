namespace CarLine.Model.Entity
{
    public class Picture : BaseEntity<int>
    {
        

        public string PictureUrl { get; set; }

        public int? CarId { get; set; }
    }
}