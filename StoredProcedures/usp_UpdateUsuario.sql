
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_UpdateUsuario
	@Id uniqueidentifier = null,
	@Intentos tinyint = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE Usuario SET Usuario_Intentos = @Intentos WHERE Usuario_Id = @Id
END
GO
