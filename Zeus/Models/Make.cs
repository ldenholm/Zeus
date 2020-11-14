using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Zeus.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        // init of above prop is responsibility of this class, thats why we init in ctor

        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}
