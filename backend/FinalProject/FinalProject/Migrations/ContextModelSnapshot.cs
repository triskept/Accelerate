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
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject.Models.Activities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActivityTime");

                    b.Property<string>("AgeRange");

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<int>("ScheduleId");

                    b.Property<int>("Score");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Activities");

                    b.HasData(
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new { Id = 1, ActivityTime = new DateTime(2019, 11, 25, 7, 51, 38, 774, DateTimeKind.Local), AgeRange = "3-6", Description = "do stuff", Duration = 20, ScheduleId = 1, Score = 200 }
=======
                        new { Id = 1, ActivityTime = new DateTime(2019, 11, 26, 10, 27, 2, 582, DateTimeKind.Local), AgeRange = "3-6", Description = "do stuff", Duration = 20, ScheduleId = 1, Score = 200 }
>>>>>>> Stashed changes
=======

                        new { Id = 1, ActivityTime = new DateTime(2019, 11, 25, 19, 50, 26, 777, DateTimeKind.Local), AgeRange = "3-6", Description = "do stuff", Duration = 20, ScheduleId = 1, Score = 200 }

>>>>>>> 6aa6ff099fe16c82e22773d6a2d086c55b53aa48
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

                    b.Property<int>("SkillsId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("SkillsId");

                    b.ToTable("ActivityPlans");

                    b.HasData(
                        new { Id = 1, Description = "do the stuff", Duration = 20, Score = 200, SkillsId = 1, Title = "Test Activity" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Login");

                    b.HasData(
                        new { Id = 1, Password = "Password", UserName = "Username" }
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
                        new { Id = 1, AgeRange = "3", Milestone = "Follows Instructions with 2 or 3 steps", SkillsId = 1 },
                        new { Id = 2, AgeRange = "3", Milestone = "Can name most familiar things", SkillsId = 1 },
                        new { Id = 3, AgeRange = "3", Milestone = "Says first name, age, sex", SkillsId = 1 },
                        new { Id = 4, AgeRange = "3", Milestone = "Names a Friend", SkillsId = 1 },
                        new { Id = 5, AgeRange = "3", Milestone = "Understands words like 'in,' 'on,' and 'under'", SkillsId = 1 },
                        new { Id = 6, AgeRange = "3", Milestone = "Says words like 'I,' 'me,' 'we,' and 'you' and some plurals (cars, dogs, cats)", SkillsId = 1 },
                        new { Id = 7, AgeRange = "3", Milestone = "Talks well enough for strangers to understand most of the time", SkillsId = 1 },
                        new { Id = 8, AgeRange = "3", Milestone = "Carries on a conversation using 2 to 3 sentences", SkillsId = 1 },
                        new { Id = 9, AgeRange = "4", Milestone = "Knows some basic rules of grammar, such as correctly using 'he' and 'she'", SkillsId = 1 },
                        new { Id = 10, AgeRange = "4", Milestone = "Sings a song or poem from memory such as the 'itsy Bitsy Spider' or the 'Wheels on the Bus'", SkillsId = 1 },
                        new { Id = 11, AgeRange = "4", Milestone = "Tells Stories", SkillsId = 1 },
                        new { Id = 12, AgeRange = "4", Milestone = "Can say first and last name", SkillsId = 1 },
                        new { Id = 13, AgeRange = "5", Milestone = "Speaks very clearly", SkillsId = 1 },
                        new { Id = 14, AgeRange = "5", Milestone = "Tells a simple story using full sentences", SkillsId = 1 },
                        new { Id = 15, AgeRange = "5", Milestone = "Uses future tense; for example, 'Grandma will be here'", SkillsId = 1 },
                        new { Id = 16, AgeRange = "5", Milestone = "Says full name and address", SkillsId = 1 },
                        new { Id = 17, AgeRange = "5", Milestone = "Understands words like 'in,' 'on,' and 'under'", SkillsId = 1 },
                        new { Id = 18, AgeRange = "3", Milestone = "Can work toys with buttons, levers and moving parts", SkillsId = 2 },
                        new { Id = 19, AgeRange = "3", Milestone = "Turns book pages one at a time", SkillsId = 2 },
                        new { Id = 20, AgeRange = "3", Milestone = "Screws and unscrews jar lids or turns door handles", SkillsId = 2 },
                        new { Id = 21, AgeRange = "3", Milestone = "Plays make-believe with dolls, animals, and people", SkillsId = 2 },
                        new { Id = 22, AgeRange = "3", Milestone = "Understands what 'two' means", SkillsId = 2 },
                        new { Id = 23, AgeRange = "3", Milestone = "Copies a circle with pencil or crayon", SkillsId = 2 },
                        new { Id = 24, AgeRange = "4", Milestone = "Names some colors and some numbers", SkillsId = 2 },
                        new { Id = 25, AgeRange = "4", Milestone = "Starts to understand time", SkillsId = 2 },
                        new { Id = 26, AgeRange = "4", Milestone = "Remembers parts of a story", SkillsId = 2 },
                        new { Id = 27, AgeRange = "4", Milestone = "Understands the idea of 'same' and 'different'", SkillsId = 2 },
                        new { Id = 28, AgeRange = "4", Milestone = "Draws a person with 2 to 4 body parts", SkillsId = 2 },
                        new { Id = 29, AgeRange = "4", Milestone = "Uses scissors", SkillsId = 2 },
                        new { Id = 30, AgeRange = "4", Milestone = "Stars to copy some capital letters", SkillsId = 2 },
                        new { Id = 31, AgeRange = "4", Milestone = "Plays board or card games", SkillsId = 2 },
                        new { Id = 32, AgeRange = "4", Milestone = "Tells you what he or she thinks is going to happen next in a book", SkillsId = 2 },
                        new { Id = 33, AgeRange = "5", Milestone = "Names some colors and some numbers", SkillsId = 2 },
                        new { Id = 34, AgeRange = "5", Milestone = "Count 10 or more things", SkillsId = 2 },
                        new { Id = 35, AgeRange = "5", Milestone = "Can draw a person with at least 6 body parts", SkillsId = 2 },
                        new { Id = 36, AgeRange = "5", Milestone = "Can print some letters or numbers", SkillsId = 2 },
                        new { Id = 37, AgeRange = "5", Milestone = "Copies a triangle and other geometric shapes", SkillsId = 2 },
                        new { Id = 38, AgeRange = "5", Milestone = "Knows about things used everyday, like money and food", SkillsId = 2 },
                        new { Id = 39, AgeRange = "3", Milestone = "Runs Easily", SkillsId = 3 },
                        new { Id = 40, AgeRange = "3", Milestone = "Pedals a Tricycle (3-Wheel Bike)", SkillsId = 3 },
                        new { Id = 41, AgeRange = "3", Milestone = "Walks up and down stairs, one foot on each step", SkillsId = 3 },
                        new { Id = 42, AgeRange = "4", Milestone = "Hops and stands on one foot up to 2 seconds", SkillsId = 3 },
                        new { Id = 43, AgeRange = "4", Milestone = "Catches a bounced ball most of the time", SkillsId = 3 },
                        new { Id = 44, AgeRange = "4", Milestone = "Pours, cuts with supervision and mashes own food", SkillsId = 3 },
                        new { Id = 45, AgeRange = "5", Milestone = "Stands on one foot for 10 seconds or longer", SkillsId = 3 },
                        new { Id = 46, AgeRange = "5", Milestone = "Hops, may be able to skip", SkillsId = 3 },
                        new { Id = 47, AgeRange = "5", Milestone = "Can do a somersault", SkillsId = 3 },
                        new { Id = 48, AgeRange = "5", Milestone = "Uses a fork or spoon and sometimes a table knife", SkillsId = 3 },
                        new { Id = 49, AgeRange = "5", Milestone = "Can use the toilet on his or her own", SkillsId = 3 }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Profile");

                    b.HasData(
                        new { Id = 1, UserName = "User1" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProfileId");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.ToTable("Schedule");

                    b.HasData(
                        new { Id = 1, ProfileId = 1 }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgeRange");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new { Id = 1, AgeRange = "3-5", Description = "Children are born ready to learn a language, but they need to learn the language or languages that their family and environment use. Learning a language takes time, and children vary in how quickly they master milestones in language and speech development. Typically developing children may have trouble with some sounds, words, and sentences while they are learning. However, most children can use language easily around 5 years of age.", Name = "Speech" },
                        new { Id = 2, AgeRange = "3-5", Description = "This is the ability to use small muscles (fine motor), particularly in the hands, and large muscles (gross motor) in the body. Babies use fine motor skills to grasp objects. Toddlers and preschoolers use them to do things like hold utensils, work with objects, and draw. Babies use gross motor skills to sit up, roll over, and begin to walk. Older kids use them to do things like jump, run, and climb stairs.", Name = "Fine/Gross Motor Skills" },
                        new { Id = 3, AgeRange = "3-5", Description = "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth. Children grow and learn best in a safe environment where they are protected from neglect and from extreme or chronic stress. External with plenty of opportunities to play and explore.", Name = "Cognitive Functionality" }
=======
                        new { Id = 1, AgeRange = "3-5", Description = "Children are born ready to learn a language, but they need to learn the language or languages that their family and environment use. Learning a language takes time, and children vary in how quickly they master milestones in language and speech development. Typically developing children may have trouble with some sounds, words, and sentences while they are learning. However, most children can use language easily around 5 years of age.", Image = "/images/speech.jpg", Name = "Speech" },
                        new { Id = 2, AgeRange = "3-5", Description = "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth. Children grow and learn best in a safe environment where they are protected from neglect and from extreme or chronic stress. External with plenty of opportunities to play and explore.", Image = "/images/cognitive.jpg", Name = "Cognitive Functionality" },
                        new { Id = 3, AgeRange = "3-5", Description = "This is the ability to use small muscles (fine motor), particularly in the hands, and large muscles (gross motor) in the body. Babies use fine motor skills to grasp objects. Toddlers and preschoolers use them to do things like hold utensils, work with objects, and draw. Babies use gross motor skills to sit up, roll over, and begin to walk. Older kids use them to do things like jump, run, and climb stairs.", Image = "/images/motor.jpg", Name = "Fine/Gross Motor Skills" }
>>>>>>> Stashed changes
=======
                        new { Id = 1, AgeRange = "3-5", Description = "Children are born ready to learn a language, but they need to learn the language or languages that their family and environment use. Learning a language takes time, and children vary in how quickly they master milestones in language and speech development. Typically developing children may have trouble with some sounds, words, and sentences while they are learning. However, most children can use language easily around 5 years of age.", Image = "/images/speech.jpg", Name = "Speech" },
                        new { Id = 2, AgeRange = "3-5", Description = "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth. Children grow and learn best in a safe environment where they are protected from neglect and from extreme or chronic stress. External with plenty of opportunities to play and explore.", Image = "/images/cognitive.png", Name = "Cognitive Functionality" },
                        new { Id = 3, AgeRange = "3-5", Description = "This is the ability to use small muscles (fine motor), particularly in the hands, and large muscles (gross motor) in the body. Babies use fine motor skills to grasp objects. Toddlers and preschoolers use them to do things like hold utensils, work with objects, and draw. Babies use gross motor skills to sit up, roll over, and begin to walk. Older kids use them to do things like jump, run, and climb stairs.", Image = "/images/motor.jpg", Name = "Fine/Gross Motor Skills" }
>>>>>>> 6aa6ff099fe16c82e22773d6a2d086c55b53aa48
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Activities", b =>
                {
                    b.HasOne("FinalProject.Models.Schedule", "Schedule")
                        .WithMany("Activities")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalProject.Models.ActivityPlan", b =>
                {
                    b.HasOne("FinalProject.Models.Skills", "Skills")
                        .WithMany("ActivityPlans")
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalProject.Models.Milestones", b =>
                {
                    b.HasOne("FinalProject.Models.Skills", "Skills")
                        .WithMany("Milestones")
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalProject.Models.Schedule", b =>
                {
                    b.HasOne("FinalProject.Models.Profile", "profile")
                        .WithOne("schedule")
                        .HasForeignKey("FinalProject.Models.Schedule", "ProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
