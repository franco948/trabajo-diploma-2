
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_GetUsuarioPermiso 
	-- Add the parameters for the stored procedure here
	@Usuario_Id uniqueidentifier = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT * FROM Usuario_Permiso WHERE Usuario_Id = @Usuario_Id
END
GO
