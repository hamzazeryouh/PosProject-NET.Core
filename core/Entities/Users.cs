﻿namespace core.Entities
{
   public  class Users : EntityBase
    {
        public string  UserName  { get; set; }
        public string Email  { get; set; }
        public string Password  { get; set; }
        public string NumberPhone { get; set; }
        public Rolls Roll { get; set; }

    }
}
