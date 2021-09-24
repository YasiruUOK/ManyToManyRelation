﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyRelation.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<PostTag> PostTags { get; set; }
    }
}
