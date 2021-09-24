using ManyToManyRelation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyRelation.Interfaces
{
    public interface ITag
    {
        List<Tag> GetAll();
        Tag GetById(string Id);
        void Insert(Tag tag);
        void Update(Tag tag);
        void Delete(Tag tag);
    }
}
