
using System;

namespace DiverseNote.Objects
{
    public class UserInfo : IEntity
    {
        public string Id { get; set; }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public License License { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
