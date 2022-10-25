namespace AllSprings.Models
{
    public class HotSprings
    {
        public string Name { get; set; }
        public string GPS { get; set; }
        public string Location { get; set; }
        public string Link { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string Directions { get; set; }
        public string Access { get; set; }
        public string MainImg { get; set; }
        public string OtherImg { get; set; }
        public int Temp { get; set; }
        public bool isPrivate { get; set; }
        public bool isPaid { get; set; }
        public bool Visited { get; set; }
    }
}