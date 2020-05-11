namespace GestionCommercial.entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelGestionCommercial : DbContext
    {
        public ModelGestionCommercial()
            : base("name=ModelGestionCommercial")
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
