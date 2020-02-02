
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_DeleteUsuarioPermiso
	@Usuario_Id uniqueidentifier = null,
	@Permiso_Id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM Usuario_Permiso WHERE Usuario_Id = @Usuario_Id AND Permiso_Id = @Permiso_Id
END
GO
