
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_CreateUsuarioPermiso
	@Usuario_Id uniqueidentifier = null,
	@Permiso_Id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Usuario_Permiso (Usuario_Id, Permiso_Id) VALUES (@Usuario_Id, @Permiso_Id)
END
GO
