#if !NET
namespace DevExpress.MVVM.Demos.DataBase {
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.SQLite;
    using System.IO;
    using DevExpress.Internal;
    using DevExpress.MVVM.Demos.Model;

    public class ExpensesDbContext : DbContext {
        public ExpensesDbContext() : base(CreateConnection(), true) { }
        public ExpensesDbContext(string connectionString) : base(connectionString) { }
        public ExpensesDbContext(DbConnection connection) : base(connection, true) { }
        static ExpensesDbContext() {
            Database.SetInitializer<ExpensesDbContext>(null);
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        //
        static string filePath;
        static DbConnection CreateConnection() {
            filePath = filePath ?? DataDirectoryHelper.GetFile("expenses.sqlite3");
            try { File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.ReadOnly); }
            catch { }
            var connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection();
            connection.ConnectionString = new SQLiteConnectionStringBuilder { DataSource = filePath }.ConnectionString;
            return connection;
        }
    }
}
#else
namespace DevExpress.MVVM.Demos.DataBase {
    using System.IO;
    using DevExpress.Internal;
    using DevExpress.MVVM.Demos.Model;
    using Microsoft.EntityFrameworkCore;

    public class ExpensesDbContext : DbContext {
        public ExpensesDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder) {
#pragma warning disable CS0436 // conflict with shared class from DevExpress.DemoData.v25.1
            string dbPath = DataDirectoryHelper.GetFile("expenses.sqlite3");
#pragma warning restore CS0436
            try { File.SetAttributes(dbPath, File.GetAttributes(dbPath) & ~FileAttributes.ReadOnly); }
            catch { }
            optionbuilder.UseLazyLoadingProxies().UseSqlite(@"Data Source=" + dbPath);
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        //
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            //https://docs.microsoft.com/en-us/ef/core/providers/sqlite/limitations
            modelBuilder.Entity<Account>()
                .Property(e => e.Amount)
                .HasConversion<double>();
            modelBuilder.Entity<Transaction>()
                .Property(e => e.Amount)
                .HasConversion<double>();
        }
    }
}
#endif
