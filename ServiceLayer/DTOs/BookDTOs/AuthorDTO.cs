using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.BookDTOs
{
    public class AuthorDTO
    {
        // please remove one side of all many to many if not used
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
