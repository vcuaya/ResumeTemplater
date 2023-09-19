namespace ResumeTemplater.Models
{
    public enum LinkType
    {
        Github,
        LinkedIn
    }

    public class Link
    {
        public LinkType LinkType { get; set; }
        public string URLPath { get; set; }

        public Link(LinkType linkType, string urlPath)
        {
            LinkType = linkType;
            URLPath = urlPath;
        }
    }
}
