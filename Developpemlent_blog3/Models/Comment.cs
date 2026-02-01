using System;
using System.Collections.Generic;
using System.Text;

namespace Developpemlent_blog3.Models
{
    internal class Comment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public override string ToString() =>
            $"[Com {Id}] De {Author} le {CreatedAt:dd/MM/yyyy HH:mm} : {Content}";

    }
}
