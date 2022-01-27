using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Shop.Core.Dtos
{
    public class CarsDto
    {
        public Guid? Id { get; set; }
        public string Mudel { get; set; }
        public string Seeria { get; set; }
        public double Hind { get; set; }
        public double Kaal { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }


        public List<IFormFile> Files { get; set; }
        public IEnumerable<ExistingFilePathDto> ExistingFilePaths { get; set; }
            = new List<ExistingFilePathDto>();
    }
}
