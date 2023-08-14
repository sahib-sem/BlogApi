using BlogApi.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Domain
{
    public class Post : BaseEntity
    {
        public Post() { 
            Comments = new HashSet<Comment>();        
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
