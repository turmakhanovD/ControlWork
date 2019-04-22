using System;

namespace NomadApp
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }   
        public Guid SubscriptionId { get; set; }
    }
}
