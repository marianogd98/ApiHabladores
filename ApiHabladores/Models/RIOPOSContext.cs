using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ApiHabladores.Models.Riopos;
using ApiHabladores.Models.StoreProcedure;

#nullable disable

namespace ApiHabladores.Models
{
    public partial class RIOPOSContext : DbContext
    {
        public RIOPOSContext()
        {
        }

        public RIOPOSContext(DbContextOptions<RIOPOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acceso> Accesos { get; set; }
        public virtual DbSet<Accion> Accions { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Arqueo> Arqueos { get; set; }
        public virtual DbSet<Auditorium> Auditoria { get; set; }
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<Caja> Cajas { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cliente01> Cliente01s { get; set; }
        public virtual DbSet<ClienteTmp> ClienteTmps { get; set; }
        public virtual DbSet<CodigoBarra> CodigoBarras { get; set; }
        public virtual DbSet<Combo> Combos { get; set; }
        public virtual DbSet<ComboProducto> ComboProductos { get; set; }
        public virtual DbSet<ConceptoArqueo> ConceptoArqueos { get; set; }
        public virtual DbSet<ConfigBoton> ConfigBotons { get; set; }
        public virtual DbSet<ConsecutivosLp> ConsecutivosLps { get; set; }
        public virtual DbSet<Constante> Constantes { get; set; }
        public virtual DbSet<CuentasBancaria> CuentasBancarias { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<DesgloseDolar> DesgloseDolars { get; set; }
        public virtual DbSet<DesglosePunto> DesglosePuntos { get; set; }
        public virtual DbSet<DetalleArqueo> DetalleArqueos { get; set; }
        public virtual DbSet<DetalleDevolucion> DetalleDevolucions { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public virtual DbSet<Devolucion> Devolucions { get; set; }
        public virtual DbSet<Donacion> Donacions { get; set; }
        public virtual DbSet<ErrorDevolucion> ErrorDevolucions { get; set; }
        public virtual DbSet<ErrorFactura> ErrorFacturas { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<FacturaTemp> FacturaTemps { get; set; }
        public virtual DbSet<FormaPago> FormaPagos { get; set; }
        public virtual DbSet<FormaPago01> FormaPago01s { get; set; }
        public virtual DbSet<Impuesto> Impuestos { get; set; }
        public virtual DbSet<Inscliente> Insclientes { get; set; }
        public virtual DbSet<ListaPrecio> ListaPrecios { get; set; }
        public virtual DbSet<ListaPrecioDetalle> ListaPrecioDetalles { get; set; }
        public virtual DbSet<M64001> M64001s { get; set; }
        public virtual DbSet<M66001> M66001s { get; set; }
        public virtual DbSet<M66002> M66002s { get; set; }
        public virtual DbSet<M66007> M66007s { get; set; }
        public virtual DbSet<Modulo> Modulos { get; set; }
        public virtual DbSet<MovimientoWallet> MovimientoWallets { get; set; }
        public virtual DbSet<MovimientoWallet01> MovimientoWallet01s { get; set; }
        public virtual DbSet<Organizacion> Organizacions { get; set; }
        public virtual DbSet<PagoFactura> PagoFacturas { get; set; }
        public virtual DbSet<Pregunta> Preguntas { get; set; }
        public virtual DbSet<Preguntas01> Preguntas01s { get; set; }
        public virtual DbSet<Premio> Premios { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<PromoSeptiembre> PromoSeptiembres { get; set; }
        public virtual DbSet<ReporteZetum> ReporteZeta { get; set; }
        public virtual DbSet<ResumenVentum> ResumenVenta { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolAccion> RolAccions { get; set; }
        public virtual DbSet<Sapstellar> Sapstellars { get; set; }
        public virtual DbSet<SeguridadWallet> SeguridadWallets { get; set; }
        public virtual DbSet<Serial> Serials { get; set; }
        public virtual DbSet<Servidor> Servidors { get; set; }
        public virtual DbSet<Sorteo> Sorteos { get; set; }
        public virtual DbSet<Tempuser> Tempusers { get; set; }
        public virtual DbSet<Tiendum> Tienda { get; set; }
        public virtual DbSet<TmpDetalleMercha> TmpDetalleMerchas { get; set; }
        public virtual DbSet<Turno> Turnos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioAccion> UsuarioAccions { get; set; }
        public virtual DbSet<VwReporteZetum> VwReporteZeta { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }
        public virtual DbSet<Wallet01> Wallet01s { get; set; }
        public virtual DbSet<Wallet02> Wallet02s { get; set; }
        public virtual DbSet<WalletTmp> WalletTmps { get; set; }

        //CLASES PARA SP
        public virtual DbSet<ProductoCosto> SpProductosCosto { get; set; }
        public virtual DbSet<ProductoCosto> SpBuscarProductosListaPrecio { get; set; }
        public virtual DbSet<InsertListaPrecio> SpInsertListaDePrecio { get; set; }
        public virtual DbSet<MostrarListaDePrecio> SpMostrarListaDePrecio { get; set; }
        public virtual DbSet<MostrarListasDePrecio> SpMostrarListasDePrecio { get; set; }
        public virtual DbSet<M66002> spBuscarListaCostoGeneral { get; set; }
        public virtual DbSet<BuscarProductoOfertaDia> spBuscarProductoOfertaDia { get; set; }
        public virtual DbSet<SpListaProductosOferta> spListaProductosOferta { get; set; }
        public virtual DbSet<SaveDetalleProducto> GuardarDetalleProducto { get; set; }
        public virtual DbSet<SpBuscarProductoHab> SpBuscarProductoHab { get; set; }
        public virtual DbSet<SpListaProdHablador> SpListProdHab { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=172.50.0.15;Database=RIOPOS;User id=apiuser;password=123456;");
                //optionsBuilder.UseSqlServer("Server=172.22.0.15;Database=RIOPOS;User id=apiuser;password=123456;");
                optionsBuilder.UseSqlServer("Server=172.24.0.15;Database=RIOPOS;User id=apiuser;password=123456;");
                //optionsBuilder.UseSqlServer("Server=20.228.173.33;Database=RIOPOS;User id=apiusermat2;password=MAT123456**;");
                //optionsBuilder.UseSqlServer("Server=172.50.3.45;Database=RIOPOS;User id=apiuser;password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acceso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Acceso");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MacAdress).HasColumnName("mac_adress");
            });

            modelBuilder.Entity<Accion>(entity =>
            {
                entity.ToTable("Accion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Modulo)
                    .WithMany(p => p.Accions)
                    .HasForeignKey(d => d.ModuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("accion_moduloid_foreign");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("Area");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Arqueo>(entity =>
            {
                entity.ToTable("Arqueo");

                entity.HasIndex(e => e.TurnoId, "UX_Turno")
                    .IsUnique();

                entity.Property(e => e.Estatus)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: por depositar\r\n2: Despotado");

                entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Turno)
                    .WithOne(p => p.Arqueo)
                    .HasForeignKey<Arqueo>(d => d.TurnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Arqueo_Turno");
            });

            modelBuilder.Entity<Auditorium>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.ToTable("Banco");

                entity.Property(e => e.Codigo).HasDefaultValueSql("((134))");

                entity.Property(e => e.CodigoStellar)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Caja>(entity =>
            {
                entity.ToTable("Caja");

                entity.HasIndex(e => e.CodigoCaja, "UK_CodigoCaja")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BancoId).HasDefaultValueSql("((1))");

                entity.Property(e => e.CodigoCaja)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Consecutivo).HasDefaultValueSql("((1))");

                entity.Property(e => e.PuertoBalanza)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PuertoCodigoBarra)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PuertoImpresora)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SerialImpresora)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Vtid)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("VTID");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.Apellido).HasMaxLength(255);

                entity.Property(e => e.CodigoTipoCliente).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nit)
                    .HasMaxLength(10)
                    .HasColumnName("NIT");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RazonComercial).HasMaxLength(255);

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("RIF");

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Cliente01>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cliente01");

                entity.Property(e => e.Apellido).HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Nit)
                    .HasMaxLength(10)
                    .HasColumnName("NIT");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RazonComercial).HasMaxLength(255);

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("RIF");

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ClienteTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClienteTMP");

                entity.Property(e => e.Apellido).HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdclienteTienda).HasColumnName("IDClienteTienda");

                entity.Property(e => e.Nit)
                    .HasMaxLength(10)
                    .HasColumnName("NIT");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RazonComercial).HasMaxLength(255);

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("RIF");

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<CodigoBarra>(entity =>
            {
                entity.ToTable("CodigoBarra");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.CodigoBarra1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CodigoBarra");

                entity.Property(e => e.Predeterminado).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.CodigoBarras)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("FK_CodigoBarra_Producto");
            });

            modelBuilder.Entity<Combo>(entity =>
            {
                entity.ToTable("Combo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Barra)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CodigoCombo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaIni).HasColumnType("datetime");
            });

            modelBuilder.Entity<ComboProducto>(entity =>
            {
                entity.ToTable("ComboProducto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Combo)
                    .WithMany(p => p.ComboProductos)
                    .HasForeignKey(d => d.ComboId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComboProducto_Combo");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ComboProductos)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComboProducto_Producto");
            });

            modelBuilder.Entity<ConceptoArqueo>(entity =>
            {
                entity.ToTable("ConceptoArqueo");

                entity.Property(e => e.Abreviatura)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfigBoton>(entity =>
            {
                entity.ToTable("ConfigBoton");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.ConfigBotons)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_ConfigBoton_Area");
            });

            modelBuilder.Entity<ConsecutivosLp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ConsecutivosLP");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Constante>(entity =>
            {
                entity.ToTable("Constante", "QQM");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("Updated_at")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CuentasBancaria>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NumeroCuenta)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("Departamento");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Estatus).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DesgloseDolar>(entity =>
            {
                entity.ToTable("DesgloseDolar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Moneda).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DesglosePunto>(entity =>
            {
                entity.ToTable("DesglosePunto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Arqueo)
                    .WithMany(p => p.DesglosePuntos)
                    .HasForeignKey(d => d.ArqueoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesglosePunto_Arqueo");

                entity.HasOne(d => d.CuentaBancaria)
                    .WithMany(p => p.DesglosePuntos)
                    .HasForeignKey(d => d.CuentaBancariaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesglosePunto_CuentasBancarias");
            });

            modelBuilder.Entity<DetalleArqueo>(entity =>
            {
                entity.ToTable("DetalleArqueo");

                entity.Property(e => e.Tipo).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Arqueo)
                    .WithMany(p => p.DetalleArqueos)
                    .HasForeignKey(d => d.ArqueoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleArqueo_Arqueo");
            });

            modelBuilder.Entity<DetalleDevolucion>(entity =>
            {
                entity.ToTable("DetalleDevolucion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DevolucionId).HasColumnName("devolucionId");

                entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Devolucion)
                    .WithMany(p => p.DetalleDevolucions)
                    .HasForeignKey(d => d.DevolucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleDevolucion_Devolucion");

                entity.HasOne(d => d.Factura)
                    .WithMany(p => p.DetalleDevolucions)
                    .HasForeignKey(d => d.FacturaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleDevolucion_Factura");
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.ToTable("DetalleFactura");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Factura)
                    .WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.FacturaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleFactura_Factura");
            });

            modelBuilder.Entity<Devolucion>(entity =>
            {
                entity.ToTable("Devolucion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NumeroDevolucion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SerialFiscal)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.Devolucions)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Devolucion_Caja");

                entity.HasOne(d => d.Factura)
                    .WithMany(p => p.Devolucions)
                    .HasForeignKey(d => d.FacturaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("devolucion_facturaid_foreign");

                entity.HasOne(d => d.Turno)
                    .WithMany(p => p.Devolucions)
                    .HasForeignKey(d => d.TurnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Devolucion_Turno");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Devolucions)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Devolucion_Usuario");
            });

            modelBuilder.Entity<Donacion>(entity =>
            {
                entity.ToTable("Donacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.NroAutorizacion).HasMaxLength(50);

                entity.Property(e => e.NumeroTransacion).HasMaxLength(15);

                entity.Property(e => e.Tasa).HasColumnName("tasa");

                entity.Property(e => e.TipoTarjeta).HasMaxLength(10);

                entity.Property(e => e.Vposdata)
                    .HasColumnType("xml")
                    .HasColumnName("VPOSData");

                entity.HasOne(d => d.Organizacion)
                    .WithMany(p => p.Donacions)
                    .HasForeignKey(d => d.OrganizacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Donacion_Organizacion");

                entity.HasOne(d => d.Turno)
                    .WithMany(p => p.Donacions)
                    .HasForeignKey(d => d.TurnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Donacion_Turno");
            });

            modelBuilder.Entity<ErrorDevolucion>(entity =>
            {
                entity.ToTable("ErrorDevolucion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDevolucion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Productos).HasColumnType("xml");

                entity.Property(e => e.SerialFiscal)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErrorFactura>(entity =>
            {
                entity.ToTable("ErrorFactura");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MensajeError)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MontoIva).HasColumnName("MontoIVA");

                entity.Property(e => e.NumeroFactura)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Productos)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.Property(e => e.Serialfilcal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.ToTable("Factura");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodigoAfiliacion).HasMaxLength(255);

                entity.Property(e => e.CodigoArea).HasMaxLength(255);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GuiaLicor).HasMaxLength(255);

                entity.Property(e => e.MontoIva).HasColumnName("MontoIVA");

                entity.Property(e => e.NumeroControl)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NumeroFactura)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SerialFiscal)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Tasa).HasColumnName("tasa");

                entity.HasOne(d => d.Turno)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.TurnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factura_Turno");
            });

            modelBuilder.Entity<FacturaTemp>(entity =>
            {
                entity.ToTable("FacturaTemp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Productos)
                    .IsRequired()
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<FormaPago>(entity =>
            {
                entity.ToTable("FormaPago");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CorreoZelle).HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<FormaPago01>(entity =>
            {
                entity.ToTable("FormaPago01");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CorreoZelle).HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Telefono).HasMaxLength(255);
            });

            modelBuilder.Entity<Impuesto>(entity =>
            {
                entity.ToTable("Impuesto");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Estatus).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Inscliente>(entity =>
            {
                entity.ToTable("INSCliente");

                entity.Property(e => e.Apellido).HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Nit)
                    .HasMaxLength(10)
                    .HasColumnName("NIT");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RazonComercial).HasMaxLength(255);

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("RIF");

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ListaPrecio>(entity =>
            {
                entity.ToTable("ListaPrecio");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Estatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaFinOferta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.FechaInicioOferta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tipo).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Update_at")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ListaPrecios)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListaPrecioUsuario");
            });

            modelBuilder.Entity<ListaPrecioDetalle>(entity =>
            {
                entity.ToTable("ListaPrecioDetalle");

                entity.Property(e => e.CodigoAlterno)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CodigoArticulo)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Pvp).HasColumnName("PVP");

                entity.Property(e => e.Pvpant).HasColumnName("PVPAnt");

                entity.Property(e => e.Pvpoferta)
                    .HasColumnName("PVPOferta")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ListaPrecio)
                    .WithMany(p => p.ListaPrecioDetalles)
                    .HasForeignKey(d => d.ListaPrecioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleLP");
            });

            modelBuilder.Entity<M64001>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("M64001");

                entity.Property(e => e.AliasName)
                    .HasMaxLength(50)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Balance).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BalanceFc)
                    .HasColumnType("numeric(19, 6)")
                    .HasColumnName("BalanceFC");

                entity.Property(e => e.BalanceSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Calle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.CardCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.CardName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.CardType)
                    .HasMaxLength(2)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.CmpPrivate)
                    .HasMaxLength(50)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.CodEstado)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.CodGrupoSocio)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.CodPais)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.CountyName)
                    .HasMaxLength(50)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.CreateUpDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyLimCred)
                    .HasMaxLength(20)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.DebPayAcct)
                    .HasMaxLength(20)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.DebtLine).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DescuentoGlobal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMail")
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Estacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.FrozenFrom).HasColumnType("datetime");

                entity.Property(e => e.FrozenTo)
                    .HasColumnType("date")
                    .HasColumnName("frozenTo");

                entity.Property(e => e.GroupNum)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.HouseId)
                    .HasMaxLength(50)
                    .HasColumnName("HouseID")
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.IdM64001).HasColumnName("ID_M64001");

                entity.Property(e => e.IndustryC)
                    .HasMaxLength(50)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.IntrstRate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LicTradNum)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.LimiteCredito).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PaginaWeb)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.PriceList)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.SlpCode)
                    .HasMaxLength(20)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Telefono2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.TipoPersona)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.TipoPersonaNw)
                    .HasMaxLength(10)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.TypeOfop)
                    .HasMaxLength(50)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UsoCfdi)
                    .HasMaxLength(50)
                    .HasColumnName("UsoCFDI")
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.Property(e => e.VatGroup)
                    .HasMaxLength(20)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");
            });

            modelBuilder.Entity<M66001>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("M66001");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Father)
                    .HasMaxLength(20)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.IdM66001).HasColumnName("ID_M66001");

                entity.Property(e => e.ItmsGrpCod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.ItmsGrpNam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");
            });

            modelBuilder.Entity<M66002>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("M66002");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.EstacionI)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.EstacionU)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Factor).HasColumnType("numeric(18, 2)");

                //entity.Property(e => e.FechaI).HasColumnType("datetime");

                //entity.Property(e => e.FechaU).HasColumnType("datetime");

                //entity.Property(e => e.IdM66002).HasColumnName("ID_M66002");

                entity.Property(e => e.PriceList)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.PriceListBase)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.UsuarioI)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.UsuarioU)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");
            });

            modelBuilder.Entity<M66007>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("M66007");

                entity.Property(e => e.CodArt)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Currency)
                    .HasMaxLength(5)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.EstacionI)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.EstacionU)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.FechaI).HasColumnType("datetime");

                entity.Property(e => e.FechaU).HasColumnType("datetime");

                entity.Property(e => e.IdM66007).HasColumnName("ID_M66007");

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PriceAnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PriceList)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.SubSociedad)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.Taplication)
                    .HasMaxLength(10)
                    .HasColumnName("TAplication")
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.UsuarioI)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");

                entity.Property(e => e.UsuarioU)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SQL_Latin1_General_CP850_CI_AS");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.ToTable("Modulo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MovimientoWallet>(entity =>
            {
                entity.ToTable("MovimientoWallet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.TiendaId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MovimientoWallet01>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MovimientoWallet01");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_at");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Monto).HasColumnType("money");
            });

            modelBuilder.Entity<Organizacion>(entity =>
            {
                entity.ToTable("Organizacion");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Motivo).HasMaxLength(255);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("RIF");

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PagoFactura>(entity =>
            {
                entity.ToTable("PagoFactura");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BancoadquirienteId).HasColumnName("bancoadquirienteId");

                entity.Property(e => e.Lote)
                    .HasMaxLength(255)
                    .HasColumnName("lote");

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.NroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTransaccion).HasMaxLength(255);

                entity.Property(e => e.TipoTarjeta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vposdata)
                    .HasColumnType("xml")
                    .HasColumnName("VPOSData");

                entity.HasOne(d => d.Factura)
                    .WithMany(p => p.PagoFacturas)
                    .HasForeignKey(d => d.FacturaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PagoFactura_Factura");

                entity.HasOne(d => d.FormaPago)
                    .WithMany(p => p.PagoFacturas)
                    .HasForeignKey(d => d.FormaPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PagoFactura_FormaPago");
            });

            modelBuilder.Entity<Pregunta>(entity =>
            {
                entity.ToTable("Preguntas", "QQM");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_at");

                entity.Property(e => e.UpdatedAt).HasColumnName("Updated_at");
            });

            modelBuilder.Entity<Preguntas01>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Preguntas01", "QQM");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_at");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedAt).HasColumnName("Updated_at");
            });

            modelBuilder.Entity<Premio>(entity =>
            {
                entity.ToTable("Premio", "QQM");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("Updated_at")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("Producto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodigoBalanza)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CodigoGrupo).HasMaxLength(10);

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CodigoSap)
                    .HasMaxLength(15)
                    .HasColumnName("CodigoSAP");

                entity.Property(e => e.CodigoSubgrupo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CodigoTipo)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaOfertaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaOfertaIni).HasColumnType("datetime");
            });

            modelBuilder.Entity<PromoSeptiembre>(entity =>
            {
                entity.ToTable("PromoSeptiembre");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_at");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.UpdatedAt).HasColumnName("Updated_at");
            });

            modelBuilder.Entity<ReporteZetum>(entity =>
            {
                entity.Property(e => e.NumeroZeta).HasMaxLength(10);

                entity.Property(e => e.UltimaFactura)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Vposdata)
                    .HasColumnType("xml")
                    .HasColumnName("VPOSData");

                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.ReporteZeta)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReporteZetaF_Caja");
            });

            modelBuilder.Entity<ResumenVentum>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");

                entity.HasIndex(e => e.Descripcion, "UK_Descripcion")
                    .IsUnique();

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasColumnName("activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RolAccion>(entity =>
            {
                entity.ToTable("RolAccion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Accion)
                    .WithMany(p => p.RolAccions)
                    .HasForeignKey(d => d.AccionId)
                    .HasConstraintName("rolaccion_accionid_foreign");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RolAccions)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("rolaccion_rolid_foreign");
            });

            modelBuilder.Entity<Sapstellar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SAPSTELLAR");

                entity.Property(e => e.DescripciónDelArtículo)
                    .HasMaxLength(255)
                    .HasColumnName("Descripción del artículo");

                entity.Property(e => e.Inactivo).HasMaxLength(255);

                entity.Property(e => e.NombreDeGrupo)
                    .HasMaxLength(255)
                    .HasColumnName("Nombre de grupo");

                entity.Property(e => e.Sap)
                    .HasMaxLength(255)
                    .HasColumnName("SAP");

                entity.Property(e => e.Stellar)
                    .HasMaxLength(255)
                    .HasColumnName("STELLAR");
            });

            modelBuilder.Entity<SeguridadWallet>(entity =>
            {
                entity.ToTable("SeguridadWallet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastLoggins)
                    .HasColumnName("last_loggins")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.SeguridadWallets)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeguridadWallet_Cliente");
            });

            modelBuilder.Entity<Serial>(entity =>
            {
                entity.ToTable("Serial");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Serial1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Serial");
            });

            modelBuilder.Entity<Servidor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Servidor");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sorteo>(entity =>
            {
                entity.ToTable("Sorteo", "QQM");

                entity.Property(e => e.Fin).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inicio).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tempuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempuser");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Tiendum>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CodigoTienda, "tienda_codigotienda_unique")
                    .IsUnique();

                entity.Property(e => e.AplicaIva).HasColumnName("AplicaIVA");

                entity.Property(e => e.CodigoArea)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CodigoTienda)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Margen).HasColumnName("margen");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tasa).HasColumnName("tasa");

                entity.Property(e => e.Urlapi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("URLAPI");
            });

            modelBuilder.Entity<TmpDetalleMercha>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_Detalle_Mercha");

                entity.Property(e => e.Afiliacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("afiliacion");

                entity.Property(e => e.Aprobacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aprobacion");

                entity.Property(e => e.Banco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("banco");

                entity.Property(e => e.Comision).HasColumnName("comision");

                entity.Property(e => e.Fecha1)
                    .HasColumnType("date")
                    .HasColumnName("fecha1");

                entity.Property(e => e.Fecha2)
                    .HasColumnType("date")
                    .HasColumnName("fecha2");

                entity.Property(e => e.Hora1).HasColumnName("hora1");

                entity.Property(e => e.Hora2).HasColumnName("hora2");

                entity.Property(e => e.Lote)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lote");

                entity.Property(e => e.MontoBruto).HasColumnName("montoBruto");

                entity.Property(e => e.Neto).HasColumnName("neto");

                entity.Property(e => e.Retencion).HasColumnName("retencion");

                entity.Property(e => e.Tarjeta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tarjeta");

                entity.Property(e => e.TipoTarjeta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoTarjeta");

                entity.Property(e => e.Vtid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vtid");

                entity.Property(e => e.Vtide)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vtide");
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.ToTable("Turno");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estatus)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Abierto\r\n2: Cerrado\r\n3: Suspendido\r\n4: En Revision\r\n5: Verificado");

                entity.Property(e => e.Inicio).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.Turnos)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Turno_Caja");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Turnos)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Turno_Usuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Cedula, "UK_cedula")
                    .IsUnique();

                entity.HasIndex(e => e.Nick, "UK_nick")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasComment("-1: Eliminado\r\n0: Inactivo\r\n1: Activo\r\n2: Online");

                entity.Property(e => e.Nick)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nick");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.RecordarToken)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("recordar_token");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasComment("0: Super usuario\r\n1: Administradores\r\n2: caja Administrativa (Supervisor)\r\n21: Receptor\r\n3: pos Rio");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Rol");
            });

            modelBuilder.Entity<UsuarioAccion>(entity =>
            {
                entity.ToTable("UsuarioAccion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Accion)
                    .WithMany(p => p.UsuarioAccions)
                    .HasForeignKey(d => d.AccionId)
                    .HasConstraintName("usuarioaccion_accionid_foreign");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioAccions)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_UsuarioAccion_Usuario");
            });

            modelBuilder.Entity<VwReporteZetum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwReporteZeta");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NumeroZeta).HasMaxLength(10);

                entity.Property(e => e.UltimaFactura)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.ToTable("Wallet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("Updated_at")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Wallet01>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Wallet01");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_at");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.Property(e => e.UpdatedAt).HasColumnName("Updated_at");
            });

            modelBuilder.Entity<Wallet02>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Wallet02");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_at");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.Property(e => e.UpdatedAt).HasColumnName("Updated_at");
            });

            modelBuilder.Entity<WalletTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WalletTMP");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_at");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdwalletTienda).HasColumnName("IDWalletTienda");

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.Property(e => e.UpdatedAt).HasColumnName("Updated_at");
            });

            modelBuilder.Entity<M66002>().HasNoKey();
            modelBuilder.Entity<M64001>().HasNoKey();
            modelBuilder.Entity<ProductoCosto>().HasNoKey();
            modelBuilder.Entity<MostrarListaDePrecio>().HasNoKey();
            modelBuilder.Entity<MostrarListasDePrecio>().HasNoKey();
            modelBuilder.Entity<BuscarProductoOfertaDia>().HasNoKey();
            modelBuilder.Entity<SpListaProductosOferta>().HasNoKey();
            modelBuilder.Entity<SaveDetalleProducto>().HasNoKey();
            modelBuilder.Entity<SpListaProdHablador>().HasNoKey();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
