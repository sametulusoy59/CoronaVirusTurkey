USE [CoronaTurkeyData]
GO
/****** Object:  Table [dbo].[corona]    Script Date: 13.4.2020 22:54:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[corona](
	[Gün] [nchar](10) NULL,
	[GünlükVaka] [nchar](10) NULL,
	[ToplamVaka] [nchar](10) NULL,
	[Gunlukiyilesensayisi] [nchar](10) NULL,
	[Toplamiyilesensayisi] [nchar](10) NULL,
	[Gunlukolensayisi] [nchar](10) NULL,
	[Toplamolensayisi] [nchar](10) NULL,
	[Gunluktestsayisi] [nchar](10) NULL,
	[Toplamtestsayisi] [nchar](10) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[corona] ON 

INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'8         ', N'168       ', N'359       ', N'0         ', N'0         ', N'2         ', N'4         ', N'1981      ', N'11636     ', 1)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'9         ', N'311       ', N'670       ', N'0         ', N'0         ', N'5         ', N'9         ', N'3656      ', N'15292     ', 2)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'10        ', N'277       ', N'947       ', N'0         ', N'0         ', N'12        ', N'21        ', N'2953      ', N'18245     ', 3)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'11        ', N'289       ', N'1236      ', N'0         ', N'0         ', N'9         ', N'30        ', N'2100      ', N'20345     ', 4)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'12        ', N'293       ', N'1529      ', N'0         ', N'0         ', N'7         ', N'37        ', N'3672      ', N'24017     ', 5)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'13        ', N'343       ', N'1972      ', N'0         ', N'0         ', N'7         ', N'44        ', N'3952      ', N'27969     ', 6)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'14        ', N'561       ', N'2433      ', N'0         ', N'0         ', N'15        ', N'59        ', N'5035      ', N'33004     ', 7)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'15        ', N'1196      ', N'3629      ', N'0         ', N'0         ', N'16        ', N'75        ', N'7286      ', N'40290     ', 8)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'16        ', N'2069      ', N'5698      ', N'42        ', N'42        ', N'17        ', N'92        ', N'7533      ', N'47823     ', 9)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'17        ', N'1704      ', N'7402      ', N'28        ', N'70        ', N'16        ', N'108       ', N'7641      ', N'55464     ', 10)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'18        ', N'1815      ', N'9217      ', N'35        ', N'105       ', N'23        ', N'131       ', N'9982      ', N'65446     ', 11)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'19        ', N'1610      ', N'10827     ', N'57        ', N'162       ', N'37        ', N'168       ', N'11535     ', N'76981     ', 12)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'20        ', N'2704      ', N'13531     ', N'81        ', N'243       ', N'46        ', N'214       ', N'15422     ', N'92403     ', 13)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'21        ', N'2148      ', N'15679     ', N'90        ', N'333       ', N'63        ', N'277       ', N'14396     ', N'106799    ', 14)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'22        ', N'2456      ', N'18135     ', N'82        ', N'415       ', N'79        ', N'356       ', N'18757     ', N'125556    ', 15)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'23        ', N'2786      ', N'20921     ', N'69        ', N'484       ', N'69        ', N'425       ', N'16160     ', N'141716    ', 16)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'24        ', N'3013      ', N'23934     ', N'302       ', N'786       ', N'76        ', N'501       ', N'19664     ', N'161380    ', 17)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'25        ', N'3135      ', N'27069     ', N'256       ', N'1042      ', N'73        ', N'574       ', N'20065     ', N'181445    ', 18)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'26        ', N'3148      ', N'30217     ', N'284       ', N'1326      ', N'75        ', N'649       ', N'21400     ', N'202845    ', 19)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'27        ', N'3892      ', N'34109     ', N'256       ', N'1582      ', N'76        ', N'725       ', N'20023     ', N'222868    ', 20)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'28        ', N'4117      ', N'38226     ', N'264       ', N'1846      ', N'87        ', N'812       ', N'24900     ', N'247768    ', 21)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'29        ', N'4056      ', N'42282     ', N'296       ', N'2142      ', N'96        ', N'908       ', N'28578     ', N'276346    ', 22)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'30        ', N'4747      ', N'47029     ', N'281       ', N'2423      ', N'98        ', N'1006      ', N'30864     ', N'307210    ', 23)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'31        ', N'5138      ', N'52167     ', N'542       ', N'2965      ', N'95        ', N'1101      ', N'33170     ', N'340380    ', 24)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'32        ', N'4789      ', N'56956     ', N'481       ', N'3446      ', N'97        ', N'1198      ', N'35720     ', N'376100    ', 31)
INSERT [dbo].[corona] ([Gün], [GünlükVaka], [ToplamVaka], [Gunlukiyilesensayisi], [Toplamiyilesensayisi], [Gunlukolensayisi], [Toplamolensayisi], [Gunluktestsayisi], [Toplamtestsayisi], [id]) VALUES (N'33        ', N'4093      ', N'61049     ', N'511       ', N'3957      ', N'98        ', N'1296      ', N'34456     ', N'410556    ', 32)
SET IDENTITY_INSERT [dbo].[corona] OFF
