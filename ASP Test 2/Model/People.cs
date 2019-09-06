using System;
using System.Collections.Generic;

namespace ASP_Test_2.Model
{
    public partial class People
    {
        public People()
        {
            Order = new HashSet<Order>();
        }

        public string Name { get; set; }
        public int? BirthYear { get; set; }
        public int? Age { get; set; }
        public string Mother { get; set; }
        public string Father { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
