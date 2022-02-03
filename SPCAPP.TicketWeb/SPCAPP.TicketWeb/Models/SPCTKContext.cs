using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class SPCTKContext : DbContext
    {
        public SPCTKContext()
        {
        }

        public SPCTKContext(DbContextOptions<SPCTKContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adjunto> Adjuntos { get; set; }
        public virtual DbSet<Adjuntos2> Adjuntos2s { get; set; }
        public virtual DbSet<AuxNom> AuxNoms { get; set; }
        public virtual DbSet<Auxi1> Auxi1s { get; set; }
        public virtual DbSet<Bloqueado> Bloqueados { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cons1> Cons1s { get; set; }
        public virtual DbSet<Consulta1P> Consulta1Ps { get; set; }
        public virtual DbSet<Contacto> Contactos { get; set; }
        public virtual DbSet<Controle> Controles { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<Gasto> Gastos { get; set; }
        public virtual DbSet<InfTodo> InfTodos { get; set; }
        public virtual DbSet<InformeMensual1> InformeMensual1s { get; set; }
        public virtual DbSet<ItemsEq> ItemsEqs { get; set; }
        public virtual DbSet<LogTicketSpc> LogTicketSpcs { get; set; }
        public virtual DbSet<Medio> Medios { get; set; }
        public virtual DbSet<PendientesConsultar> PendientesConsultars { get; set; }
        public virtual DbSet<ProjTk> ProjTks { get; set; }
        public virtual DbSet<RegistrosVistum> RegistrosVista { get; set; }
        public virtual DbSet<RendTk> RendTks { get; set; }
        public virtual DbSet<RespTk> RespTks { get; set; }
        public virtual DbSet<TblCalendario> TblCalendarios { get; set; }
        public virtual DbSet<TblExclusionBloqueo> TblExclusionBloqueos { get; set; }
        public virtual DbSet<TblParametro> TblParametros { get; set; }
        public virtual DbSet<TblTelefono> TblTelefonos { get; set; }
        public virtual DbSet<Tecnico> Tecnicos { get; set; }
        public virtual DbSet<TerminadosMt> TerminadosMts { get; set; }
        public virtual DbSet<TicketPint> TicketPints { get; set; }
        public virtual DbSet<TicketRegistroConsultar> TicketRegistroConsultars { get; set; }
        public virtual DbSet<TicketRegistroConsultarCierre> TicketRegistroConsultarCierres { get; set; }
        public virtual DbSet<TicketRegistroConsultarDesarrollo> TicketRegistroConsultarDesarrollos { get; set; }
        public virtual DbSet<TicketRegistroConsultarSoft> TicketRegistroConsultarSofts { get; set; }
        public virtual DbSet<TicketSpc> TicketSpcs { get; set; }
        public virtual DbSet<TipoSoporte> TipoSoportes { get; set; }
        public virtual DbSet<Tk300818> Tk300818s { get; set; }
        public virtual DbSet<TkArea> TkAreas { get; set; }
        public virtual DbSet<TkGrupo> TkGrupos { get; set; }
        public virtual DbSet<Todo> Todos { get; set; }
        public virtual DbSet<UserAdmin> UserAdmins { get; set; }
        public virtual DbSet<UserWinForm> UserWinForms { get; set; }
        public virtual DbSet<ViewAuxi> ViewAuxis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.16.40.3;database=SPCTK;User ID=sa;Password=a123456$;Trusted_Connection=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adjunto>(entity =>
            {
                entity.HasKey(e => e.Ot);

                entity.Property(e => e.Ot).ValueGeneratedNever();

                entity.Property(e => e.Descripcion1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Descripcion2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Img1)
                    .HasColumnType("image")
                    .HasColumnName("img1");

                entity.Property(e => e.Img2)
                    .HasColumnType("image")
                    .HasColumnName("img2");
            });

            modelBuilder.Entity<Adjuntos2>(entity =>
            {
                entity.HasKey(e => e.Ot);

                entity.ToTable("Adjuntos2");

                entity.Property(e => e.Ot).ValueGeneratedNever();

                entity.Property(e => e.Img1)
                    .HasColumnType("image")
                    .HasColumnName("img1");

                entity.Property(e => e.Img2)
                    .HasColumnType("image")
                    .HasColumnName("img2");
            });

            modelBuilder.Entity<AuxNom>(entity =>
            {
                entity.HasKey(e => e.CodAux)
                    .HasName("PK__AuxNom__98661476B39EC27E");

                entity.ToTable("AuxNom");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.DesAux)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.RutAux)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<Auxi1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Auxi1");

                entity.Property(e => e.ActAux)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bloqueado)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BloqueadoPro)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Casilla)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CiuAux)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClaCli)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaDis)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaEmp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaOtr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaPro)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaPros)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaSoc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteDesde).HasColumnType("datetime");

                entity.Property(e => e.CodAux)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComAux)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CtaCliMonExt)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CtaCliente)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.DiaPlazo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DirAux)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DirDpto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DirNum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DirOtro)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EMailDte)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("eMailDTE");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.EsReceptorDte)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("esReceptorDTE");

                entity.Property(e => e.FaxAux1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FaxAux2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacim).HasColumnType("datetime");

                entity.Property(e => e.FechaUlMod).HasColumnType("datetime");

                entity.Property(e => e.FonAux1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FonAux2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FonAux3)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GirAux)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdRecepExtranjero)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_RecepExtranjero");

                entity.Property(e => e.NoFaux)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NoFAux");

                entity.Property(e => e.NomAux)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Notas).HasColumnType("text");

                entity.Property(e => e.PaiAux)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaisRecepExtranjero)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PalabraSecreta)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PreguntaSecreta)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Proceso)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProvAux)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RutAux)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bloqueado>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CorreoName)
                    .HasName("PK__Cliente__5B5D39F43626E057");

                entity.ToTable("Cliente");

                entity.Property(e => e.CorreoName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Server)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<Cons1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Cons1");

                entity.Property(e => e.CodProd)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DetProd).HasColumnType("text");

                entity.Property(e => e.Folio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NomAux)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Consulta1P>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Consulta1P");

                entity.Property(e => e.Avance)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAvance).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCierre");

                entity.Property(e => e.FechaTrabajo).HasColumnType("datetime");

                entity.Property(e => e.FkProcede)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Fk_Procede")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.FonoContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fono_contacto")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.GastoId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HrsInicio).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma1).HasColumnType("time(0)");

                entity.Property(e => e.HrsTermino).HasColumnType("datetime");

                entity.Property(e => e.Medio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Modo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Ot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Programado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.ProyectoId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProyectoID")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Realizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Remoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Requerimiento).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Taller)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.TerminadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Trabajo).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.UserCierre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Visita)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Contactos");

                entity.Property(e => e.CarCon)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Casilla)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodAuc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FaxCon)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaUlMod).HasColumnType("datetime");

                entity.Property(e => e.FechaUltEnvCorreo).HasColumnType("datetime");

                entity.Property(e => e.FonCon)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FonCon2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FonCon3)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Idnotas)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDNotas");

                entity.Property(e => e.NomCon)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Proceso)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSaludo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Controle>(entity =>
            {
                entity.HasKey(e => e.IdControl)
                    .HasName("PK_CONTROLES");

                entity.Property(e => e.IdControl)
                    .ValueGeneratedNever()
                    .HasColumnName("id_control");

                entity.Property(e => e.ControlAccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("control_accion")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.ControlNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("control_nombre")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.FkForm).HasColumnName("fk_form");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.CodAux)
                    .HasName("pk_ct");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Clave)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Km).HasColumnName("KM");

                entity.Property(e => e.NomAux)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Uf).HasColumnName("UF");
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.HasKey(e => e.IdForm)
                    .HasName("PK_FORM");

                entity.Property(e => e.IdForm)
                    .ValueGeneratedNever()
                    .HasColumnName("id_form");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Form1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("form")
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.HasKey(e => e.IdGasto)
                    .HasName("PK__Gastos__C630244D77DE5F1B");

                entity.Property(e => e.IdGasto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CuentaSoftland)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesGasto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Valor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<InfTodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("InfTodo");

                entity.Property(e => e.Cont)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("DETALLE")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fact)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.FechaTrabajo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA TRABAJO")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fin)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FIN")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HoraSolicitud)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA SOLICITUD")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HorasProyec)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HORAS PROYEC")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HorasRemoto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HORAS REMOTO")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HorasTaller)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HORAS TALLER")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HorasVisitas)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HORAS VISITAS")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Inicio)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("INICIO")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Km)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KM")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.MotivoLlamada)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MOTIVO LLAMADA")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.NºOt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nº OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Pc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PC")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TECNICO")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Ticket).HasColumnName("TICKET");

                entity.Property(e => e.VR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("V/R")
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<InformeMensual1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("InformeMensual1");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaTrabajo).HasColumnType("date");

                entity.Property(e => e.Fin)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HoraDeSolicitud)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Hora de solicitud");

                entity.Property(e => e.Inicio)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoDeLlamada)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Motivo de llamada")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Ot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.TicketId).HasColumnName("Ticket ID");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.TotalHoras)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Total Horas");

                entity.Property(e => e.Trabajo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.VR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("V/R");
            });

            modelBuilder.Entity<ItemsEq>(entity =>
            {
                entity.ToTable("ItemsEq");

                entity.Property(e => e.Activo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.FecahaT).HasColumnType("date");

                entity.Property(e => e.FechaI).HasColumnType("date");
            });

            modelBuilder.Entity<LogTicketSpc>(entity =>
            {
                entity.ToTable("LogTicketSpc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Equipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.EstadoTk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.FechaLog)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ticket).HasColumnType("xml");

                entity.Property(e => e.TicketId).HasColumnName("ticketID");

                entity.Property(e => e.TipoMov)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<Medio>(entity =>
            {
                entity.HasKey(e => e.IdMed)
                    .HasName("PK__Medios__3DC6EB8907B61EA3");

                entity.Property(e => e.IdMed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idMed")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Medio1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Medio")
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<PendientesConsultar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PendientesConsultar");

                entity.Property(e => e.Avance)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Requerimiento).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<ProjTk>(entity =>
            {
                entity.HasKey(e => e.IdProy)
                    .HasName("PK__ProjTk__E40D970683A24479");

                entity.ToTable("ProjTk");

                entity.Property(e => e.IdProy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Activo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Sence)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<RegistrosVistum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RegistrosVista");

                entity.Property(e => e.Avance)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAvance).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCierre");

                entity.Property(e => e.FechaTrabajo).HasColumnType("datetime");

                entity.Property(e => e.FkProcede)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Fk_Procede")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.FonoContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fono_contacto")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Horaav)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORAAV")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HrsInicio).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma1).HasColumnType("time(0)");

                entity.Property(e => e.HrsTermino).HasColumnType("datetime");

                entity.Property(e => e.Medio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Ot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Programado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Realizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Remoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Requerimiento).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Taller)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.TerminadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Trabajo).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Visita)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<RendTk>(entity =>
            {
                entity.ToTable("RendTk");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.GastoId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<RespTk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RespTK");

                entity.Property(e => e.Avance)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAvance).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCierre");

                entity.Property(e => e.FechaTrabajo).HasColumnType("datetime");

                entity.Property(e => e.FkProcede)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Fk_Procede")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.FonoContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fono_contacto")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HrsInicio).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma1).HasColumnType("time(0)");

                entity.Property(e => e.HrsTermino).HasColumnType("datetime");

                entity.Property(e => e.Medio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Ot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Programado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Realizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Remoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Requerimiento).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Taller)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.TerminadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Trabajo).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Visita)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TblCalendario>(entity =>
            {
                entity.HasKey(e => e.IdTicket);

                entity.ToTable("tblCalendario");

                entity.Property(e => e.IdTicket).ValueGeneratedNever();

                entity.Property(e => e.Cuenta)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.IdEventoCalendario)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TblExclusionBloqueo>(entity =>
            {
                entity.HasKey(e => e.IdBloqueo);

                entity.ToTable("Tbl_ExclusionBloqueos");

                entity.Property(e => e.IdBloqueo).HasColumnName("idBloqueo");

                entity.Property(e => e.CodAux)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblParametro>(entity =>
            {
                entity.HasKey(e => e.IdParametro);

                entity.ToTable("tblParametros");

                entity.Property(e => e.IdParametro).HasColumnName("idParametro");

                entity.Property(e => e.Parametro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTelefono>(entity =>
            {
                entity.ToTable("tbl_telefonos");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tecnico>(entity =>
            {
                entity.HasKey(e => e.IdTec)
                    .HasName("PK_Tec");

                entity.ToTable("Tecnico");

                entity.Property(e => e.IdTec)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Activo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.NombreCalendario)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.TecnicoNom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TerminadosMt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("terminadosMT");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("DETALLE")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fact)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.FechaTrabajo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA TRABAJO")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fin)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FIN")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HoraSolicitud)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA SOLICITUD")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Inicio)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("INICIO")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Km)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KM")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.MotivoLlamada)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MOTIVO LLAMADA")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.NºOt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nº OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TECNICO")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Ticket).HasColumnName("TICKET");

                entity.Property(e => e.VR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("V/R")
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TicketPint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TicketPint");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma).HasColumnType("datetime");

                entity.Property(e => e.Programado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TicketRegistroConsultar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TicketRegistroConsultar");

                entity.Property(e => e.Avance)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAvance).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA");

                entity.Property(e => e.Horaav)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORAAV");

                entity.Property(e => e.HrsPrograma).HasColumnType("datetime");

                entity.Property(e => e.Ot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Requerimiento).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.TerminadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Visita)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TicketRegistroConsultarCierre>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TicketRegistroConsultarCierre");

                entity.Property(e => e.Avance)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAvance).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Horaav)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORAAV")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HrsPrograma).HasColumnType("datetime");

                entity.Property(e => e.Ot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Requerimiento).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TicketRegistroConsultarDesarrollo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TicketRegistroConsultarDesarrollo");

                entity.Property(e => e.Avance)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAvance).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA");

                entity.Property(e => e.Horaav)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORAAV");

                entity.Property(e => e.HrsPrograma).HasColumnType("datetime");

                entity.Property(e => e.Ot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Requerimiento).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.TerminadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Visita)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TicketRegistroConsultarSoft>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TicketRegistroConsultarSoft");

                entity.Property(e => e.Avance)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAvance).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Horaav)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORAAV")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HrsPrograma).HasColumnType("datetime");

                entity.Property(e => e.Ot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Requerimiento).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TicketSpc>(entity =>
            {
                entity.ToTable("TicketSpc");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Avance)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CpbAno)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CpbNum)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAvance).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCierre");

                entity.Property(e => e.FechaTrabajo).HasColumnType("datetime");

                entity.Property(e => e.Fk_procede)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Fk_Procede")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fono_contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fono_contacto")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HrsInicio).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma1).HasColumnType("time(0)");

                entity.Property(e => e.HrsTermino).HasColumnType("datetime");

                entity.Property(e => e.Medio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Modo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Ot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Passwords).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Programado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.ProyectoId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProyectoID")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Realizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Remoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Requerimiento).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Taller)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.TerminadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Trabajo).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.UserCierre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.UserCreaTk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Visita)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TipoSoporte>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("pk_tipos");

                entity.ToTable("TipoSoporte");

                entity.Property(e => e.IdTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.AreaNeg)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CcSoftland)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Grupo2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.TipoDes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<Tk300818>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TK300818");

                entity.Property(e => e.Avance)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAvance).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCierre");

                entity.Property(e => e.FechaTrabajo).HasColumnType("datetime");

                entity.Property(e => e.FkProcede)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Fk_Procede")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.FonoContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fono_contacto")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HrsInicio).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma).HasColumnType("datetime");

                entity.Property(e => e.HrsPrograma1).HasColumnType("time(0)");

                entity.Property(e => e.HrsTermino).HasColumnType("datetime");

                entity.Property(e => e.Medio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Ot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Programado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.ProyectoId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProyectoID")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Realizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Remoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Requerimiento).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Taller)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.TerminadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Trabajo).HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.UserCierre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Visita)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TkArea>(entity =>
            {
                entity.HasKey(e => new { e.CodAux, e.CodArea })
                    .HasName("pk_are");

                entity.Property(e => e.CodAux)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.CodArea)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.DesArea)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.NomAux)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<TkGrupo>(entity =>
            {
                entity.HasKey(e => e.CodGrupo);

                entity.Property(e => e.CodGrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.DesGrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<Todo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Todo");

                entity.Property(e => e.Cont)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONT");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("DETALLE")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fact)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA");

                entity.Property(e => e.FechaTrabajo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA TRABAJO");

                entity.Property(e => e.Fin)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FIN");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.HoraSolicitud)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA SOLICITUD");

                entity.Property(e => e.HorasProyec)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HORAS PROYEC");

                entity.Property(e => e.HorasRemoto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HORAS REMOTO");

                entity.Property(e => e.HorasTaller)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HORAS TALLER");

                entity.Property(e => e.HorasVisitas)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HORAS VISITAS");

                entity.Property(e => e.Inicio)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("INICIO");

                entity.Property(e => e.Km)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KM");

                entity.Property(e => e.MotivoLlamada)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MOTIVO LLAMADA")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.NºOt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nº OT")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Pc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PC");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TECNICO")
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Ticket).HasColumnName("TICKET");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.VR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("V/R");
            });

            modelBuilder.Entity<UserAdmin>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__UserAdmi__B7C926383F68B64C");

                entity.Property(e => e.IdUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.NameUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<UserWinForm>(entity =>
            {
                entity.HasKey(e => e.Usuario)
                    .HasName("Usuario ya existe");

                entity.ToTable("UserWinForm");

                entity.HasIndex(e => e.Tecnico, "Solo se puede agregar 1 usuario por tecnico")
                    .IsUnique();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Clave)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<ViewAuxi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAuxi");

                entity.Property(e => e.ActAux)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bloqueado)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BloqueadoPro)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Casilla)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CiuAux)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClaCli)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaDis)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaEmp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaOtr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaPro)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaPros)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaSoc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteDesde).HasColumnType("datetime");

                entity.Property(e => e.CodAux)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComAux)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CtaCliMonExt)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CtaCliente)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.DiaPlazo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DirAux)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DirDpto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DirNum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DirOtro)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EMailDte)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("eMailDTE");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.EsReceptorDte)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("esReceptorDTE");

                entity.Property(e => e.FaxAux1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FaxAux2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacim).HasColumnType("datetime");

                entity.Property(e => e.FechaUlMod).HasColumnType("datetime");

                entity.Property(e => e.FonAux1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FonAux2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FonAux3)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GirAux)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdRecepExtranjero)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_RecepExtranjero");

                entity.Property(e => e.NoFaux)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NoFAux");

                entity.Property(e => e.NomAux)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Notas).HasColumnType("text");

                entity.Property(e => e.PaiAux)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaisRecepExtranjero)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PalabraSecreta)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PreguntaSecreta)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Proceso)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProvAux)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RutAux)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
