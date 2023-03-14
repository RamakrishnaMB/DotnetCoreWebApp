# DotnetCoreWebApp
Learn Dot net core 


USE [Ocp.Patient]

DELETE FROM [Ocp.Patient].[dbo].[PatientConsentFile]

DELETE FROM [Ocp.Patient].[dbo].[PatientNric]

DELETE FROM [Ocp.Patient].[dbo].[PatientProgram]

USE [Ocp.Notifications]

DELETE FROM [Ocp.Notifications].[dbo].[Notification].

USE [Fhir.Service]

DELETE FROM [Fhir.Service].[dbo].[Resource] WHERE ResourceTypeId IN (14, 15, 28, 45, 57,80, 96, 97, 104, 111, 114, 142)
