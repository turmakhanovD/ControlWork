using System;

namespace NomadApp
{
    public class Delivery : Entity
    {
        public Guid ArticleId { get; set; }
        public Guid UserId { get; set; }
        public bool Delivered { get; set; }
    }
}
