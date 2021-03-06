using Microsoft.EntityFrameworkCore;

namespace ApplicationDevGroupCW.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<DVDCategory> DVDCategory { get; set; }
        public DbSet<DVDCopy> DVDCopy { get; set; }
        public DbSet<DVDTitle> DVDTitle { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<LoanType> LoanType { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<MembershipCategory> MembershipCategory { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<Studio> Studio { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<CastMember> CastMembers { get; set; }
    }
}
