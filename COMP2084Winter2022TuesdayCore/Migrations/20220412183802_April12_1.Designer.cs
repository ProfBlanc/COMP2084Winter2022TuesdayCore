// <auto-generated />
using COMP2084Winter2022TuesdayCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMP2084Winter2022TuesdayCore.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220412183802_April12_1")]
    partial class April12_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COMP2084Winter2022TuesdayCore.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Leader")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("CountryID");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("COMP2084Winter2022TuesdayCore.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeAge")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmployeePosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("EmployeeID");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("COMP2084Winter2022TuesdayCore.Models.Folder", b =>
                {
                    b.Property<int>("FolderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FolderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.HasKey("FolderID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Folder");
                });

            modelBuilder.Entity("COMP2084Winter2022TuesdayCore.Models.Owner", b =>
                {
                    b.Property<int>("OwnerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerID");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("COMP2084Winter2022TuesdayCore.Models.Folder", b =>
                {
                    b.HasOne("COMP2084Winter2022TuesdayCore.Models.Owner", "Owner")
                        .WithMany("Folders")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("COMP2084Winter2022TuesdayCore.Models.Owner", b =>
                {
                    b.Navigation("Folders");
                });
#pragma warning restore 612, 618
        }
    }
}
