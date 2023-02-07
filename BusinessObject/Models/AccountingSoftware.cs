using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class AccountingSoftware
    {
        public AccountingSoftware()
        {
            Fields = new HashSet<Field>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Field> Fields { get; set; }
    }
}
