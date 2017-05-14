namespace SharePointProject2.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TPP : DbContext
    {
        // Контекст настроен для использования строки подключения "TPP" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "SharePointProject2.TPP" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "TPP" 
        // в файле конфигурации приложения.
        public TPP()
            : base("TPP")
        {
            //Database.SetInitializer<TPP>(null);
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<RouteCar> RouteCars { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<TechnologicalProcesses> TechnologicalProcesseses { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Transition> Transitions { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Rigging> Riggings { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

}