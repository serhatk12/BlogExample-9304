//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogExample.Data.Orm
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiteMenu
    {
        public SiteMenu()
        {
            this.Blogs = new HashSet<Blog>();
            this.Categories = new HashSet<Category>();
        }
    
        public int Id { get; set; }
        public int LangId { get; set; }
        public int TopMenuId { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public string PageSlug { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual Language Language { get; set; }
    }
}
