using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Domain
{
    public class Comment
    {

        public string Text { get; set; }

        public int PostId { get; set; }
    }
}
