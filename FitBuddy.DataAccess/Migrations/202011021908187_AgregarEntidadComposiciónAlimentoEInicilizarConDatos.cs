namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarEntidadComposiciónAlimentoEInicilizarConDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComposiciónAlimento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Alimento = c.String(),
                        Calorías = c.Single(nullable: false),
                        ProteínaEnGramos = c.Single(nullable: false),
                        GrasasEnGramos = c.Single(nullable: false),
                        ChoDEnGramos = c.Single(nullable: false),
                        ChoTEnGramos = c.Single(nullable: false),
                        FibraTEnGramos = c.Single(nullable: false),
                        CalcioEnMiligramos = c.Single(nullable: false),
                        FósforoEnMiligramos = c.Single(nullable: false),
                        HierroEnMiligramos = c.Single(nullable: false),
                        MagnesioEnMiligramos = c.Single(nullable: false),
                        ZincEnMiligramos = c.Single(nullable: false),
                        CobreEnMiligramos = c.Single(nullable: false),
                        SodioEnMiligramos = c.Single(nullable: false),
                        PotasioEnMiligramos = c.Single(nullable: false),
                        VitaminaAEr = c.Single(nullable: false),
                        BetaCarotenoEt = c.Single(nullable: false),
                        TiaminaEnMiligramos = c.Single(nullable: false),
                        RiboflavinaEnMiligramos = c.Single(nullable: false),
                        NiacinaEnMiligramos = c.Single(nullable: false),
                        VitaminaB6EnMiligramos = c.Single(nullable: false),
                        ÁcidoAscEnMiligramos = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ComposiciónAlimento");
        }
    }
}
