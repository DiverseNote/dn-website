using System;

namespace DiverseNote.Objects
{
    public class UserAccount : IEntity
    {
        public string Id { get; set; }

        public int UserId { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Activated { get; set; }

        public string EmailAddress { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
