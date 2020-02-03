
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_DeletePermiso
	-- Add the parameters for the stored procedure here
	@Permiso_Id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Familia WHERE Familia_Id = @Permiso_Id

	DELETE FROM Permiso WHERE Permiso_Id = @Permiso_Id
END
GO
