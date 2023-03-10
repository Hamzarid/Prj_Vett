USE [Vet_Bdd]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 2023-01-06 18:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Login] [nvarchar](max) NOT NULL,
	[pwd] [nvarchar](max) NOT NULL,
	[idAdmin] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[idAdmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 2023-01-06 18:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[idClient] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](50) NULL,
	[Prenom] [nvarchar](50) NULL,
	[Adresse] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Tel] [nvarchar](max) NULL,
	[Reference] [nvarchar](max) NULL,
	[Login] [nvarchar](max) NULL,
	[Pwd] [nvarchar](max) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[idClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client_Patient]    Script Date: 2023-01-06 18:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client_Patient](
	[idRelation] [int] IDENTITY(1,1) NOT NULL,
	[idPatient] [int] NULL,
	[idClient] [int] NULL,
 CONSTRAINT [PK_Client_Patient] PRIMARY KEY CLUSTERED 
(
	[idRelation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnos_Prediction]    Script Date: 2023-01-06 18:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnos_Prediction](
	[id_Diangnos] [int] IDENTITY(1,1) NOT NULL,
	[Fievre] [int] NOT NULL,
	[Henaturie] [int] NOT NULL,
	[Pent_Dapp] [int] NOT NULL,
	[Oxalote] [int] NOT NULL,
	[Conjonctive] [int] NOT NULL,
	[Colique] [int] NOT NULL,
	[Diachere] [int] NOT NULL,
	[Polyrie] [int] NOT NULL,
	[TRC] [int] NOT NULL,
	[Lethargie] [int] NOT NULL,
	[hyperunicerie] [int] NOT NULL,
	[Info_Paro] [int] NOT NULL,
	[Basophilie] [int] NOT NULL,
	[Chlomydiose] [int] NOT NULL,
	[Icterie] [int] NOT NULL,
	[LaMaladie_Predict] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Diagnos_Prediction] PRIMARY KEY CLUSTERED 
(
	[id_Diangnos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 2023-01-06 18:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[idPatient] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Date_Naissance] [date] NULL,
	[Espece] [nvarchar](50) NULL,
	[Race] [nvarchar](50) NULL,
	[Couleur] [nvarchar](50) NULL,
	[MicroPuce] [nvarchar](50) NULL,
	[Sexe] [nvarchar](50) NULL,
	[Sterilise] [nvarchar](50) NULL,
	[Alerte_Medical] [nvarchar](max) NULL,
	[Vaccination] [nvarchar](max) NULL,
	[image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[idPatient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produit]    Script Date: 2023-01-06 18:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produit](
	[idProduit] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](50) NOT NULL,
	[Prix] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Quantite_Dispo] [int] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Produit] PRIMARY KEY CLUSTERED 
(
	[idProduit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RDV]    Script Date: 2023-01-06 18:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RDV](
	[idRdv] [int] IDENTITY(1,1) NOT NULL,
	[Raison] [nvarchar](max) NOT NULL,
	[idClient] [int] NOT NULL,
	[idPatient] [int] NOT NULL,
	[PlageHoraire] [datetime] NOT NULL,
	[Details] [nvarchar](max) NOT NULL,
	[fin] [datetime] NOT NULL,
 CONSTRAINT [PK_RDV] PRIMARY KEY CLUSTERED 
(
	[idRdv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([Login], [pwd], [idAdmin]) VALUES (N'Admin', N'123', N'H5DSA8AS  ')
INSERT [dbo].[Admin] ([Login], [pwd], [idAdmin]) VALUES (N'Amin_2', N'123', N'UQW85DA   ')
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([idClient], [Nom], [Prenom], [Adresse], [Email], [Tel], [Reference], [Login], [Pwd]) VALUES (51, N'hamza h', N'ridouane h', N'3335 rue jaqueline', N'Hamzaridouane44@gmail.com', N'4389931030', N'Facebook', N'Hamzarid', N' 123')
INSERT [dbo].[Client] ([idClient], [Nom], [Prenom], [Adresse], [Email], [Tel], [Reference], [Login], [Pwd]) VALUES (52, N'hamza', N'ridouane', N'3335 rue jaqueline', N'Hamzaridouane44@gmail.com', N'4389931030', N'dsadsadasdas', N'test', N'testtest')
INSERT [dbo].[Client] ([idClient], [Nom], [Prenom], [Adresse], [Email], [Tel], [Reference], [Login], [Pwd]) VALUES (1002, N'Nezar', N'Zemlali', N'3335 rue jaqueline', N'Hamzaridouane44@gmail.com', N'4389931030', N'Facebook', N'nizar', N'12345678')
INSERT [dbo].[Client] ([idClient], [Nom], [Prenom], [Adresse], [Email], [Tel], [Reference], [Login], [Pwd]) VALUES (1003, N'grimeh', N'hamza', N'3533 rue jaqueline', N'Hamzaridouane44@gmail.com', N'4389931030', N'hah', N'grimeh', N'123')
INSERT [dbo].[Client] ([idClient], [Nom], [Prenom], [Adresse], [Email], [Tel], [Reference], [Login], [Pwd]) VALUES (3002, N'Steve', N'Ataky', N'3335 rue jaqueline', N'jija@gmail.com', N'4389931030', N'Facebook', N'Steve', N'Hamza123')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Client_Patient] ON 

INSERT [dbo].[Client_Patient] ([idRelation], [idPatient], [idClient]) VALUES (2, 3008, 1002)
INSERT [dbo].[Client_Patient] ([idRelation], [idPatient], [idClient]) VALUES (3, 3008, 2002)
INSERT [dbo].[Client_Patient] ([idRelation], [idPatient], [idClient]) VALUES (1002, 4023, 1002)
INSERT [dbo].[Client_Patient] ([idRelation], [idPatient], [idClient]) VALUES (1003, 4025, 1002)
INSERT [dbo].[Client_Patient] ([idRelation], [idPatient], [idClient]) VALUES (1004, 4026, 1002)
SET IDENTITY_INSERT [dbo].[Client_Patient] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (3008, N'Doggy', 5, CAST(N'2023-01-04' AS Date), N'Chien', N'Mouille', N'Gris', N'Oui', N'Male', N'Oui', N'Non', N'Oui', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4008, N'Puppu', 3, NULL, N'humain', N'rare', N'Gris', N'yes', N'Femelle', N'NON', N'asfadsf', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4009, N'liop', 2, NULL, N'chat', N'poy', N'Gris', N'yes', N'Femelle', N'NON', N'none', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4010, N'liop', 2, NULL, N'chat', N'poy', N'Gris', N'yes', N'Femelle', N'NON', N'none', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4011, N'liop', 2, NULL, N'chat', N'poy', N'Gris', N'yes', N'Femelle', N'NON', N'none', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4012, N'liop', 2, NULL, N'chat', N'poy', N'Gris', N'yes', N'Femelle', N'NON', N'none', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4013, N'liop', 2, NULL, N'chat', N'poy', N'Gris', N'yes', N'Femelle', N'NON', N'none', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4014, N'liop', 2, NULL, N'chat', N'poy', N'Gris', N'yes', N'Femelle', N'NON', N'none', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4015, N'Milo', 2, NULL, N'chat', N'dwq', N'Gris', N'yes', N'Femelle', N'OUI', N'fds', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4016, N'Milo', 2, NULL, N'chat', N'dwq', N'Gris', N'yes', N'Femelle', N'OUI', N'fds', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4017, N'Milo', 2, NULL, N'chat', N'dwq', N'Gris', N'yes', N'Femelle', N'OUI', N'fds', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4018, N'Milo', 2, NULL, N'chat', N'dwq', N'Gris', N'yes', N'Femelle', N'OUI', N'fds', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4019, N'Milo', 2, NULL, N'chat', N'dwq', N'Gris', N'yes', N'Femelle', N'OUI', N'fds', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4020, N'Milo', 2, NULL, N'chat', N'dwq', N'Gris', N'yes', N'Femelle', N'OUI', N'fds', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4021, N'Milo', 2, NULL, N'chat', N'dwq', N'Gris', N'yes', N'Femelle', N'OUI', N'fds', N'NON', NULL)
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4022, N'Milo', 2, NULL, N'chat', N'dwq', N'Gris', N'yes', N'Femelle', N'OUI', N'fds', N'NON', N'C:\Users\User\Desktop\VetApp_prj\VetApp_prj\wwwroot\images')
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4023, N'LOUPPP', 1, NULL, N'Chien', N'W9', N'Roux', N'yes', N'Mâle', N'NON', N'w1', N'NON', N'C:\Users\User\Desktop\VetApp_prj\VetApp_prj\wwwroot\images')
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4024, N'LOUPPP', 1, NULL, N'Chien', N'W9', N'Roux', N'yes', N'Mâle', N'NON', N'w1', N'NON', N'C:\Users\User\Desktop\VetApp_prj\VetApp_prj\wwwroot\images')
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4025, N'aymen lkelb', 32, NULL, N'mAahanien', N'Hennaaa', N'noir', N'Non', N'Mâle', N'NON', N'Ki3eed', N'NON', N'WIN_20220421_16_07_44_Pro.jpg')
INSERT [dbo].[Patient] ([idPatient], [Nom], [Age], [Date_Naissance], [Espece], [Race], [Couleur], [MicroPuce], [Sexe], [Sterilise], [Alerte_Medical], [Vaccination], [image]) VALUES (4026, N'kMILIA', 1, NULL, N'chat', N'SIAMISA', N'Gris', N'Non', N'Femelle', N'OUI', N'oUI', N'OUI', N'cat.jpg')
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
SET IDENTITY_INSERT [dbo].[Produit] ON 

INSERT [dbo].[Produit] ([idProduit], [Nom], [Prix], [Description], [Quantite_Dispo], [Type], [Image]) VALUES (2, N'Royale Canin Siamoi', 95, N'La formule ADULTE INSTINCTIF fines tranches en sauce est conçue pour les chats adultes de 1 à 7 ans.', 25, N'Humide, Chat', N'images/Article1.jpg')
INSERT [dbo].[Produit] ([idProduit], [Nom], [Prix], [Description], [Quantite_Dispo], [Type], [Image]) VALUES (6, N'Royale Canin Adulte', 88, N'Pour les chats de plus de 12 mois à 12 ans.', 20, N'Sèche, Chat', N'images/Article2.jpg')
INSERT [dbo].[Produit] ([idProduit], [Nom], [Prix], [Description], [Quantite_Dispo], [Type], [Image]) VALUES (8, N'Royale Canin BEAUTÉ INTENSE', 100, N'La formule BEAUTÉ INTENSE fines tranches en sauce présente un équilibre nutritionnel précis pour assurer la santé de la peau et la beauté du pelage chez les chats adultes de 1 à 7 ans.', 10, N'Humide, Chat', N'images/Article3.jpg')
INSERT [dbo].[Produit] ([idProduit], [Nom], [Prix], [Description], [Quantite_Dispo], [Type], [Image]) VALUES (1003, N'Pill Assist Medium & Large Dog', 80, N'A veterinary exclusive treat that makes giving medicine to medium and large dogs easy', 15, N'Chien', N'images/Article4.jpg')
INSERT [dbo].[Produit] ([idProduit], [Nom], [Prix], [Description], [Quantite_Dispo], [Type], [Image]) VALUES (1005, N'Golden Retriever Adult Dry Dog Food', 70, N'Royal Canin Golden Retriever Adult dry dog food is designed to meet the nutritional needs of purebred Golden Retrievers 15 months and older', 65, N'Chien', N'images/Article5.jpg')
INSERT [dbo].[Produit] ([idProduit], [Nom], [Prix], [Description], [Quantite_Dispo], [Type], [Image]) VALUES (1007, N'Poodle Pouch Dog Food', 90, N'Complete and balanced nutrition for adult Poodles over 10 months old', 20, N'Chien', N'images/Article6.jpg')
INSERT [dbo].[Produit] ([idProduit], [Nom], [Prix], [Description], [Quantite_Dispo], [Type], [Image]) VALUES (1008, N'Giant Puppy Dry Dog Food', 67, N'Royal Canin Giant Puppy dry dog food is tailor-made for puppies up to 8 months old with an expected adult weight of over 100 lbs.', 99, N'Chien', N'images/Article7.jpg')
INSERT [dbo].[Produit] ([idProduit], [Nom], [Prix], [Description], [Quantite_Dispo], [Type], [Image]) VALUES (1009, N'Large Joint Care Dry Dog Food', 110, N'Dry dog food formulated for large adult dogs 15 months and older weighing 56-100 lbs. to support healthy joints', 60, N'Chien', N'images/Article8.jpg')
SET IDENTITY_INSERT [dbo].[Produit] OFF
GO
SET IDENTITY_INSERT [dbo].[RDV] ON 

INSERT [dbo].[RDV] ([idRdv], [Raison], [idClient], [idPatient], [PlageHoraire], [Details], [fin]) VALUES (1, N'Nothing', 1002, 4008, CAST(N'2023-04-01T12:00:00.000' AS DateTime), N'hihaa', CAST(N'2023-04-01T03:00:00.000' AS DateTime))
INSERT [dbo].[RDV] ([idRdv], [Raison], [idClient], [idPatient], [PlageHoraire], [Details], [fin]) VALUES (3, N'Nizar test', 1002, 4030, CAST(N'2023-01-01T13:33:00.000' AS DateTime), N'jaja', CAST(N'2023-01-01T15:00:00.000' AS DateTime))
INSERT [dbo].[RDV] ([idRdv], [Raison], [idClient], [idPatient], [PlageHoraire], [Details], [fin]) VALUES (6, N'Chirurgie', 1001, 2004, CAST(N'2023-10-01T14:00:00.000' AS DateTime), N'hiha', CAST(N'2023-10-01T18:00:00.000' AS DateTime))
INSERT [dbo].[RDV] ([idRdv], [Raison], [idClient], [idPatient], [PlageHoraire], [Details], [fin]) VALUES (8, N'Congé Clinique fermé', 0, 0, CAST(N'2023-11-01T10:00:00.000' AS DateTime), N'Rien', CAST(N'2023-12-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[RDV] OFF
GO
