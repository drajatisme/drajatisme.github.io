namespace Resume.BlazorClient.TransferObjects
{
    public class ProjectTransferObject
    {
        public string Name { get; set; } = string.Empty;
        public string Overview { get; set; } = string.Empty;
        public List<string> Medias { get; set; } = new List<string>();
        public List<string> Features { get; set; } = new List<string>();
        public List<string> Tools { get; set; } = new List<string>();
    }
}
