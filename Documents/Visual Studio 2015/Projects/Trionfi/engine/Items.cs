using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripton { get; set; }

        public Items(int id, string name, string descripton)
        {
            Id = id;
            Name = name;
            Descripton = descripton;
        }
    }
}
