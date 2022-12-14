// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PetCity.Migrations
{
    [DbContext(typeof(PetCityContext))]
    partial class PetCityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.1.22076.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Visibility")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "meryem.dogan@sahabt.com",
                            IsBlocked = true,
                            Password = "123123",
                            Visibility = true
                        },
                        new
                        {
                            Id = 2,
                            Email = "galipcan.karaaslan@sahabt.com",
                            IsBlocked = true,
                            Password = "555555",
                            Visibility = true
                        });
                });

            modelBuilder.Entity("AccountRole", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("AccountId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Account_Role", (string)null);
                });

            modelBuilder.Entity("Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OpenAddress1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OpenAddress2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("StateId");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 2,
                            CountryId = 1,
                            DistrictId = 3,
                            Name = "Adems",
                            OpenAddress1 = "bagcilar sok mahalllesi",
                            OpenAddress2 = "caminin arkasi"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 6,
                            CountryId = 4,
                            DistrictId = 11,
                            Name = "Hayris",
                            OpenAddress1 = "Pendik sok mahalllesi",
                            OpenAddress2 = "caminin karsisi"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 4,
                            CountryId = 2,
                            DistrictId = 8,
                            Name = "Muhammed",
                            OpenAddress1 = "Bahçelievler sok mahalllesi",
                            OpenAddress2 = "kepacinin karsisi",
                            StateId = 2
                        },
                        new
                        {
                            Id = 4,
                            CityId = 5,
                            CountryId = 3,
                            DistrictId = 10,
                            Name = "fatihs",
                            OpenAddress1 = "sıcak denizler",
                            OpenAddress2 = "bir tatil yeri",
                            StateId = 3
                        },
                        new
                        {
                            Id = 5,
                            CityId = 1,
                            CountryId = 1,
                            DistrictId = 1,
                            Name = "Ademiş",
                            OpenAddress1 = "bagcilar  iş sok mahalllesi",
                            OpenAddress2 = "caminin arkasi"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 2,
                            CountryId = 1,
                            DistrictId = 4,
                            Name = "Hayri iş",
                            OpenAddress1 = "İş adresi sk mahalllesi",
                            OpenAddress2 = " sahabt plaza"
                        });
                });

            modelBuilder.Entity("Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pro Plan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pro Line"
                        });
                });

            modelBuilder.Entity("BrandSupplier", b =>
                {
                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("SuppliersId")
                        .HasColumnType("int");

                    b.HasKey("BrandId", "SuppliersId");

                    b.HasIndex("SuppliersId");

                    b.ToTable("BrandSupplier");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cat Food"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dog Food"
                        });
                });

            modelBuilder.Entity("City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Istanbul"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 2,
                            Name = "New York City",
                            StateId = 1
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            Name = "Los Angeles",
                            StateId = 2
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 3,
                            Name = "Munich",
                            StateId = 3
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 4,
                            Name = "Londra"
                        });
                });

            modelBuilder.Entity("Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "BlaBla Sirketi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BlaBlaBla Sirketi"
                        });
                });

            modelBuilder.Entity("Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Code")
                        .HasColumnType("int");

                    b.Property<bool>("HasState")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = 1,
                            HasState = false,
                            Name = "Turkey"
                        },
                        new
                        {
                            Id = 2,
                            Code = 2,
                            HasState = true,
                            Name = "Usa"
                        },
                        new
                        {
                            Id = 3,
                            Code = 3,
                            HasState = true,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 4,
                            Code = 4,
                            HasState = false,
                            Name = "England"
                        });
                });

            modelBuilder.Entity("District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("District");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Kecioren"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Name = "Mamak"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Name = "Bagcılar"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Name = "Besiktas"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 3,
                            Name = "Manhattan"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            Name = "Brooklyn"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 4,
                            Name = "Hollywood"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 4,
                            Name = "Santa Monica"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 5,
                            Name = "Altstadt"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 5,
                            Name = "Neuhausen"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 6,
                            Name = "Greenwich"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 6,
                            Name = "Soho"
                        });
                });

            modelBuilder.Entity("Incidence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("Visibility")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.HasIndex("UserId");

                    b.ToTable("Incidences");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int?>("HealthStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PetImageUrl")
                        .HasColumnType("longtext");

                    b.Property<int?>("SpeciesId")
                        .HasColumnType("int");

                    b.Property<int?>("SubSpeciesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("HealthStatusId");

                    b.HasIndex("SpeciesId");

                    b.HasIndex("SubSpeciesId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetGender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PetGenders");
                });

            modelBuilder.Entity("PetHealthStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PetHealthStatus");
                });

            modelBuilder.Entity("PetSpecies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PetSpecies");
                });

            modelBuilder.Entity("PetSubSpecies", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PetSubSpecies");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuantityPerUnit")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            CompanyId = 1,
                            Name = "Pro Plan Active",
                            QuantityPerUnit = 0,
                            UnitPrice = 15m,
                            UnitsInStock = 10
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            CategoryId = 2,
                            CompanyId = 2,
                            Name = "Pro Line Active",
                            QuantityPerUnit = 0,
                            UnitPrice = 10m,
                            UnitsInStock = 15
                        });
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "moderator"
                        });
                });

            modelBuilder.Entity("State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("State");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 2,
                            Name = "New York"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            Name = "California"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            Name = "Bavyera"
                        });
                });

            modelBuilder.Entity("Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<bool>("IsVisibility")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Rating")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("AddressId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AccountRole", b =>
                {
                    b.HasOne("Account", null)
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Address", b =>
                {
                    b.HasOne("City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("District");

                    b.Navigation("State");
                });

            modelBuilder.Entity("BrandSupplier", b =>
                {
                    b.HasOne("Brand", null)
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Supplier", null)
                        .WithMany()
                        .HasForeignKey("SuppliersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("City", b =>
                {
                    b.HasOne("Country", "Country")
                        .WithMany("city")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("State", "State")
                        .WithMany("city")
                        .HasForeignKey("StateId");

                    b.Navigation("Country");

                    b.Navigation("State");
                });

            modelBuilder.Entity("District", b =>
                {
                    b.HasOne("City", "City")
                        .WithMany("District")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Incidence", b =>
                {
                    b.HasOne("District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany("IncidenceList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.HasOne("PetGender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetHealthStatus", "HealthStatus")
                        .WithMany()
                        .HasForeignKey("HealthStatusId");

                    b.HasOne("PetSpecies", "Species")
                        .WithMany()
                        .HasForeignKey("SpeciesId");

                    b.HasOne("PetSubSpecies", "SubSpecies")
                        .WithMany()
                        .HasForeignKey("SubSpeciesId");

                    b.Navigation("Gender");

                    b.Navigation("HealthStatus");

                    b.Navigation("Species");

                    b.Navigation("SubSpecies");
                });

            modelBuilder.Entity("PetSubSpecies", b =>
                {
                    b.HasOne("PetSpecies", "Species")
                        .WithMany("SubSpecies")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Species");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.HasOne("Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company", "Company")
                        .WithMany("Products")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("State", b =>
                {
                    b.HasOne("Country", "Country")
                        .WithMany("state")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Supplier", b =>
                {
                    b.HasOne("Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Account");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("City", b =>
                {
                    b.Navigation("District");
                });

            modelBuilder.Entity("Company", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Country", b =>
                {
                    b.Navigation("city");

                    b.Navigation("state");
                });

            modelBuilder.Entity("PetSpecies", b =>
                {
                    b.Navigation("SubSpecies");
                });

            modelBuilder.Entity("State", b =>
                {
                    b.Navigation("city");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Navigation("IncidenceList");
                });
#pragma warning restore 612, 618
        }
    }
}
