using System;
using System.Collections.Generic;

namespace CRUDØvelse.Models
{
    public partial class People
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; }
        public int? Age { get; set; }
        public string Mother { get; set; }
        public string Father { get; set; }
        public int Id { get; set; }
    }
}
