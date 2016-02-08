using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Feedback.ORM;

namespace Feedback.ORM.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20160208235527_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Feedback.Domain.Form", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<DateTime>("StartDate");

                    b.Property<bool>("Status");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Feedback.Domain.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FormId");

                    b.Property<int>("VirtueId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Feedback.Domain.Response.FormResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("FormId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Feedback.Domain.Response.QuestionResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Evidencie");

                    b.Property<int?>("FormResponseId");

                    b.Property<int>("Percent");

                    b.Property<int>("QuestionId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Feedback.Domain.Virtue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Feedback.Domain.Question", b =>
                {
                    b.HasOne("Feedback.Domain.Form")
                        .WithMany()
                        .HasForeignKey("FormId");

                    b.HasOne("Feedback.Domain.Virtue")
                        .WithMany()
                        .HasForeignKey("VirtueId");
                });

            modelBuilder.Entity("Feedback.Domain.Response.FormResponse", b =>
                {
                    b.HasOne("Feedback.Domain.Form")
                        .WithMany()
                        .HasForeignKey("FormId");
                });

            modelBuilder.Entity("Feedback.Domain.Response.QuestionResponse", b =>
                {
                    b.HasOne("Feedback.Domain.Response.FormResponse")
                        .WithMany()
                        .HasForeignKey("FormResponseId");

                    b.HasOne("Feedback.Domain.Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");
                });
        }
    }
}
