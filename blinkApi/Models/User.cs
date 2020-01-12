using System.Collections.Generic;

namespace blinkApi.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        
        public virtual List<Posts> posts { get; set; }
    }
}