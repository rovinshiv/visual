// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rovin.Data;

#nullable disable

namespace rovin.Migrations
{
    [DbContext(typeof(HotelListingsDbContext))]
    partial class HotelListingsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("rovin.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shortname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "India",
                            Shortname = "IN"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jamaica",
                            Shortname = "JM"
                        },
                        new
                        {
                            Id = 3,
                            Name = "USA",
                            Shortname = "US"
                        });
                });

            modelBuilder.Entity("rovin.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "No 8 India",
                            CountryId = 3,
                            Name = "Park",
                            Rating = 3.5
                        },
                        new
                        {
                            Id = 2,
                            Address = "No 32 India",
                            CountryId = 2,
                            Name = "Taj",
                            Rating = 4.0999999999999996
                        },
                        new
                        {
                            Id = 3,
                            Address = "No 33 India",
                            CountryId = 1,
                            Name = "Saravana",
                            Rating = 4.7000000000000002
                        });
                });

            modelBuilder.Entity("rovin.Data.Hotel", b =>
                {
                    b.HasOne("rovin.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("rovin.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
