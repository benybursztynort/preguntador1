USE [Preguntados]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 16/8/2023 11:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Foto] [varchar](1000) NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dificultades]    Script Date: 16/8/2023 11:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dificultades](
	[IdDificultad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Dificultades] PRIMARY KEY CLUSTERED 
(
	[IdDificultad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preguntas]    Script Date: 16/8/2023 11:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preguntas](
	[IdPregunta] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoria] [int] NULL,
	[IdDificultad] [int] NULL,
	[Enunciado] [varchar](50) NULL,
	[Foto] [varchar](1000) NULL,
 CONSTRAINT [PK_Preguntas] PRIMARY KEY CLUSTERED 
(
	[IdPregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Respuestas]    Script Date: 16/8/2023 11:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Respuestas](
	[IdRespuesta] [int] IDENTITY(1,1) NOT NULL,
	[IdPregunta] [int] NULL,
	[Opcion] [int] NULL,
	[Contenido] [varchar](50) NULL,
	[Correcta] [bit] NULL,
	[Foto] [varchar](1000) NULL,
 CONSTRAINT [PK_respuestas] PRIMARY KEY CLUSTERED 
(
	[IdRespuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([IdCategoria], [Nombre], [Foto]) VALUES (1, N'Deportes', N'https://tn.com.ar/resizer/TvBXd9LcDQYoSIU9ASgCIe3rP2E=/767x0/smart/filters:format(webp)/arc-anglerfish-arc2-prod-artear.s3.amazonaws.com/public/Z5CCK4LQ44JIM6BWFUMIPN2SZI.jpg')
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre], [Foto]) VALUES (2, N'Geografia', N'Nhttps://humanidades.com/wp-content/uploads/2017/07/geografia-1-e1571191548230.jpgULL')
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre], [Foto]) VALUES (3, N'Famosos', N'https://static.vecteezy.com/system/resources/previews/007/126/739/original/question-mark-icon-free-vector.jpg')
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre], [Foto]) VALUES (4, N'Ascenso', N'https://media.tycsports.com/files/2022/06/17/441583/ascenso_1440x810_wmk.webp')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Dificultades] ON 

INSERT [dbo].[Dificultades] ([IdDificultad], [Nombre]) VALUES (1, N'Facil')
INSERT [dbo].[Dificultades] ([IdDificultad], [Nombre]) VALUES (2, N'Normal')
INSERT [dbo].[Dificultades] ([IdDificultad], [Nombre]) VALUES (3, N'Dificil')
INSERT [dbo].[Dificultades] ([IdDificultad], [Nombre]) VALUES (4, N'Imposible')
SET IDENTITY_INSERT [dbo].[Dificultades] OFF
GO
SET IDENTITY_INSERT [dbo].[Preguntas] ON 

INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (1, 1, 1, N'¿Cuantos mundiales tiene Argentina?', N'https://fotos.perfil.com/2022/12/18/trim/1280/720/argentina-campeon-del-mundo-1475237.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (2, 1, 1, N'¿En que equipo juega actualmente Messi?', N'https://cnnespanol.cnn.com/wp-content/uploads/2023/08/230807092957-02-messi-inter-miami-fc-dallas-full-169.jpeg?quality=100&strip=info')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (3, 2, 1, N'¿En que continente se encuentra Brasil?', N'https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Flag_of_Brazil.svg/1200px-Flag_of_Brazil.svg.png')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (4, 2, 1, N'¿De que color es la bandera de Francia?', N'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAMgAAACFCAMAAAApQEceAAAAD1BMVEUAI5X////tKTlUa7jzcHvUxjbIAAAAiUlEQVR4nO3PMQEAMAgDMGDzrxkRfTgSB6mKvY79ieUPERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERERGRm5EFiZhqgvuGvCoAAAAASUVORK5CYII=')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (5, 3, 1, N'¿Quien es el principal actor de Spiderman?', N'https://s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2018/11/16142656/Spiderman.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (6, 3, 1, N'¿Quien es el principal actor de Ratatouille?', N'https://static.wikia.nocookie.net/disney/images/7/70/Remy.png/revision/latest?cb=20130307114718&path-prefix=es')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (7, 4, 1, N'¿Quien es el mas grande del ascenso?', N'https://upload.wikimedia.org/wikipedia/commons/8/8d/CANCH_Oficial.png')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (8, 4, 1, N'¿Quien se fue al descenso en 2012?', N'https://media.lacapital.com.ar/p/cb4d640a522ec68fc26528b50b21dd3a/adjuntos/205/imagenes/030/192/0030192714/642x0/smart/river-descensojpg.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (9, 1, 2, N'¿Quien es 
Michael Phelps?', N'https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/media/image/2016/10/199672-michael-phelps-jjoo-rio-2016.jpg?tf=3840x')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (10, 1, 2, N'¿Quienes jugaron la ultima final de Champions?', N'https://editorial.uefa.com/resources/0282-18407ce93c02-ed5a13ae21cf-1000/fbl-eur-c1-man_city-inter.jpeg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (11, 2, 2, N'¿En que continente queda israel?', N'https://cdn.zendalibros.com/wp-content/uploads/2023/05/banderas-israel.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (12, 2, 2, N'¿Qué banderas tienen los mismo s colores?', N'https://img.freepik.com/vector-premium/maqueta-banderas-escritorio-italia-vs-mexico-ilustracion-vectorial-3d-aislada-banderas-mesa-italianas_75010-10369.jpg?w=2000')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (13, 3, 2, N'¿Cual de estos cantantes falleció', N'https://www.revistavea.com.co/resizer/MYYJfndRwIfZEU2ACkNM2UDzyb8=/arc-anglerfish-arc2-prod-elespectador/public/VFIBXMC62FHEHPEWWOFLVEP6EA.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (14, 3, 2, N'¿Cual de estos cantantes canta trap?', N'https://www.losandes.com.ar/resizer/GpzcquOJ0tzK4s2RW_fdwhohjiQ=/980x640/smart/filters:quality(75):format(webp)/cloudfront-us-east-1.images.arcpublishing.com/grupoclarin/CFYJ2LLADZFVRDBLDQUPZDSHJI.png')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (15, 4, 2, N'¿Como le dicen a Atlanta?', N'https://upload.wikimedia.org/wikipedia/commons/0/0b/C.a._atlanta.png')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (16, 4, 2, N'¿Como le dicen a Nueva chicago?', N'https://upload.wikimedia.org/wikipedia/commons/8/8d/CANCH_Oficial.png')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (17, 1, 3, N'¿Cuantas veces gano federer el ATP de Wimbledon?', N'https://imagenes.elpais.com/resizer/D07t6Bf-tUmz4mU6KIDI9sg6vvg=/1960x1103/ep01.epimg.net/deportes/imagenes/2017/07/16/actualidad/1500164000_705818_1500300917_noticia_fotograma.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (18, 1, 3, N'¿Que jugador gano mas anillos en la NBA?', N'https://diarioeco.com.do/wp-content/uploads/2022/08/FZGCTiPXkAAHR5e.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (19, 2, 3, N'¿Cuál es el río más largo del mundo?', N'https://miviaje.com/wp-content/uploads/2019/09/rio-nilo-asuan.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (20, 2, 3, N'¿Cuál es la capital de Canadá?', N'https://www.gostudycanada.com/wp-content/uploads/2021/09/iStock-1212275972-scaled.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (21, 3, 3, N'¿Cuál es el nombre del creador de  Harry Potter?
', N'https://www.cronista.com/files/image/640/640481/64996b47bb07f.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (22, 3, 3, N'¿Quien creo la Mona Lisa?', N'https://www.muycomputer.com/wp-content/uploads/2019/05/MonaLisa.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (23, 4, 3, N'¿Que tuvo de particular la temporada 2014?', N'https://3.bp.blogspot.com/-sutUn5sxBpc/VA7yqeJ7LGI/AAAAAAAAp-s/4uEuwXogpdM/s1600/b%2Bnacional%2B2.png')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (24, 4, 3, N'¿En que año se creo la b nacional ?', N'https://upload.wikimedia.org/wikipedia/commons/6/6f/Zahl_1986.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (25, 1, 4, N'¿Cual es la distancia total en KM?', N'https://media.tycsports.com/files/2021/08/04/315680/pista-estadio-olimpico-tokio-2020_1440x810_wmk.jpg?v=5')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (26, 1, 4, N'¿Cuál es el deporte nacional de Japón?', N'https://c7.staticflickr.com/8/7197/6805697998_71867f56fb_c.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (27, 2, 4, N'¿Cuál es la capital de Australia?', N'https://australianwayeducation.com/wp-content/uploads/canberra-capital-de-australia.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (28, 2, 4, N'¿Cuál es el país más poblado del mundo?', N'https://lu17.com/download/multimedia.normal.85ca29141a4fc11c.494e44494120455320454c205041c38d53204dc3815320504f424c41444f20445f6e6f726d616c2e77656270.webp')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (29, 3, 4, N'¿Cual es el nombre completo de Lady gaga?', N'https://www.radiostudiostar.com/wp-content/uploads/2023/08/lady-gaga-performs-on-stage-during-the-opening-night-of-the-news-photo-1675598025.jpg')
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (30, 3, 4, N'¿', NULL)
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (31, 4, 4, N'¿', NULL)
INSERT [dbo].[Preguntas] ([IdPregunta], [IdCategoria], [IdDificultad], [Enunciado], [Foto]) VALUES (32, 4, 4, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Preguntas] OFF
GO
ALTER TABLE [dbo].[Respuestas]  WITH CHECK ADD  CONSTRAINT [FK_respuestas_Preguntas] FOREIGN KEY([IdPregunta])
REFERENCES [dbo].[Preguntas] ([IdPregunta])
GO
ALTER TABLE [dbo].[Respuestas] CHECK CONSTRAINT [FK_respuestas_Preguntas]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerCategorias]    Script Date: 16/8/2023 11:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerCategorias]
@idcategoria int 
AS
BEGIN 
SELECT * FROM Categorias
WHERE IdCategoria = @idcategoria
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerDificultades]    Script Date: 16/8/2023 11:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerDificultades]
@iddificultad int 
AS
BEGIN 
SELECT * FROM Dificultades
WHERE IdDificultad = @iddificultad 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPreguntas]    Script Date: 16/8/2023 11:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPreguntas]
@iddificultad int , @idcategoria int
AS
BEGIN 
SELECT * FROM Preguntas
WHERE 
IdDificultad = @iddificultad and IdCategoria = @idcategoria
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerRespuestas]    Script Date: 16/8/2023 11:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE
[dbo].[sp_ObtenerRespuestas] @idpreg int 
AS
BEGIN 
SELECT * FROM Respuestas 
WHERE IdPregunta = @idpreg
END
GO
