using System.Collections.Generic;

namespace Artistas.Models
{
    public class Artist
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public List<string> Works { get; set; }
        public string Link { get; set; }
    }
}
