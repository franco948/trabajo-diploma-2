
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_CreatePermiso
	@Permiso_Nombre varchar(50) = null,
	@Permiso_Id int OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Permiso (Permiso_Nombre) VALUES (@Permiso_Nombre)

	SET @Permiso_Id = CAST(scope_identity() AS int)
END
GO
