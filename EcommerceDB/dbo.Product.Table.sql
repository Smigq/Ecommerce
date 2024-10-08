USE [EcommerceV2]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6.10.2024. 21:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Price] [int] NOT NULL,
	[Description] [varchar](500) NULL,
	[StockQuantity] [int] NOT NULL,
	[OrderDetailsId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_OrderDetails] FOREIGN KEY([OrderDetailsId])
REFERENCES [dbo].[OrderDetails] ([OrderDetailsId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_OrderDetails]
GO
