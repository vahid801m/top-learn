using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLayer.Entities.Wallet;
using System.Linq;
using TopLearn.DataLeyer.Entities.Permissions;

using TopLearn.DataLayer.Entities.Course;
using TopLearn.DataLeyer.Entities.Order;
using TopLearn.DataLeyer.Entities.User;
using TopLearn.DataLeyer.Entities.Course;
using TopLearn.DataLeyer.Entities.Question;

namespace TopLearn.DataLayer.Context
{
    public class TopLearnContext : DbContext
    {

        public TopLearnContext(DbContextOptions<TopLearnContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
             .SelectMany(t => t.GetForeignKeys())
             .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;




            modelBuilder.Entity<User>().HasQueryFilter(p => !p.IsDelete);

            modelBuilder.Entity<Role>().HasQueryFilter(p => !p.IsDelete);

            modelBuilder.Entity<CourseGroup>().HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<Course>()

             .HasOne<CourseGroup>(f => f.CourseGroup)

             .WithMany(g => g.Courses)

             .HasForeignKey(f => f.GroupId);

            modelBuilder.Entity<Course>()

            .HasOne<CourseGroup>(f => f.Group)

              .WithMany(g => g.SubGroup)

               .HasForeignKey(f => f.SubGroup);








            base.OnModelCreating(modelBuilder);
        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        #endregion

        #region Wallet

        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        public List<UserRole> getRoles()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Permission
        public DbSet<Permission> Permission { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        #endregion

        #region Course

        public DbSet<CourseGroup> CourseGroups { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseComment> CourseComments { get; set; }
        public DbSet<CourseEpisode> CourseEpizodes { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<CourseStatus> CourseStatuses { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        public DbSet<CourseVote> CourseVotes { get; set; }
        #endregion

        #region Order

        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        #endregion


        #region Furom

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }

        #endregion
    }
}
