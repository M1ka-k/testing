using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing.Models
{
    internal class Project
    {
        public string Name { get; set; }
        public List<Yarn> Yarns { get; set; } = new List<Yarn>();
        public int hookSize { get; set; }
        public int Yartage { get; set; }
        public bool IsFreeHand {  get; set; }
    }
}
