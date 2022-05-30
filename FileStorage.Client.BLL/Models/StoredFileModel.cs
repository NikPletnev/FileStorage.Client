namespace FileStorage.Client.BLL.Models
{
    public class StoredFileModel
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public int UserId { get; set; }

    }
}
