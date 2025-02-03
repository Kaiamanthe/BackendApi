using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackendApi.Models;
using System.ComponentModel.DataAnnotations;

namespace BackendApi.Data
{
    public class BackendApiContext : DbContext
    {
        public BackendApiContext (DbContextOptions<BackendApiContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StaticContent>().HasData(
                    new StaticContent
                    {
                        ContentID = 1,
                        Product = "Snuggy",
                        Seller = "Donald",
                        ProductDes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum."
                    },
                    new StaticContent
                    {
                        ContentID = 2,
                        Product = "Chess",
                        Seller = "Randy",
                        ProductDes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum."
                    },
                    new StaticContent
                    {
                        ContentID = 3,
                        Product = "Basketball",
                        Seller = "Tyson",
                        ProductDes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum."
                    }
                );

            modelBuilder.Entity<BusinessContactDetails>().HasData(
                    new BusinessContactDetails
                    {
                        ContactID = 1,
                        ContactName = "Rogger",
                        Address = "16th Court Dr",
                        PostalCode = "98501",
                        Country = "US",
                        City = "Olympia",
                        Phone = "222-555-6666"
                    },
                    new BusinessContactDetails
                    {
                        ContactID = 2,
                        ContactName = "Alice",
                        Address = "16th Court Dr",
                        PostalCode = "98501",
                        Country = "US",
                        City = "Olympia",
                        Phone = "222-555-6666"
                    },
                    new BusinessContactDetails
                    {
                        ContactID = 3,
                        ContactName = "Bob",
                        Address = "16th Court Dr",
                        PostalCode = "98501",
                        Country = "US",
                        City = "Olympia",
                        Phone = "222-555-6666"
                    }

                );

            modelBuilder.Entity<DynamicContent>().HasData(
                    new DynamicContent
                    {
                        PostId = 1,
                        Title = "What does the fox say?",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum.",
                        Author = "Robert"
                    },
                    new DynamicContent
                    {
                        PostId = 2,
                        Title = "Top 10 Chess Duels",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum.",
                        Author = "Dillon"
                    },
                    new DynamicContent
                    {
                        PostId = 3,
                        Title = "Basketball Top Basket",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum.",
                        Author = "Tyler"
                    }
                );
            modelBuilder.Entity<FeedbackData>().HasData(
                    new FeedbackData
                    {
                        FeedbackId = 1,
                        Blogger = "Tyler",
                        Feedback = "Robert",
                        PublishDate = "11-15-22"
                    },
                    new FeedbackData
                    {
                        FeedbackId = 2,
                        Blogger = "Alice",
                        Feedback = "Donald",
                        PublishDate = "11-15-22"
                    },
                    new FeedbackData
                    {
                        FeedbackId = 3,
                        Blogger = "Devin",
                        Feedback = "Rogger",
                        PublishDate = "11-15-22"
                    }

                );


        }
        public DbSet<BackendApi.Models.StaticContent> StaticContent { get; set; } = default!;
        public DbSet<BackendApi.Models.BusinessContactDetails> BusinessContactDetails { get; set; } = default!;
        public DbSet<BackendApi.Models.DynamicContent> DynamicContent { get; set; } = default!;
        public DbSet<BackendApi.Models.FeedbackData> FeedbackData { get; set; } = default!;
    }
}
