USE [eShop_prod]
GO
INSERT [dbo].[AppUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [Dob]) VALUES (N'c062bfaa-ad29-4079-8049-08dbc3171c70', N'test', N'TEST', N'test@gmail.com', N'TEST@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEPHE9M6G/FELNdS44HUIDaO8jpzqlbkMb29t/DLV3UZudxi9YhhEiIplokikdg6FxA==', N'UE6444WIIBO6NRTPB2WURBPNFIGGGJE5', N'a14874e7-46cb-4822-bb3e-9cf675363fc9', N'0398321874', 0, 0, NULL, 1, 0, N'test', N'test', CAST(N'2001-11-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[AppUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [Dob]) VALUES (N'7af97aee-9a3f-4008-ac98-3ce383de2ec0', N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAEK1dDSFHe22bvrV9qWMjToc8TinqWNnNly+0OIc9uq247lzwrPIyVX87WzUd9mWlnA==', N'5LZMOGVQESQM57STUGSPIGQKKNFWIQ7N', N'1358d85e-96c7-4088-b888-33473944a7e4', NULL, 0, 0, NULL, 0, 0, N'Ha', N'Hoang', CAST(N'1999-12-05T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Price], [OriginalPrice], [Stock], [ViewCount], [DateCreated], [IsFeatured]) VALUES (1, CAST(2000000.00 AS Decimal(18, 2)), CAST(1000000.00 AS Decimal(18, 2)), 4, 0, CAST(N'2023-10-04T19:02:31.6522814' AS DateTime2), 1)
INSERT [dbo].[Products] ([Id], [Price], [OriginalPrice], [Stock], [ViewCount], [DateCreated], [IsFeatured]) VALUES (2, CAST(3000000.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), 6, 0, CAST(N'2023-10-04T19:02:31.6522832' AS DateTime2), 1)
INSERT [dbo].[Products] ([Id], [Price], [OriginalPrice], [Stock], [ViewCount], [DateCreated], [IsFeatured]) VALUES (4, CAST(3000000.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), 3, 0, CAST(N'2023-09-25T22:16:06.6500608' AS DateTime2), 1)
INSERT [dbo].[Products] ([Id], [Price], [OriginalPrice], [Stock], [ViewCount], [DateCreated], [IsFeatured]) VALUES (5, CAST(400000.00 AS Decimal(18, 2)), CAST(300000.00 AS Decimal(18, 2)), 3, 0, CAST(N'2023-09-25T23:01:31.2415215' AS DateTime2), 1)
INSERT [dbo].[Products] ([Id], [Price], [OriginalPrice], [Stock], [ViewCount], [DateCreated], [IsFeatured]) VALUES (7, CAST(500000.00 AS Decimal(18, 2)), CAST(400000.00 AS Decimal(18, 2)), 6, 0, CAST(N'2023-09-25T23:04:47.4820285' AS DateTime2), 0)
INSERT [dbo].[Products] ([Id], [Price], [OriginalPrice], [Stock], [ViewCount], [DateCreated], [IsFeatured]) VALUES (8, CAST(300000.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), 8, 0, CAST(N'2023-09-25T23:06:33.0358660' AS DateTime2), 0)
INSERT [dbo].[Products] ([Id], [Price], [OriginalPrice], [Stock], [ViewCount], [DateCreated], [IsFeatured]) VALUES (9, CAST(350000.00 AS Decimal(18, 2)), CAST(300000.00 AS Decimal(18, 2)), 5, 0, CAST(N'2023-09-25T23:07:53.8908933' AS DateTime2), 0)
INSERT [dbo].[Products] ([Id], [Price], [OriginalPrice], [Stock], [ViewCount], [DateCreated], [IsFeatured]) VALUES (11, CAST(300000.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), 3, 0, CAST(N'2023-09-25T23:11:22.5585615' AS DateTime2), 0)
INSERT [dbo].[Products] ([Id], [Price], [OriginalPrice], [Stock], [ViewCount], [DateCreated], [IsFeatured]) VALUES (12, CAST(500000.00 AS Decimal(18, 2)), CAST(400000.00 AS Decimal(18, 2)), 6, 0, CAST(N'2023-09-25T23:14:43.5651279' AS DateTime2), 1)
INSERT [dbo].[Products] ([Id], [Price], [OriginalPrice], [Stock], [ViewCount], [DateCreated], [IsFeatured]) VALUES (13, CAST(900000.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), 3, 0, CAST(N'2023-09-25T23:15:43.4223749' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
INSERT [dbo].[AppRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [Description]) VALUES (N'819d507e-4cb1-4c21-d5df-08dbc32607c6', N'user', N'USER', N'ddb8c602-2dad-41d9-9d33-c9f03dbee8ec', N'User role')
INSERT [dbo].[AppRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [Description]) VALUES (N'9d436756-3f1c-41f3-b59f-9b221bfd1083', N'admin', N'admin', NULL, N'Administrator role')
GO
INSERT [dbo].[AppUserRoles] ([UserId], [RoleId]) VALUES (N'c062bfaa-ad29-4079-8049-08dbc3171c70', N'819d507e-4cb1-4c21-d5df-08dbc32607c6')
INSERT [dbo].[AppUserRoles] ([UserId], [RoleId]) VALUES (N'7af97aee-9a3f-4008-ac98-3ce383de2ec0', N'9d436756-3f1c-41f3-b59f-9b221bfd1083')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [SortOrder], [IsShowOnHome], [ParentId], [Status]) VALUES (1, 1, 1, NULL, 1)
INSERT [dbo].[Categories] ([Id], [SortOrder], [IsShowOnHome], [ParentId], [Status]) VALUES (2, 2, 1, NULL, 1)
INSERT [dbo].[Categories] ([Id], [SortOrder], [IsShowOnHome], [ParentId], [Status]) VALUES (10, 0, 0, NULL, 1)
INSERT [dbo].[Categories] ([Id], [SortOrder], [IsShowOnHome], [ParentId], [Status]) VALUES (11, 0, 0, NULL, 1)
INSERT [dbo].[Categories] ([Id], [SortOrder], [IsShowOnHome], [ParentId], [Status]) VALUES (12, 0, 0, NULL, 1)
INSERT [dbo].[Categories] ([Id], [SortOrder], [IsShowOnHome], [ParentId], [Status]) VALUES (13, 0, 0, NULL, 1)
INSERT [dbo].[Categories] ([Id], [SortOrder], [IsShowOnHome], [ParentId], [Status]) VALUES (14, 0, 0, NULL, 1)
INSERT [dbo].[Categories] ([Id], [SortOrder], [IsShowOnHome], [ParentId], [Status]) VALUES (15, 0, 0, NULL, 1)
INSERT [dbo].[Categories] ([Id], [SortOrder], [IsShowOnHome], [ParentId], [Status]) VALUES (16, 0, 0, NULL, 1)
INSERT [dbo].[Categories] ([Id], [SortOrder], [IsShowOnHome], [ParentId], [Status]) VALUES (17, 0, 0, NULL, 1)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
INSERT [dbo].[Languages] ([Id], [Name], [IsDefault]) VALUES (N'en', N'English', 0)
INSERT [dbo].[Languages] ([Id], [Name], [IsDefault]) VALUES (N'vi', N'Tiếng Việt', 1)
GO
SET IDENTITY_INSERT [dbo].[CategoryTranslations] ON 

INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (1, 1, N'Máy ảnh', N'Máy chụp hình', N'Máy ảnh', N'vi', N'may-anh')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (2, 1, N'Camera', N'Camera', N'Camera', N'en', N'camera')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (3, 2, N'Ghế', N'Ghế ngồi', N'Ghế ngồi', N'vi', N'ghe-ngoi')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (4, 2, N'Chair', N'chair', N'chair', N'en', N'chair')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (13, 10, N'Watch', N'Watch', N'Watch', N'en', N'watch')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (14, 10, N'Đồng hồ', N'Đồng hồ đeo tay', N'Đồng hồ đeo tay', N'vi', N'dong-ho-deo-tay')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (15, 11, N'Flycam', N'flycam', N'flycam', N'en', N'flycam')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (16, 11, N'Flycam', N'flycam', N'flycam', N'vi', N'flycam')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (17, 12, N'Shirt', N'shirt', N'shirt', N'en', N'shirt')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (18, 12, N'Áo', N'áo', N'áo', N'vi', N'ao')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (19, 13, N'Trouser', N'trouser', N'trouser', N'en', N'trouser')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (20, 13, N'Quần', N'quần', N'quần', N'vi', N'quan')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (21, 14, N'Dress', N'dress', N'dress', N'en', N'dress')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (22, 14, N'Váy', N'váy', N'váy', N'vi', N'vay')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (23, 15, N'Lamp', N'N/A', N'N/A', N'en', N'N/A')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (24, 15, N'Đèn', N'đèn', N'đèn', N'vi', N'den')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (25, 16, N'Scream', N'scream', N'scream', N'en', N'scream')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (26, 16, N'Kem bôi', N'kem bôi', N'kem bôi', N'vi', N'kem-boi')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (27, 17, N'Shoe', N'shoe', N'shoe', N'en', N'shoe')
INSERT [dbo].[CategoryTranslations] ([Id], [CategoryId], [Name], [SeoDescription], [SeoTitle], [LanguageId], [SeoAlias]) VALUES (28, 17, N'Giày', N'Giày', N'Giày', N'vi', N'giay')
SET IDENTITY_INSERT [dbo].[CategoryTranslations] OFF
GO
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (1, 1)
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (2, 1)
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (4, 10)
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (5, 2)
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (7, 17)
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (8, 1)
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (8, 11)
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (9, 12)
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (11, 12)
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (12, 16)
INSERT [dbo].[ProductInCategories] ([ProductId], [CategoryId]) VALUES (13, 15)
GO
SET IDENTITY_INSERT [dbo].[ProductTranslations] ON 

INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (1, 1, N'Máy ảnh Canon', N'<p>Máy ảnh Canon</p>', N'<p>Máy ảnh Canon</p>', N'Máy ảnh Canon', N'Máy ảnh Canon', N'may-anh-canon', N'vi')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (2, 1, N'Canon Camera', N'<p>Canon Camera</p>', N'<p>Canon Camera</p>', N'Canon Camera', N'Canon Camera', N'canon-camera', N'en')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (4, 4, N'Apple watch 5', N'<p><i>Description 1</i></p>', N'<p><i><strong>Details 1</strong></i></p>', N'Description', N'Title', N'alias', N'en')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (5, 4, N'Apple watch 5', N'<p><i>Mô tả 1</i></p>', N'<p><i><strong>Chi tiết 1</strong></i></p>', N'Mô tả', N'Chi tiết', N'alias', N'vi')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (6, 5, N'Working chair', N'<p>N/A</p>', NULL, NULL, NULL, N'N/A', N'en')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (7, 5, N'Ghế làm việc', N'<p><i><strong>Mô tả</strong></i></p>', N'<p>Chi tiết</p>', N'Mô tả', N'tieu de', N'alias', N'vi')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (10, 7, N'Running Shoes', N'<p>N/A</p>', NULL, NULL, NULL, N'N/A', N'en')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (11, 7, N'Giày chạy bộ', N'<p>Mô tả</p>', N'<p>Chi Tiết</p>', N'mo ta', N'Chi tiết', N'alias', N'vi')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (12, 8, N'Flycam', N'<p>N/A</p>', NULL, NULL, NULL, N'N/A', N'en')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (13, 8, N'Flycam', N'<p>Mô tả</p>', N'<p>Chi Tiết</p>', N'Mô tả', N'tieu de', N'alias', N'vi')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (14, 9, N'Sweater', NULL, NULL, NULL, NULL, N'alias', N'en')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (15, 9, N'Áo len', N'<p>N/A</p>', NULL, NULL, NULL, N'N/A', N'vi')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (18, 11, N'Black shirt', N'<p>N/A</p>', NULL, NULL, NULL, N'N/A', N'en')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (19, 11, N'Áo đen', NULL, NULL, NULL, N'tieu de', N'alias', N'vi')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (20, 12, N'Sunscreen', N'<p>N/A</p>', NULL, NULL, NULL, N'N/A', N'en')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (21, 12, N'Kem chống nắng', NULL, NULL, N'mo ta', N'tieu de', N'alias', N'vi')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (22, 13, N'Desk night lamp', N'<p>N/A</p>', NULL, NULL, NULL, N'N/A', N'en')
INSERT [dbo].[ProductTranslations] ([Id], [ProductId], [Name], [Description], [Details], [SeoDescription], [SeoTitle], [SeoAlias], [LanguageId]) VALUES (23, 13, N'Đèn ngủ', NULL, NULL, N'Description', N'tieu de', N'alias', N'vi')
SET IDENTITY_INSERT [dbo].[ProductTranslations] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductImages] ON 

INSERT [dbo].[ProductImages] ([Id], [ProductId], [ImagePath], [Caption], [IsDefault], [DateCreated], [SortOrder], [FileSize]) VALUES (2, 1, N'3ee63fa5-d27a-493b-9de0-d701c924fb23.jpg', N'Thumbnail image', 1, CAST(N'2023-09-22T16:23:33.0186274' AS DateTime2), 1, 29095)
INSERT [dbo].[ProductImages] ([Id], [ProductId], [ImagePath], [Caption], [IsDefault], [DateCreated], [SortOrder], [FileSize]) VALUES (3, 4, N'df32974c-a2b8-402e-a93d-7766ff186286.jpg', N'Thumbnail image', 1, CAST(N'2023-09-25T22:16:06.6501639' AS DateTime2), 1, 27557)
INSERT [dbo].[ProductImages] ([Id], [ProductId], [ImagePath], [Caption], [IsDefault], [DateCreated], [SortOrder], [FileSize]) VALUES (4, 5, N'6c0246cf-70ee-4659-bd1a-c5022d675026.jpg', N'Thumbnail image', 1, CAST(N'2023-09-25T23:01:31.2416967' AS DateTime2), 1, 22795)
INSERT [dbo].[ProductImages] ([Id], [ProductId], [ImagePath], [Caption], [IsDefault], [DateCreated], [SortOrder], [FileSize]) VALUES (6, 7, N'2631f862-ab5b-4d4c-96f2-fcce78faf139.jpg', N'Thumbnail image', 1, CAST(N'2023-09-25T23:04:47.4820326' AS DateTime2), 1, 35305)
INSERT [dbo].[ProductImages] ([Id], [ProductId], [ImagePath], [Caption], [IsDefault], [DateCreated], [SortOrder], [FileSize]) VALUES (7, 8, N'54642441-f820-40a8-8354-06aa78b19172.jpg', N'Thumbnail image', 1, CAST(N'2023-09-25T23:06:33.0358697' AS DateTime2), 1, 21340)
INSERT [dbo].[ProductImages] ([Id], [ProductId], [ImagePath], [Caption], [IsDefault], [DateCreated], [SortOrder], [FileSize]) VALUES (8, 9, N'da09856c-98e3-477d-84f9-106bbc485ada.jpg', N'Thumbnail image', 1, CAST(N'2023-09-25T23:07:53.8908980' AS DateTime2), 1, 21764)
INSERT [dbo].[ProductImages] ([Id], [ProductId], [ImagePath], [Caption], [IsDefault], [DateCreated], [SortOrder], [FileSize]) VALUES (10, 11, N'024b7744-57cd-4ef2-8301-d282af2b02f3.jpg', N'Thumbnail image', 1, CAST(N'2023-09-25T23:11:22.5585667' AS DateTime2), 1, 38512)
INSERT [dbo].[ProductImages] ([Id], [ProductId], [ImagePath], [Caption], [IsDefault], [DateCreated], [SortOrder], [FileSize]) VALUES (11, 12, N'e04976a7-104e-4caa-bc81-9d2dcd8fee05.jpg', N'Thumbnail image', 1, CAST(N'2023-09-25T23:14:43.5651318' AS DateTime2), 1, 30108)
INSERT [dbo].[ProductImages] ([Id], [ProductId], [ImagePath], [Caption], [IsDefault], [DateCreated], [SortOrder], [FileSize]) VALUES (12, 13, N'4be9b086-bd09-48b8-853c-505529a59819.jpg', N'Thumbnail image', 1, CAST(N'2023-09-25T23:15:43.4223781' AS DateTime2), 1, 20601)
SET IDENTITY_INSERT [dbo].[ProductImages] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920181414_Initial', N'3.1.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230921071738_HomeData', N'3.1.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231004120231_add_total', N'7.0.11')
GO
INSERT [dbo].[AppConfigs] ([Key], [Value]) VALUES (N'HomeDescription', N'This is description of eShop')
INSERT [dbo].[AppConfigs] ([Key], [Value]) VALUES (N'HomeKeyword', N'This is keyword of eShop')
INSERT [dbo].[AppConfigs] ([Key], [Value]) VALUES (N'HomeTitle', N'This is home page of eShop')
GO
SET IDENTITY_INSERT [dbo].[Slides] ON 

INSERT [dbo].[Slides] ([Id], [Name], [Description], [Url], [Image], [SortOrder], [Status]) VALUES (1, N'Men-US Fashion', N'Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.', N'#', N'/img/carousel-1.jpg', 1, 1)
INSERT [dbo].[Slides] ([Id], [Name], [Description], [Url], [Image], [SortOrder], [Status]) VALUES (2, N'Women-US Fashion', N'Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.', N'#', N'/img/carousel-2.jpg', 2, 1)
INSERT [dbo].[Slides] ([Id], [Name], [Description], [Url], [Image], [SortOrder], [Status]) VALUES (3, N'Kids Fashion', N'Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.', N'#', N'/img/carousel-3.jpg', 3, 1)
SET IDENTITY_INSERT [dbo].[Slides] OFF
GO
