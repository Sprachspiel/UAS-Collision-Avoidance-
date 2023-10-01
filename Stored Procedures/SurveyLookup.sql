CREATE PROCEDURE dbo.spSurveyLookup
	@table_name NVARCHAR(128)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT t.[ARV]
	,t.[INC]
	,t.[AZI]
	,t.[TRV]
	,t.[ALT]
	,t.[NS]
	,t.[EW]
	,t.[GRID_NORTH]
	,t.[GRID_EAST]
	,t.[TIME]
	,w.[FLIGHT]
	FROM [].[dbo].[@table_name] t
	inner join [].[dbo].[FLIGHTS] f on @table_name = w.[FLIGHTS_TALBE]

END
GO
