USE [Company]
GO

/****** Object:  Table [dbo].[Calculations]    Script Date: 30-08-2023 18:49:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Calculations](
	[CalculationId] [int] IDENTITY(1,1) NOT NULL,
	[Operation] [nvarchar](max) NOT NULL,
	[Operand1] [float] NOT NULL,
	[Operand2] [float] NOT NULL,
	[Result] [float] NOT NULL,
 CONSTRAINT [PK_Calculations] PRIMARY KEY CLUSTERED 
(
	[CalculationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


