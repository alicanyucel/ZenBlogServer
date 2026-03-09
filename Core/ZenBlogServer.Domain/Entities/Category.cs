using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using ZenBlogServer.Domain.Entities.Common;

namespace ZenBlogServer.Domain.Entities;

public class Category:BaseEntity
{
    public string Name { get; set; }
    public IList<Blog> Blogs { get; set; }
}
