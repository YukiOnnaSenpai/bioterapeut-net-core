﻿// <auto-generated />
using System;
using BioterapeutDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(BioterapeutContext))]
    partial class BioterapeutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.ApplicationUser", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTimeCreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("IsActive")
                        .HasColumnType("smallint");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RefLocationIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RefLocationIdId");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.Appointment", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTimeCreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("IsActive")
                        .HasColumnType("smallint");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("RefLabelIdId")
                        .HasColumnType("int");

                    b.Property<int?>("RefLocationIdId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RefLabelIdId");

                    b.HasIndex("RefLocationIdId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.Label", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTimeCreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<short?>("IsActive")
                        .HasColumnType("smallint");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Label");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.LabelTranslation", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTimeCreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<short?>("IsActive")
                        .HasColumnType("smallint");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RefLabelIdId")
                        .HasColumnType("int");

                    b.Property<string>("TranslationValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RefLabelIdId");

                    b.ToTable("LabelTranslations");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.Location", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTimeCreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<short?>("IsActive")
                        .HasColumnType("smallint");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.Merchendise", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTimeCreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasStock")
                        .HasColumnType("bit");

                    b.Property<short?>("IsActive")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RefLabelIdId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RefLabelIdId");

                    b.ToTable("Merchendise");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.RelationUserAppointment", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttendanceStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTimeCreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<short?>("IsActive")
                        .HasColumnType("smallint");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("RefAppointmentIdId")
                        .HasColumnType("int");

                    b.Property<int?>("RefUserIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RefAppointmentIdId");

                    b.HasIndex("RefUserIdId");

                    b.ToTable("RelationUserAppointment");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.ApplicationUser", b =>
                {
                    b.HasOne("BioterapeutDAL.Models.Classes.Location", "RefLocationId")
                        .WithMany("Users")
                        .HasForeignKey("RefLocationIdId");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.Appointment", b =>
                {
                    b.HasOne("BioterapeutDAL.Models.Classes.Label", "RefLabelId")
                        .WithMany("Appointments")
                        .HasForeignKey("RefLabelIdId");

                    b.HasOne("BioterapeutDAL.Models.Classes.Location", "RefLocationId")
                        .WithMany("Appointments")
                        .HasForeignKey("RefLocationIdId");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.LabelTranslation", b =>
                {
                    b.HasOne("BioterapeutDAL.Models.Classes.Label", "RefLabelId")
                        .WithMany("LabelTranslations")
                        .HasForeignKey("RefLabelIdId");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.Merchendise", b =>
                {
                    b.HasOne("BioterapeutDAL.Models.Classes.Label", "RefLabelId")
                        .WithMany("Merchendises")
                        .HasForeignKey("RefLabelIdId");
                });

            modelBuilder.Entity("BioterapeutDAL.Models.Classes.RelationUserAppointment", b =>
                {
                    b.HasOne("BioterapeutDAL.Models.Classes.Appointment", "RefAppointmentId")
                        .WithMany("RelationUserAppointments")
                        .HasForeignKey("RefAppointmentIdId");

                    b.HasOne("BioterapeutDAL.Models.Classes.ApplicationUser", "RefUserId")
                        .WithMany("RelationUserAppointments")
                        .HasForeignKey("RefUserIdId");
                });
#pragma warning restore 612, 618
        }
    }
}
