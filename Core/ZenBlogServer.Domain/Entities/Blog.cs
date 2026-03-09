using System;
using System.Collections.Generic;
using System.Text;
using ZenBlogServer.Domain.Entities.Common;

namespace ZenBlogServer.Domain.Entities;

public class Blog:BaseEntity
{
    public string Title { get; set; }
    public string CoverImage { get; set; }
    public string BlogImage { get; set; }
    public string Description { get; set; }
    private Guid CategoryId { get; set; }
    public Category Category { get; set; }

}
