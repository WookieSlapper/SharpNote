using System;
using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    class BlogEntry
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Author Author { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
