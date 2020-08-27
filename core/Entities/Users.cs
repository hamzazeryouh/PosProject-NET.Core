using System.Collections.Generic;

namespace core.Entities
{
   public  class Users : EntityBase
    {
        public string  UserName  { get; set; }
        public string Email  { get; set; }
        public string Password  { get; set; }
        public string NumberPhone { get; set; }
        public ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }



    }
}
