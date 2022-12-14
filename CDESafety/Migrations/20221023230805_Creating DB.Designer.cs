// <auto-generated />
using System;
using CDESafety.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CDESafety.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221023230805_Creating DB")]
    partial class CreatingDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AjudanteRelatorioDeServico", b =>
                {
                    b.Property<int>("AjudantesId")
                        .HasColumnType("int");

                    b.Property<int>("RelatorioDeServicosId")
                        .HasColumnType("int");

                    b.HasKey("AjudantesId", "RelatorioDeServicosId");

                    b.HasIndex("RelatorioDeServicosId");

                    b.ToTable("AjudanteRelatorioDeServico");
                });

            modelBuilder.Entity("CDESafety.Models.Aeronave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Prefixo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Aeronaves");
                });

            modelBuilder.Entity("CDESafety.Models.Ajudante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Ajudantes");
                });

            modelBuilder.Entity("CDESafety.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CDESafety.Models.Cultura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Culturas");
                });

            modelBuilder.Entity("CDESafety.Models.Equipamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("CDESafety.Models.Piloto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CodigoAnac")
                        .HasColumnType("int");

                    b.Property<int>("Comissao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pilotos");
                });

            modelBuilder.Entity("CDESafety.Models.Pista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Indicativo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pistas");
                });

            modelBuilder.Entity("CDESafety.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("CDESafety.Models.Propriedade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Propriedades");
                });

            modelBuilder.Entity("CDESafety.Models.RelatorioDeServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AeronaveId")
                        .HasColumnType("int");

                    b.Property<float>("AlturaVoo")
                        .HasColumnType("float");

                    b.Property<DateTime>("AplicacaoMatutinoFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("AplicacaoMatutinoInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("AplicacaoVespertinoFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("AplicacaoVespertinoInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Area")
                        .HasColumnType("float");

                    b.Property<float>("Carga")
                        .HasColumnType("float");

                    b.Property<string>("Combustivel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CombustivelOrigem")
                        .HasColumnType("int");

                    b.Property<int>("CombustivelQtd")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeEmissao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EngAgronomo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Faixa")
                        .HasColumnType("float");

                    b.Property<float>("HorimetroFinal")
                        .HasColumnType("float");

                    b.Property<float>("HorimetroInicial")
                        .HasColumnType("float");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("NumeroReceituario")
                        .HasColumnType("int");

                    b.Property<int>("PilotoId")
                        .HasColumnType("int");

                    b.Property<int>("PistaId")
                        .HasColumnType("int");

                    b.Property<float>("PrecoHora")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReceituarioEmissao")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Talhao")
                        .HasColumnType("float");

                    b.Property<int>("TemperaturaMatutinoFinal")
                        .HasColumnType("int");

                    b.Property<int>("TemperaturaMatutinoInicial")
                        .HasColumnType("int");

                    b.Property<int>("TemperaturaVespertinoFinal")
                        .HasColumnType("int");

                    b.Property<int>("TemperaturaVespertinoInicial")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Translado")
                        .HasColumnType("float");

                    b.Property<int>("UmidadeArMatutinoFinal")
                        .HasColumnType("int");

                    b.Property<int>("UmidadeArMatutinoInicial")
                        .HasColumnType("int");

                    b.Property<int>("UmidadeArVespertinoFinal")
                        .HasColumnType("int");

                    b.Property<int>("UmidadeArVespertinoInicial")
                        .HasColumnType("int");

                    b.Property<bool>("UsoGPS")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("Vazao")
                        .HasColumnType("float");

                    b.Property<int>("VentoMatutinoFinal")
                        .HasColumnType("int");

                    b.Property<int>("VentoMatutinoInicial")
                        .HasColumnType("int");

                    b.Property<int>("VentoVespertinoFinal")
                        .HasColumnType("int");

                    b.Property<int>("VentoVespertinoInicial")
                        .HasColumnType("int");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AeronaveId");

                    b.HasIndex("PilotoId");

                    b.HasIndex("PistaId");

                    b.ToTable("RelatorioDeServicos");
                });

            modelBuilder.Entity("CDESafety.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ClientePropriedade", b =>
                {
                    b.Property<int>("ClientesId")
                        .HasColumnType("int");

                    b.Property<int>("PropriedadesId")
                        .HasColumnType("int");

                    b.HasKey("ClientesId", "PropriedadesId");

                    b.HasIndex("PropriedadesId");

                    b.ToTable("ClientePropriedade");
                });

            modelBuilder.Entity("ClienteRelatorioDeServico", b =>
                {
                    b.Property<int>("ClientesId")
                        .HasColumnType("int");

                    b.Property<int>("RelatorioDeServicosId")
                        .HasColumnType("int");

                    b.HasKey("ClientesId", "RelatorioDeServicosId");

                    b.HasIndex("RelatorioDeServicosId");

                    b.ToTable("ClienteRelatorioDeServico");
                });

            modelBuilder.Entity("CulturaRelatorioDeServico", b =>
                {
                    b.Property<int>("CulturasId")
                        .HasColumnType("int");

                    b.Property<int>("RelatorioDeServicosId")
                        .HasColumnType("int");

                    b.HasKey("CulturasId", "RelatorioDeServicosId");

                    b.HasIndex("RelatorioDeServicosId");

                    b.ToTable("CulturaRelatorioDeServico");
                });

            modelBuilder.Entity("EquipamentoRelatorioDeServico", b =>
                {
                    b.Property<int>("EquipamentosId")
                        .HasColumnType("int");

                    b.Property<int>("RelatorioDeServicosId")
                        .HasColumnType("int");

                    b.HasKey("EquipamentosId", "RelatorioDeServicosId");

                    b.HasIndex("RelatorioDeServicosId");

                    b.ToTable("EquipamentoRelatorioDeServico");
                });

            modelBuilder.Entity("PropriedadeRelatorioDeServico", b =>
                {
                    b.Property<int>("PropriedadesId")
                        .HasColumnType("int");

                    b.Property<int>("RelatorioDeServicosId")
                        .HasColumnType("int");

                    b.HasKey("PropriedadesId", "RelatorioDeServicosId");

                    b.HasIndex("RelatorioDeServicosId");

                    b.ToTable("PropriedadeRelatorioDeServico");
                });

            modelBuilder.Entity("AjudanteRelatorioDeServico", b =>
                {
                    b.HasOne("CDESafety.Models.Ajudante", null)
                        .WithMany()
                        .HasForeignKey("AjudantesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDESafety.Models.RelatorioDeServico", null)
                        .WithMany()
                        .HasForeignKey("RelatorioDeServicosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CDESafety.Models.RelatorioDeServico", b =>
                {
                    b.HasOne("CDESafety.Models.Aeronave", "Aeronave")
                        .WithMany("RelatorioDeServicos")
                        .HasForeignKey("AeronaveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDESafety.Models.Piloto", "Piloto")
                        .WithMany("RelatorioDeServico")
                        .HasForeignKey("PilotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDESafety.Models.Pista", "Pista")
                        .WithMany("RelatorioDeServicos")
                        .HasForeignKey("PistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aeronave");

                    b.Navigation("Piloto");

                    b.Navigation("Pista");
                });

            modelBuilder.Entity("ClientePropriedade", b =>
                {
                    b.HasOne("CDESafety.Models.Cliente", null)
                        .WithMany()
                        .HasForeignKey("ClientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDESafety.Models.Propriedade", null)
                        .WithMany()
                        .HasForeignKey("PropriedadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClienteRelatorioDeServico", b =>
                {
                    b.HasOne("CDESafety.Models.Cliente", null)
                        .WithMany()
                        .HasForeignKey("ClientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDESafety.Models.RelatorioDeServico", null)
                        .WithMany()
                        .HasForeignKey("RelatorioDeServicosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CulturaRelatorioDeServico", b =>
                {
                    b.HasOne("CDESafety.Models.Cultura", null)
                        .WithMany()
                        .HasForeignKey("CulturasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDESafety.Models.RelatorioDeServico", null)
                        .WithMany()
                        .HasForeignKey("RelatorioDeServicosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EquipamentoRelatorioDeServico", b =>
                {
                    b.HasOne("CDESafety.Models.Equipamento", null)
                        .WithMany()
                        .HasForeignKey("EquipamentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDESafety.Models.RelatorioDeServico", null)
                        .WithMany()
                        .HasForeignKey("RelatorioDeServicosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PropriedadeRelatorioDeServico", b =>
                {
                    b.HasOne("CDESafety.Models.Propriedade", null)
                        .WithMany()
                        .HasForeignKey("PropriedadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDESafety.Models.RelatorioDeServico", null)
                        .WithMany()
                        .HasForeignKey("RelatorioDeServicosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CDESafety.Models.Aeronave", b =>
                {
                    b.Navigation("RelatorioDeServicos");
                });

            modelBuilder.Entity("CDESafety.Models.Piloto", b =>
                {
                    b.Navigation("RelatorioDeServico");
                });

            modelBuilder.Entity("CDESafety.Models.Pista", b =>
                {
                    b.Navigation("RelatorioDeServicos");
                });
#pragma warning restore 612, 618
        }
    }
}
