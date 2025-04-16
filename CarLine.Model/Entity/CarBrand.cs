namespace CarLine.Model.Entity
{
    public class CarBrand : BaseEntity<int>
    {

        

        public string Name { get; set; }

        public List<PictureBrand> Picture { get; set; } = new List<PictureBrand>();

        public List<MaintenanceCenter>  MaintenanceCenters { get; set; }
    }
}