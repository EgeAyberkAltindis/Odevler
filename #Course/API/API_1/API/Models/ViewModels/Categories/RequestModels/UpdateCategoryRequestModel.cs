namespace API.Models.ViewModels.Categories.RequestModels
{
    public class UpdateCategoryRequestModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
