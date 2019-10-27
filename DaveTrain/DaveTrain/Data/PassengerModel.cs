using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaveTrain.Data
{
    public class PassengerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dayvoted { get; set; }

        public string VotedFor { get; set; }

        public bool Isvoted { get; set; }
    }
}
