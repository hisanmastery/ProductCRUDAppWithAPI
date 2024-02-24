namespace App.Web.Models
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int LanguageId { get; set; }
        public string Summary { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public DateTime? ModificationOn { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageLocalPath { get; set; }
        public IFormFile? Image { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
