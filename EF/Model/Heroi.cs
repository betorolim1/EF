using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF.Model
{
    public class Heroi
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public Batalha Batalha { get; set; }
        public int BatalhaId { get; set; }
    }
}
