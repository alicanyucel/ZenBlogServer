using System;
using System.Collections.Generic;
using System.Text;
using ZenBlogServer.Domain.Entities.Common;

namespace ZenBlogServer.Domain.Entities;

public class Social:BaseEntity
{
   public string Title { get; set; } 
   public string Url { get; set; }
   public string Icon { get; set; }

}
