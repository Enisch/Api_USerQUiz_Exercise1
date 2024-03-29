﻿// <auto-generated />
using System;
using ContextoBd;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContextoBd.Migrations
{
    [DbContext(typeof(ContextDb))]
    [Migration("20240223174204_User")]
    partial class User
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InfraData.Domain.Models_Entities.Alternativa_RespostasQuiz", b =>
                {
                    b.Property<int>("IDRespostasQuiz")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AlternativaQuiz")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<int?>("RespostaQuizid")
                        .HasColumnType("int");

                    b.HasKey("IDRespostasQuiz");

                    b.HasIndex("RespostaQuizid");

                    b.ToTable("AlternativaQuiz");
                });

            modelBuilder.Entity("InfraData.Domain.Models_Entities.RespostaQuiz", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PerguntasDasAlternativas")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.HasKey("id");

                    b.ToTable("RespostaQuizzes");
                });

            modelBuilder.Entity("InfraData.Domain.TabelaQuiz", b =>
                {
                    b.Property<int>("IDPerguntasQuiz")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Perguntas")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<int?>("RespostaQuizid")
                        .HasColumnType("int");

                    b.HasKey("IDPerguntasQuiz");

                    b.HasIndex("RespostaQuizid");

                    b.ToTable("PerguntasDoQuiz");
                });

            modelBuilder.Entity("Infradata.Domain_.Models_Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.HasKey("Id");

                    b.ToTable("UsuariosDoQuiz");
                });

            modelBuilder.Entity("InfraData.Domain.Models_Entities.Alternativa_RespostasQuiz", b =>
                {
                    b.HasOne("InfraData.Domain.Models_Entities.RespostaQuiz", null)
                        .WithMany("IDRespostasQuiz")
                        .HasForeignKey("RespostaQuizid");
                });

            modelBuilder.Entity("InfraData.Domain.TabelaQuiz", b =>
                {
                    b.HasOne("InfraData.Domain.Models_Entities.RespostaQuiz", null)
                        .WithMany("IDPerguntasQuiz")
                        .HasForeignKey("RespostaQuizid");
                });

            modelBuilder.Entity("InfraData.Domain.Models_Entities.RespostaQuiz", b =>
                {
                    b.Navigation("IDPerguntasQuiz");

                    b.Navigation("IDRespostasQuiz");
                });
#pragma warning restore 612, 618
        }
    }
}
