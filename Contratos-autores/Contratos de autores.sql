USE [JURIDICA]
GO
DROP TABLE [dbo].[CONTRATO_AUTORES]
GO
CREATE TABLE [dbo].[CONTRATO_AUTORES](
	[CODIGO_CONTRATO] [char](5) NOT NULL,
	[ID_AUTOR] [char](5) NOT NULL,
	[TITULO_OBRA] [varchar](200) NOT NULL,
	[ID_PRODUCTO] [numeric](18, 0) NOT NULL,
	[NRO_EJEMPLARES_CONT] [numeric](18, 0) NOT NULL,
	[NRO_IMPRESIONES] [numeric](18, 0) NOT NULL,
	[VALOR_CONTRATO] [float] NOT NULL,
	[ID_MONEDA] [char](1) NOT NULL,
	[FECHA_ENTREGA_TEXTOS] [datetime] NULL,
	[OBSERVACION] [varchar](500) NULL,
	[FIRMA_TEXTOS] [char](1) NOT NULL,
	[PAGO_ADELANTADO] [char](1) NOT NULL,
	[IMAGEN_CONTRATO] [VARCHAR] (100) NULL,
	[FECHA_PAGO] [datetime] NULL,
	[VALOR_PAGO] [float] NULL,
 CONSTRAINT [PK_CONTRATO_AUTORES] PRIMARY KEY CLUSTERED 
(
	[CODIGO_CONTRATO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] 
GO

ALTER procedure pagetAutores as
Begin
  select ID_AUTOR, NOMBRE_AUTOR from AUTOR order by NOMBRE_AUTOR
End
go
ALTER procedure paGetProdContratos as
Begin
  select ID_PRODUCTO, DETALLE from PRODUCTOS WHERE ID_ALMACEN = '00' AND CONTROL_STOCK = 1  AND 
	ID_PRODUCTO NOT IN (SELECT ID_PRODUCTO FROM SUSCRIPCIONES_PRODUCTOS) order by DETALLE
End
go
ALTER PROCEDURE [dbo].[paGetContratoAutores](
@CODIGO_CONTRATO char(5), @ID_AUTOR	char(5) OUTPUT, @TITULO_OBRA varchar(200) OUTPUT,
@ID_PRODUCTO numeric OUTPUT, @NRO_EJEMPLARES_CONT numeric OUTPUT, @NRO_IMPRESIONES numeric OUTPUT,
@VALOR_CONTRATO float OUTPUT, @ID_MONEDA char(1) OUTPUT, @FECHA_ENTREGA_TEXTOS datetime OUTPUT, 
@OBSERVACION varchar(500) OUTPUT, @FIRMA_TEXTOS char(1) OUTPUT, @PAGO_ADELANTADO char(1) OUTPUT, 
@FECHA_PAGO DATETIME OUTPUT, @VALOR_PAGO FLOAT OUTPUT, @ERROR VARCHAR(500) OUTPUT)
as 
begin
   BEGIN TRY
        SELECT 
		@ID_AUTOR=ID_AUTOR, @TITULO_OBRA=TITULO_OBRA, @ID_PRODUCTO=ID_PRODUCTO, @NRO_EJEMPLARES_CONT=NRO_EJEMPLARES_CONT, @NRO_IMPRESIONES=NRO_IMPRESIONES, 
		@VALOR_CONTRATO=VALOR_CONTRATO, @ID_MONEDA=ID_MONEDA, @FECHA_ENTREGA_TEXTOS=FECHA_ENTREGA_TEXTOS, @OBSERVACION=OBSERVACION, @FIRMA_TEXTOS=FIRMA_TEXTOS, @PAGO_ADELANTADO=PAGO_ADELANTADO
		, @FECHA_PAGO = FECHA_PAGO, @VALOR_PAGO = VALOR_PAGO
		FROM [dbo].[CONTRATO_AUTORES]
		WHERE CODIGO_CONTRATO = @CODIGO_CONTRATO
		SET @ERROR = 'OK';
   END TRY
   BEGIN CATCH
       SET @ERROR = ERROR_MESSAGE();
   END CATCH
end
GO

ALTER PROCEDURE [dbo].[paInsContratoAutores](
@CODIGO_CONTRATO char(5), @ID_AUTOR	char(5), @TITULO_OBRA varchar(200),
@ID_PRODUCTO numeric, @NRO_EJEMPLARES_CONT numeric, @NRO_IMPRESIONES numeric,
@VALOR_CONTRATO float, @ID_MONEDA char(1), @FECHA_ENTREGA_TEXTOS datetime, 
@OBSERVACION varchar(500), @FIRMA_TEXTOS char(1), @PAGO_ADELANTADO char(1), 
@FECHA_PAGO DATETIME , @VALOR_PAGO FLOAT , @ERROR VARCHAR(500) OUTPUT)
as 
begin
   BEGIN TRY
	DECLARE @NUMERO NUMERIC
	SELECT @NUMERO = ISNULL(MAX(CODIGO_CONTRATO),0) FROM CONTRATO_AUTORES
	IF @NUMERO IS  NULL
		SET @NUMERO = 0;
    SET @NUMERO = @NUMERO + 1;
		INSERT INTO [dbo].[CONTRATO_AUTORES](
		CODIGO_CONTRATO, ID_AUTOR, TITULO_OBRA, ID_PRODUCTO, NRO_EJEMPLARES_CONT, NRO_IMPRESIONES, 
		VALOR_CONTRATO, ID_MONEDA, FECHA_ENTREGA_TEXTOS, OBSERVACION, FIRMA_TEXTOS, PAGO_ADELANTADO,
		FECHA_PAGO, VALOR_PAGO)
		VALUES(@NUMERO, @ID_AUTOR, @TITULO_OBRA, @ID_PRODUCTO, @NRO_EJEMPLARES_CONT, @NRO_IMPRESIONES, 
		@VALOR_CONTRATO, @ID_MONEDA, @FECHA_ENTREGA_TEXTOS, @OBSERVACION, @FIRMA_TEXTOS, @PAGO_ADELANTADO,
		@FECHA_PAGO, @VALOR_PAGO);
		SET @ERROR = 'OK';
   END TRY
   BEGIN CATCH
       SET @ERROR = ERROR_MESSAGE();
   END CATCH
end
GO

ALTER PROCEDURE [dbo].[paUpdContratoAutores](
@CODIGO_CONTRATO char(5), @ID_AUTOR	char(5), @TITULO_OBRA varchar(200),
@ID_PRODUCTO numeric, @NRO_EJEMPLARES_CONT numeric, @NRO_IMPRESIONES numeric,
@VALOR_CONTRATO float, @ID_MONEDA char(1), @FECHA_ENTREGA_TEXTOS datetime, 
@OBSERVACION varchar(500), @FIRMA_TEXTOS char(1), @PAGO_ADELANTADO char(1), 
@FECHA_PAGO DATETIME , @VALOR_PAGO FLOAT , @ERROR VARCHAR(500) OUTPUT)
as 
begin
   BEGIN TRY
		UPDATE [dbo].[CONTRATO_AUTORES]
		SET  ID_AUTOR=@ID_AUTOR, TITULO_OBRA=@TITULO_OBRA, ID_PRODUCTO=@ID_PRODUCTO, NRO_EJEMPLARES_CONT=@NRO_EJEMPLARES_CONT, NRO_IMPRESIONES=@NRO_IMPRESIONES, 
		VALOR_CONTRATO=@VALOR_CONTRATO, ID_MONEDA=@ID_MONEDA, FECHA_ENTREGA_TEXTOS=@FECHA_ENTREGA_TEXTOS, OBSERVACION=@OBSERVACION, FIRMA_TEXTOS=@FIRMA_TEXTOS, PAGO_ADELANTADO=@PAGO_ADELANTADO,
		FECHA_PAGO = @FECHA_PAGO, VALOR_PAGO = @VALOR_PAGO
		WHERE CODIGO_CONTRATO = @CODIGO_CONTRATO
		SET @ERROR = 'OK';
   END TRY
   BEGIN CATCH
       SET @ERROR = ERROR_MESSAGE();
   END CATCH
end
GO

ALTER procedure [dbo].[paContratoAutores] as
begin
    select  CONTRATO_AUTORES.CODIGO_CONTRATO, CONTRATO_AUTORES.ID_AUTOR, AUTOR.NOMBRE_AUTOR, CONTRATO_AUTORES.TITULO_OBRA, CONTRATO_AUTORES.ID_PRODUCTO, 
    PRODUCTO_GJ = ISNULL(PRODUCTOS.DETALLE,''), CONTRATO_AUTORES.NRO_EJEMPLARES_CONT, CONTRATO_AUTORES.NRO_IMPRESIONES, CONTRATO_AUTORES.VALOR_CONTRATO, 
    CONTRATO_AUTORES.ID_MONEDA, CONTRATO_AUTORES.FECHA_ENTREGA_TEXTOS, CONTRATO_AUTORES.OBSERVACION, CONTRATO_AUTORES.FIRMA_TEXTOS, CONTRATO_AUTORES.PAGO_ADELANTADO,
    CONTRATO_AUTORES.FECHA_PAGO, CONTRATO_AUTORES.VALOR_PAGO
    from CONTRATO_AUTORES left outer join AUTOR on CONTRATO_AUTORES.ID_AUTOR = AUTOR.ID_AUTOR
    left outer join PRODUCTOS on CONTRATO_AUTORES.ID_PRODUCTO = PRODUCTOS.ID_PRODUCTO
end
GO
