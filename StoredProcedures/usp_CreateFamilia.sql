
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_CreateFamilia
	@Familia_Id int = null,
	@Hijo_Id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Familia (Familia_Id, Hijo_Id) VALUES (@Familia_Id, @Hijo_Id)
END
GO
