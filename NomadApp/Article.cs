using System;

namespace NomadApp
{
    public class Article : Entity
    {
        public string Title { get; set; }
        public string ArticleText { get; set; }
        public DateTime PublishedTime { get; set; }
    }
}
