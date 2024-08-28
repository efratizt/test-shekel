SELECT p.ProductID ,p.ProductDesc, ISNULL(SUM(od.Quantity),0) as Quantity
FROM [dbo].[Order Details] od 
	   RIGHT JOIN  
     Products p 
ON od.ProductID=p.ProductID
GROUP BY p.ProductID ,p.ProductDesc