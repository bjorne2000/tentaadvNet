using BackendHamster.Object;
using Microsoft.EntityFrameworkCore;
using System;

namespace BackendHamster
{
    public class DbContextHamster :DbContext
    {
        public virtual DbSet<Hamster> hamsters { get; set; }
        public virtual DbSet<Cage> cages { get; set; }
        public virtual DbSet<Motionsyta> motionsyta { get; set; }
        public virtual DbSet<AktivityLogg> logg { get; set; }
        public virtual DbSet<CageBuddies> cageBuddies { get; set; }
        public virtual DbSet<Aktivities> aktiviteter { get; set; }
        public virtual DbSet<MotionsBatch> motionsBatch { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=LAPTOP-6GH4TEP5\SQLEXPRESS;Database=advBjornEklund;Trusted_Connection=True;MultipleActiveResultSets=true");
                optionsBuilder.UseLazyLoadingProxies();
            }
        }
    }
}
