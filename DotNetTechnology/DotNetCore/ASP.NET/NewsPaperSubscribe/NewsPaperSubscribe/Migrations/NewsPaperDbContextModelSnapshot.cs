using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NewsPaperSubscribe.Models;

namespace NewsPaperSubscribe.Migrations
{
    [DbContext(typeof(NewsPaperDbContext))]
    partial class NewsPaperDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsPaperSubscribe.Models.ClientDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Client")
                        .IsRequired();

                    b.Property<string>("Company")
                        .IsRequired();

                    b.Property<bool>("NewsPaper");

                    b.HasKey("Id");

                    b.ToTable("ClientDetails");
                });
        }
    }
}
