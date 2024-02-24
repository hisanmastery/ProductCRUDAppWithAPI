namespace AppService.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int LanguageId { get; set; }
        public string Summary { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public DateTime? ModificationOn { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageLocalPath { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

    }
}
