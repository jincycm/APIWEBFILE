namespace ProductProject.Models.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class ResponseDto
    {
        public int RetVal { get; set; }
        public string RetMsg { get; set; }
    }
}
