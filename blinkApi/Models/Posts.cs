namespace blinkApi.Models
{
    public class Posts
    {
        public int id { get; set; }
        public string message { get; set; }
        public string img_url { get; set; }
        public int user_id { get; set; }
        
        public virtual User user { get; set; }
    }
}