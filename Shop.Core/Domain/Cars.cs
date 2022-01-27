using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Domain
{
    public class Cars
    {
        public Guid? Id { get; set; }
        public string Mudel { get; set; }
        public string Seeria { get; set; }
        public double Hind { get; set; }
        public double Kaal { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public IEnumerable<ExistingFilePath> ExistingFilePaths { get; set; }
    = new List<ExistingFilePath>();
    }
}
