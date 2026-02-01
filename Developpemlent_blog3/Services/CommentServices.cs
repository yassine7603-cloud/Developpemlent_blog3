using Developpemlent_blog3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Developpemlent_blog3.Services
{
    internal class CommentServices
    {
        private readonly List<Comment> _comment = new();
        private int _nextId = 1;

        public Comment Create(int articleId, string author, string content)
        {
            return new Comment
            {
                Id = _nextId++,
                ArticleId = articleId,
                Author = author,
                Content = content,
                CreatedAt = DateTime.Now
            };
        }
        public Comment? GetById(int id) => _comment.FirstOrDefault(a => a.Id == id);
        public bool Delete(int id) => _comment.RemoveAll(a => a.Id == id) > 0;

    }
}
