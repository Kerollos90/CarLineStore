namespace CarLine.Model.Entity
{
    public class CarBrand
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Picture> Picture { get; set; } = new List<Picture>();

        public List<MaintenanceCenter>  MaintenanceCenters { get; set; }
    }
}