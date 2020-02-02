
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_DeleteFamilia
	-- Add the parameters for the stored procedure here
	@Familia_Id int = null,
	@Hijo_Id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Familia WHERE Familia_Id = @Familia_Id AND Hijo_Id = @Hijo_Id
END
GO
