﻿// <auto-generated />
using System;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject.Models.Activities", b =>
                {
                    b.Property<int>("ActivitiesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgeRange");

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<int>("ScheduleId");

                    b.Property<DateTime>("ScheduleTime");

                    b.Property<int>("Score");

                    b.HasKey("ActivitiesId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Activities");

                    b.HasData(
                        new { ActivitiesId = 1, AgeRange = "3-6", Description = "do stuff", Duration = 20, ScheduleId = 1, ScheduleTime = new DateTime(2019, 11, 21, 8, 18, 17, 937, DateTimeKind.Local), Score = 200 }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.ActivityPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<int>("Score");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("ActivityPlans");

                    b.HasData(
                        new { Id = 1, Description = "do the stuff", Duration = 20, Score = 200, Title = "Test Activity" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Milestones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgeRange");

                    b.Property<string>("Milestone");

                    b.Property<int>("SkillsId");

                    b.HasKey("Id");

                    b.HasIndex("SkillsId");

                    b.ToTable("Milestones");

                    b.HasData(
                        new { Id = 1, AgeRange = "3-6", Milestone = "Test Milestone", SkillsId = 0 }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedule");

                    b.HasData(
                        new { ScheduleId = 1 }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgeRange");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new { Id = 1, AgeRange = "3-5", Description = "Children are born ready to learn a language, but they need to learn the language or languages that their family and environment use. Learning a language takes time, and children vary in how quickly they master milestones in language and speech development. Typically developing children may have trouble with some sounds, words, and sentences while they are learning. However, most children can use language easily around 5 years of age.", Name = "Speech" },
                        new { Id = 2, AgeRange = "3-5", Description = "This is the ability to use small muscles (fine motor), particularly in the hands, and large muscles (gross motor) in the body. Babies use fine motor skills to grasp objects. Toddlers and preschoolers use them to do things like hold utensils, work with objects, and draw. Babies use gross motor skills to sit up, roll over, and begin to walk. Older kids use them to do things like jump, run, and climb stairs.", Name = "Fine/Gross Motor Skills" },
                        new { Id = 3, AgeRange = "3-5", Description = "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth. Children grow and learn best in a safe environment where they are protected from neglect and from extreme or chronic stress. External with plenty of opportunities to play and explore.", Name = "Cognitive Functionality" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.SkillsActivityPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityPlanId");

                    b.Property<int>("SkillsId");

                    b.HasKey("Id");

                    b.HasIndex("ActivityPlanId");

                    b.HasIndex("SkillsId");

                    b.ToTable("SkillsActivityPlans");

                    b.HasData(
                        new { Id = 1, ActivityPlanId = 1, SkillsId = 1 }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Activities", b =>
                {
                    b.HasOne("FinalProject.Models.Schedule", "Schedule")
                        .WithMany("Activities")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalProject.Models.Milestones", b =>
                {
                    b.HasOne("FinalProject.Models.Skills", "Skills")
                        .WithMany("Milestones")
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalProject.Models.SkillsActivityPlan", b =>
                {
                    b.HasOne("FinalProject.Models.ActivityPlan", "ActivityPlan")
                        .WithMany("SkilsActivityPlans")
                        .HasForeignKey("ActivityPlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalProject.Models.Skills", "Skills")
                        .WithMany("SkilsActivityPlans")
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
