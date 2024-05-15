using Unitok_progect.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitok_progect.Domain.Entities
{
    public class StaticFile: BaseEntity
    {
        public StaticFile(string path, string name)
        {
            Path = path;
            Name = name;
            Extension = name.Split('.').LastOrDefault();
        }

        public StaticFile() { }
        public string Path { get; set; }
        public string Name { get; set; }
        public string? Extension { get; private set; }


        // relationships
        public NftCard Card { get; set; }
    }
}
