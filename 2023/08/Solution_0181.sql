/****** Script for SelectTopNRows command from SSMS  ******/
/* 181. Employees Earning More Than Their Managers */
/* Write a solution to find the employees who earn more than their managers. Return the result table in any order. The result format is in the following example. */
SELECT employee.[Id]
      ,employee.[Name]
      ,employee.[Salary]
      ,manager.[Name] as Manager
  FROM [library].[dbo].[Employee] as employee
  JOIN [library].[dbo].[Employee] as manager on manager.Id = employee.ManagerId
  Where employee.[Salary] > manager.Salary