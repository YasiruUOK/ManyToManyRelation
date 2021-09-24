using ManyToManyRelation.Data;
using ManyToManyRelation.Interfaces;
using ManyToManyRelation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyRelation.Repositories
{
    public class PostRepo : IPost
    {
        private readonly ManytoManyContext _context;
        public PostRepo(ManytoManyContext context)
        {
            _context = context;
        }
        public void Delete(Post post)
        {
            _context.Posts.Remove(post);
        }

        public List<Post> GetAll()
        {
            return _context.Posts.ToList();
        }

        public Post GetById(string Id)
        {
            return _context.Posts.FirstOrDefault(x => x.Id == Id);
        }

        public void Insert(Post post)
        {
            _context.Posts.Add(post);
        }

        public void Update(Post post)
        {
            _context.Posts.Update(post);
        }
    }
}
