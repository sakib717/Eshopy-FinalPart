namespace Eshopy.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EshopyContext : DbContext
    {
        public EshopyContext()
            : base("name=EshopyConnection")
        {
        }

        public virtual DbSet<EshopyTypeModels> EshopyTypes { get; set; }
        public virtual DbSet<EshopyItemModels> EshopyItems { get; set; }

    }
}
