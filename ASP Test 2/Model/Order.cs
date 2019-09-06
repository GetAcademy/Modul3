using System;
using System.Collections.Generic;

namespace ASP_Test_2.Model
{
    public partial class Order
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime Created { get; set; }

        public virtual People Person { get; set; }
    }
}
