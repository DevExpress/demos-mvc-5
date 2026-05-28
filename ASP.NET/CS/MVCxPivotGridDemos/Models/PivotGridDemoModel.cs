using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DevExpress.Web.Demos;

namespace PivotGridDemoModel {
    public partial class PivotGridDemoContext : ContextBase {
        static PivotGridDemoContext() { Database.SetInitializer<PivotGridDemoContext>(null); }
        public PivotGridDemoContext() : base("PivotGridServerModeDemoConnectionString") { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesPerson> SalesPeople { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new SaleMap());
            modelBuilder.Configurations.Add(new SalesPersonMap());
        }
    }

    public class Category {
        public Category() {
            Products = new List<Product>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
    public class CategoryMap : EntityTypeConfiguration<Category> {
        public CategoryMap() {
            // Primary Key
            this.HasKey(t => t.CategoryID);

            // Properties
            this.Property(t => t.CategoryName).HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Categories");
            this.Property(t => t.CategoryID).HasColumnName("OID");
        }
    }

    public class Customer {
        public Customer() {
            Orders = new List<Order>();
        }

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
    public class CustomerMap : EntityTypeConfiguration<Customer> {
        public CustomerMap() {
            // Primary Key
            this.HasKey(t => t.CustomerID);

            // Properties
            this.Property(t => t.CustomerName).HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customers");
            this.Property(t => t.CustomerID).HasColumnName("OID");
        }
    }

    public class Order {
        public Order() {
            Sales = new List<Sale>();
        }

        public int OrderID { get; set; }
        public int? SalesPersonID { get; set; }
        public int? CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
    public class OrderMap : EntityTypeConfiguration<Order> {
        public OrderMap() {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Table & Column Mappings
            this.ToTable("Orders");
            this.Property(t => t.OrderID).HasColumnName("OID");
            this.Property(t => t.CustomerID).HasColumnName("Customer");
            this.Property(t => t.SalesPersonID).HasColumnName("SalesPerson");

            // Relationships
            this.HasOptional(t => t.SalesPerson)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.SalesPersonID);
            this.HasOptional(t => t.Customer)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.CustomerID);
        }
    }

    public class Product {
        public Product() {
            Sales = new List<Sale>();
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
    public class ProductMap : EntityTypeConfiguration<Product> {
        public ProductMap() {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductName).HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Products");
            this.Property(t => t.ProductID).HasColumnName("OID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.CategoryID).HasColumnName("Category");

            // Relationships
            this.HasOptional(t => t.Category)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CategoryID);
        }
    }

    public class Sale {
        public int SaleID { get; set; }
        public int? OrderID { get; set; }
        public int? ProductID { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
    public class SaleMap : EntityTypeConfiguration<Sale> {
        public SaleMap() {
            // Primary Key
            this.HasKey(t => t.SaleID);

            // Properties
            this.Property(t => t.UnitPrice).HasColumnType("money");

            // Table & Column Mappings
            this.ToTable("Sales");
            this.Property(t => t.SaleID).HasColumnName("OID");
            this.Property(t => t.ProductID).HasColumnName("Product");
            this.Property(t => t.OrderID).HasColumnName("Order");

            // Relationships
            this.HasOptional(t => t.Order)
                .WithMany(t => t.Sales)
                .HasForeignKey(d => d.OrderID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.Sales)
                .HasForeignKey(d => d.ProductID);
        }
    }

    public class SalesPerson {
        public SalesPerson() {
            Orders = new List<Order>();
        }

        public int SalesPersonID { get; set; }
        public string SalesPersonName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
    public class SalesPersonMap : EntityTypeConfiguration<SalesPerson> {
        public SalesPersonMap() {
            // Primary Key
            this.HasKey(t => t.SalesPersonID);

            // Properties
            this.Property(t => t.SalesPersonName).HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SalesPeople");
            this.Property(t => t.SalesPersonID).HasColumnName("OID");
        }
    }
}

