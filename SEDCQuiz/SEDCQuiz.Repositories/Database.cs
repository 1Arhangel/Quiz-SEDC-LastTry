using SEDCQuiz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDCQuiz.Repositories
{
    public class Database : DbContext
    {
        public Database() : base("Name=DefaultConnection")
        { }
        
        public DbSet<Association> Association { get; set; }
        public DbSet<AssociationColumn> AssociationColumn { get; set; }
        public DbSet<ConnectionPairs> ConnectionPairs { get; set; }
        public DbSet<ConnectionSet> ConnectionSet { get; set; }
        public DbSet<Sign> Sign { get; set; }
        public DbSet<YesNo> YesNo { get; set; }
    }
}
