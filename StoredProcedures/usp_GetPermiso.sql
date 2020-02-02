
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_GetPermiso 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


	SELECT DISTINCT Permiso_Id, Permiso_Nombre, Permiso_Codigo, Familia_Id
    FROM Permiso
    LEFT JOIN Familia
    ON Permiso_Id = Familia_Id
END
GO
