USE [Academia]
GO
/****** Object:  User [net]    Script Date: 03/03/2021 4:16:14 ******/
CREATE USER [net] FOR LOGIN [net] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [net]
GO
/****** Object:  StoredProcedure [dbo].[ComisionDelete]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David Martinez
-- Create date: 03/03/2021
-- Description:	Borra una comision por su ID
-- =============================================
CREATE PROCEDURE [dbo].[ComisionDelete]
	@Id int
AS
BEGIN
	DELETE FROM comisiones where id_comision = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[ComisionGetAll]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David Martinez
-- Create date: 03/03/2021
-- Description:	Devuelve listado de comisiones
-- =============================================
CREATE PROCEDURE [dbo].[ComisionGetAll]
as
BEGIN
-- Se debio usar Plan como string ya que Plan solo es una palabra reservada
SELECT c.id_plan as ID , c.desc_comision as Descripcion, c.id_plan as IdPlan, c.anio_especialidad as AnioEspecialidad, p.desc_plan as 'Plan'
FROM comisiones c 
inner join planes p on c.id_plan = p.id_plan;
END
GO
/****** Object:  StoredProcedure [dbo].[ComisionGetOne]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 03/03/2021
-- Description:	Devuelve una comisiòn por su ID
-- =============================================
CREATE PROCEDURE [dbo].[ComisionGetOne] 
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT c.id_comision as ID , c.desc_comision as Descripcion, c.id_plan as IdPlan,c.anio_especialidad as AnioEspecialidad, p.desc_plan as 'Plan'
	FROM comisiones c 
	inner join planes p on c.id_plan = p.id_plan
	WHERE c.id_plan = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[ComisionInsert]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 03/03/2021
-- Description:	Inserta una nueva comision
-- =============================================
CREATE PROCEDURE [dbo].[ComisionInsert]
	-- Add the parameters for the stored procedure here
	@Descripcion varchar(50),
	@AnioEspecialidad int,
	@IdPlan int
AS
BEGIN
	INSERT INTO comisiones VALUES (@Descripcion,@AnioEspecialidad,@IdPlan);
END
GO
/****** Object:  StoredProcedure [dbo].[ComisionUpdate]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 03/03/2021
-- Description:	Actualiza una comision
-- =============================================
CREATE PROCEDURE [dbo].[ComisionUpdate]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Descripcion varchar(50),
	@AnioEspecialidad int,
	@IdPlan int
AS
BEGIN
	update comisiones set
	desc_comision = @Descripcion,
	anio_especialidad = @AnioEspecialidad,
	id_plan = @IdPlan
	where id_comision = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[CursoDelete]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David Martinez
-- Create date: 03/03/2021
-- Description:	Borrar un curso
-- =============================================
CREATE PROCEDURE [dbo].[CursoDelete]
	@Id int
AS
BEGIN
	delete from cursos where id_curso = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[CursoGetAll]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	David Martinez
-- Create date: 03/03/2021
-- Description:	Listado de cursos
-- =============================================
CREATE PROCEDURE [dbo].[CursoGetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT 
	c.id_curso as ID,
	c.id_comision as IdComision,
	c.id_materia as IdMateria,
	c.cupo as Cupo,
	c.anio_calendario as AnioCalendario,
	mat.desc_materia as Materia,
	com.desc_comision as Comision
	FROM cursos c 
	inner join comisiones com on com.id_comision = c.id_comision
	inner join materias mat on mat.id_materia = c.id_materia
END
GO
/****** Object:  StoredProcedure [dbo].[CursoGetOne]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 03/03/2021
-- Description:	Devuelve un curso por un Id
-- =============================================
CREATE PROCEDURE [dbo].[CursoGetOne]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT 
	c.id_curso as ID,
	c.id_comision as IdComision,
	c.id_materia as IdMateria,
	c.cupo as Cupo,
	c.anio_calendario as AnioCalendario,
	mat.desc_materia as Materia,
	com.desc_comision as Comision
	FROM cursos c 
	inner join comisiones com on com.id_comision = c.id_comision
	inner join materias mat on mat.id_materia = c.id_materia
	where c.id_curso = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[CursoInsert]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	David Martinez
-- Create date: 03/03/2021
-- Description:	Inserta un nuevo curso
-- =============================================
CREATE PROCEDURE [dbo].[CursoInsert]
	@IdComision int,
	@IdMateria int,
	@AnioCalendario int,
	@Cupo int
AS
BEGIN
	INSERT INTO cursos values (@IdMateria,@IdComision,@AnioCalendario,@Cupo); 
END
GO
/****** Object:  StoredProcedure [dbo].[CursoUpdate]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David Martinez
-- Create date: 03/03/2021
-- Description:	Actualiza un curso
-- =============================================
CREATE PROCEDURE [dbo].[CursoUpdate]
	@Id int,
	@IdComision int,
	@IdMateria int,
	@AnioCalendario int,
	@Cupo int
AS
BEGIN
	update cursos set
	id_comision = @IdComision,
    id_materia = @IdMateria,
	anio_calendario = @AnioCalendario,
	cupo = @Cupo
	where id_curso = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[EspecialidadDelete]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 02/03/2021
-- Description:	Borrar una especialidad por medio de su ID
-- =============================================
CREATE PROCEDURE [dbo].[EspecialidadDelete] 
	@Id int
AS
BEGIN
	delete from especialidades where id_especialidad = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[EspecialidadGetAll]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:David Martinez
-- Create date: 01/03/2021
-- Description:	Devuelve todas las especialidades
-- =============================================
CREATE PROCEDURE [dbo].[EspecialidadGetAll] 
AS
BEGIN
	SELECT esp.id_especialidad as ID, esp.desc_especialidad as Descripcion FROM especialidades esp;
END
GO
/****** Object:  StoredProcedure [dbo].[EspecialidadGetOne]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 02/03/2021
-- Description:	Devuelve una Especialidad por ID
-- =============================================
CREATE PROCEDURE [dbo].[EspecialidadGetOne] 
	@Id int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT emp.id_especialidad as ID, emp.desc_especialidad as Descripcion from especialidades emp where emp.id_especialidad = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[EspecialidadInsert]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 02/03/2021
-- Description:	Inserta una nueva especialidad
-- =============================================
CREATE PROCEDURE [dbo].[EspecialidadInsert]
	@Descripcion varchar(50)
AS
BEGIN
	INSERT INTO especialidades VALUES (@Descripcion);
END
GO
/****** Object:  StoredProcedure [dbo].[EspecialidadUpdate]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David Martinez
-- Create date: 02/03/2021
-- Description:	Actualiza una Especialidad
-- =============================================
CREATE PROCEDURE [dbo].[EspecialidadUpdate] 
	@Id int,
	@Descripcion varchar(50)
AS
BEGIN
	UPDATE especialidades set desc_especialidad = @Descripcion where id_especialidad = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[PlanDelete]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 03/03/2021
-- Description:	Borrar un plan
-- =============================================
CREATE PROCEDURE [dbo].[PlanDelete]
	@Id int
AS
BEGIN
	DELETE FROM planes where id_plan = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[PlanGetAll]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 02/03/2021
-- Description:	Listado de planes
-- =============================================
CREATE PROCEDURE [dbo].[PlanGetAll]
AS
BEGIN
	SET NOCOUNT ON;
	Select p.id_plan as ID, p.desc_plan as Descripcion, p.id_especialidad as IdEspecialidad, e.desc_especialidad as Especialidad from planes p inner join especialidades e on p.id_especialidad = e.id_especialidad  
END
GO
/****** Object:  StoredProcedure [dbo].[PlanGetOne]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David Martinez
-- Create date: 03/03/2021
-- Description:	Devuelve un Plan
-- =============================================
CREATE PROCEDURE [dbo].[PlanGetOne]  
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select p.id_plan as ID, p.desc_plan as Descripcion, p.id_especialidad as IdEspecialidad, e.desc_especialidad as Especialidad from planes p 
	inner join especialidades e on p.id_especialidad = e.id_especialidad
	where p.id_plan = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[PlanInsert]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 03/03/2021	
-- Description:	Inserta un Plan
-- =============================================
CREATE PROCEDURE [dbo].[PlanInsert] 
	@Descripcion varchar(50),
	@IdEspecialidad varchar(50)
AS
BEGIN
	INSERT INTO planes VALUES (@Descripcion,@IdEspecialidad);
END
GO
/****** Object:  StoredProcedure [dbo].[PlanUpdate]    Script Date: 03/03/2021 4:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: David Martinez
-- Create date: 03/03/2021
-- Description:	Actualiza un plan
-- =============================================
CREATE PROCEDURE [dbo].[PlanUpdate]
	@Id int,
	@Descripcion varchar(50),
	@IdEspecialidad int
AS
BEGIN
	UPDATE planes set desc_plan = @Descripcion, id_especialidad = @IdEspecialidad
	WHERE id_plan = @Id
END
GO
