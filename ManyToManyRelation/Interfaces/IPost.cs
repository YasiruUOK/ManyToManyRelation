using ManyToManyRelation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyRelation.Interfaces
{
    public interface IPost
    {
        List<Post> GetAll();
        Post GetById(string Id);
        void Insert(Post post);
        void Update(Post post);
        void Delete(Post post);
    }
}
