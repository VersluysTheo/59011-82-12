/****** Script de la commande SelectTopNRows à partir de SSMS  ******/
SELECT TOP (1000) [AddressID]
      ,[AddressLine1]
      ,[AddressLine2]
      ,[City]
      ,[StateProvinceID]
  FROM [AdventureWorks2019].[Person].[Address]
