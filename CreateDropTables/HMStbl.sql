/****** Object:  Table [dbo].[HospitalInfo]    Script Date: 03/10/2016 06:53:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HospitalInfo]') AND type in (N'U'))
DROP TABLE [dbo].[HospitalInfo]
GO
/****** Object:  Table [dbo].[InPatientDetail]    Script Date: 03/10/2016 06:53:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InPatientDetail]') AND type in (N'U'))
DROP TABLE [dbo].[InPatientDetail]
GO
/****** Object:  Table [dbo].[PatientDetail]    Script Date: 03/10/2016 06:53:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDetail]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDetail]
GO
/****** Object:  Table [dbo].[PatientInfo]    Script Date: 03/10/2016 06:53:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInfo]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInfo]
GO
/****** Object:  Table [dbo].[PatientInfo]    Script Date: 03/10/2016 06:53:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PatientInfo](
	[PUID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[EmailID] [nvarchar](100) NULL,
	[MobileNo] [nvarchar](13) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](30) NOT NULL,
	[Obsind] [char](1) NOT NULL,
 CONSTRAINT [PK_PatientInfo] PRIMARY KEY CLUSTERED 
(
	[PUID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PatientDetail]    Script Date: 03/10/2016 06:53:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PatientDetail](
	[UID] [nvarchar](50) NOT NULL,
	[RStreet1] [nvarchar](50) NOT NULL,
	[RStreet2] [varchar](50) NOT NULL,
	[RArea] [nvarchar](50) NOT NULL,
	[RCity] [nvarchar](50) NOT NULL,
	[RState] [nvarchar](50) NOT NULL,
	[RPinCode] [bigint] NOT NULL,
	[RContactNo] [nvarchar](13) NOT NULL,
	[PStreet1] [nvarchar](50) NULL,
	[PStreet2] [varchar](50) NULL,
	[PArea] [nvarchar](50) NULL,
	[PCity] [nvarchar](50) NULL,
	[PState] [nvarchar](50) NULL,
	[PPinCode] [bigint] NULL,
	[PContactNo] [nvarchar](13) NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](30) NOT NULL,
	[Obsind] [char](1) NOT NULL,
 CONSTRAINT [PK_PatientDetail] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InPatientDetail]    Script Date: 03/10/2016 06:53:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InPatientDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InPatientDetail](
	[PUID] [nvarchar](50) NOT NULL,
	[AdmitedOn] [datetime] NOT NULL,
	[DischargeOn] [datetime] NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](30) NOT NULL,
	[Obsind] [char](1) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HospitalInfo]    Script Date: 03/10/2016 06:53:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HospitalInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HospitalInfo](
	[HID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](30) NOT NULL,
	[Obsind] [char](1) NOT NULL,
 CONSTRAINT [PK_HospitalInfo] PRIMARY KEY CLUSTERED 
(
	[HID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
