using Developpemlent_blog3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Developpemlent_blog3.Services
{
    internal class ArticleServices
    {
        private readonly List<Article> _articles = new();
        private int _nextId = 1;

        public List<Article> GetAll() => _articles;

        public Article? GetById(int id) => _articles.FirstOrDefault(a => a.Id == id);

        public void Create(string title, string content)
        {
            _articles.Add(new Article
            {
                Id = _nextId++,
                Title = title,
                Content = content,
                CreatedAt = DateTime.Now
            });
        }

        public bool Update(int id, string title, string content)
        {
            var art = GetById(id);
            if (art == null) return false;
            art.Title = title;
            art.Content = content;
            art.UpdatedAt = DateTime.Now;
            return true;
        }

        public bool Delete(int id) => _articles.RemoveAll(a => a.Id == id) > 0;

    }
}
    

