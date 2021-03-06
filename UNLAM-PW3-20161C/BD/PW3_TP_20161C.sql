USE [master]
GO
/****** Object:  Database [PW3_TP_20161C]    Script Date: 05/30/2016 01:42:12 ******/
CREATE DATABASE [PW3_TP_20161C] 

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PW3_TP_20161C].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PW3_TP_20161C] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET ANSI_NULLS OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET ANSI_PADDING OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET ARITHABORT OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [PW3_TP_20161C] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [PW3_TP_20161C] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [PW3_TP_20161C] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET  DISABLE_BROKER
GO
ALTER DATABASE [PW3_TP_20161C] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [PW3_TP_20161C] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [PW3_TP_20161C] SET  READ_WRITE
GO
ALTER DATABASE [PW3_TP_20161C] SET RECOVERY FULL
GO
ALTER DATABASE [PW3_TP_20161C] SET  MULTI_USER
GO
ALTER DATABASE [PW3_TP_20161C] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [PW3_TP_20161C] SET DB_CHAINING OFF
GO
USE [PW3_TP_20161C]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 05/30/2016 01:42:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](200) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FechaRegistracion] [datetime] NOT NULL,
	[IdTipoUsuario] [tinyint] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventos]    Script Date: 05/30/2016 01:42:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[IdEvento] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Descripcion] [nvarchar](700) NOT NULL,
	[CantidadComensales] [int] NOT NULL,
	[Ubicacion] [nvarchar](400) NOT NULL,
	[NombreFoto] [nvarchar](50) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED 
(
	[IdEvento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recetas]    Script Date: 05/30/2016 01:42:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recetas](
	[IdReceta] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[TiempoCoccion] [int] NOT NULL,
	[Descripcion] [nvarchar](3000) NOT NULL,
	[Ingredientes] [nvarchar](3000) NOT NULL,
	[Tipo] [tinyint] NOT NULL,
 CONSTRAINT [PK_Recetas] PRIMARY KEY CLUSTERED 
(
	[IdReceta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservas]    Script Date: 05/30/2016 01:42:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservas](
	[IdReserva] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL, 
	[IdEvento] [int] NOT NULL,
	[IdReceta] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_Reservas] PRIMARY KEY CLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventosRecetas]    Script Date: 05/30/2016 01:42:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventosRecetas](
	[IdEvento] [int] NOT NULL,
	[IdReceta] [int] NOT NULL,
 CONSTRAINT [PK_EventosRecetas] PRIMARY KEY CLUSTERED 
(
	[IdEvento] ASC,
	[IdReceta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comentarios]    Script Date: 05/30/2016 01:42:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comentarios](
	[IdComentario] [int] IDENTITY(1,1) NOT NULL,
	[IdEvento] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Puntuacion] [tinyint] NOT NULL,
	[Comentarios] [nvarchar](400) NOT NULL,
 CONSTRAINT [PK_Comentarios] PRIMARY KEY CLUSTERED 
(
	[IdComentario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Eventos_Usuarios]    Script Date: 05/30/2016 01:42:14 ******/
ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [FK_Eventos_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [FK_Eventos_Usuarios]
GO
/****** Object:  ForeignKey [FK_Recetas_Usuarios]    Script Date: 05/30/2016 01:42:14 ******/
ALTER TABLE [dbo].[Recetas]  WITH CHECK ADD  CONSTRAINT [FK_Recetas_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Recetas] CHECK CONSTRAINT [FK_Recetas_Usuarios]
GO
/****** Object:  ForeignKey [FK_Reservas_Eventos]    Script Date: 05/30/2016 01:42:14 ******/
ALTER TABLE [dbo].[Reservas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_Eventos] FOREIGN KEY([IdEvento])
REFERENCES [dbo].[Eventos] ([IdEvento])
GO
ALTER TABLE [dbo].[Reservas] CHECK CONSTRAINT [FK_Reservas_Eventos]
GO
/****** Object:  ForeignKey [FK_Reservas_Recetas]    Script Date: 05/30/2016 01:42:14 ******/
ALTER TABLE [dbo].[Reservas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_Recetas] FOREIGN KEY([IdReceta])
REFERENCES [dbo].[Recetas] ([IdReceta])
GO
ALTER TABLE [dbo].[Reservas] CHECK CONSTRAINT [FK_Reservas_Recetas]
GO
/****** Object:  ForeignKey [FK_Reservas_Usuarios]    Script Date: 05/30/2016 01:42:14 ******/
ALTER TABLE [dbo].[Reservas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Reservas] CHECK CONSTRAINT [FK_Reservas_Usuarios]
GO
/****** Object:  ForeignKey [FK_EventosRecetas_Eventos]    Script Date: 05/30/2016 01:42:14 ******/
ALTER TABLE [dbo].[EventosRecetas]  WITH CHECK ADD  CONSTRAINT [FK_EventosRecetas_Eventos] FOREIGN KEY([IdEvento])
REFERENCES [dbo].[Eventos] ([IdEvento])
GO
ALTER TABLE [dbo].[EventosRecetas] CHECK CONSTRAINT [FK_EventosRecetas_Eventos]
GO
/****** Object:  ForeignKey [FK_EventosRecetas_Recetas]    Script Date: 05/30/2016 01:42:14 ******/
ALTER TABLE [dbo].[EventosRecetas]  WITH CHECK ADD  CONSTRAINT [FK_EventosRecetas_Recetas] FOREIGN KEY([IdReceta])
REFERENCES [dbo].[Recetas] ([IdReceta])
GO
ALTER TABLE [dbo].[EventosRecetas] CHECK CONSTRAINT [FK_EventosRecetas_Recetas]
GO
/****** Object:  ForeignKey [FK_Comentarios_Eventos]    Script Date: 05/30/2016 01:42:14 ******/
ALTER TABLE [dbo].[Comentarios]  WITH CHECK ADD  CONSTRAINT [FK_Comentarios_Eventos] FOREIGN KEY([IdEvento])
REFERENCES [dbo].[Eventos] ([IdEvento])
GO
ALTER TABLE [dbo].[Comentarios] CHECK CONSTRAINT [FK_Comentarios_Eventos]
GO
/****** Object:  ForeignKey [FK_Comentarios_Usuarios]    Script Date: 05/30/2016 01:42:14 ******/
ALTER TABLE [dbo].[Comentarios]  WITH CHECK ADD  CONSTRAINT [FK_Comentarios_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Comentarios] CHECK CONSTRAINT [FK_Comentarios_Usuarios]
GO
