using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    class Comment
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Author Author { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
