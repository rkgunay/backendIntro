--Select
--ANSII

Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

Select * from Products where categoryId=1 or categoryId=3

Select * from Products where categoryId=1 and UnitPrice>=10
-- <> demek 10'dan farklı olanları getir demek !!!!

select * from Products order by CategoryID, ProductName
--Ürün ismine göre sıralıyor A'dan Z'ye. varsayılanı asc'dir. Sonuna eklemeye gerek yok. Yani küçükten büyüğe. 

select * from Products order by CategoryID desc, ProductName asc

select count(*) from Products

select CategoryID, count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories  on 
Products.CategoryID = Categories.CategoryID 

--DTO (Data Transformation Object)-- 
--Inner Join, sadece iki tablodan eşleşenleri getirir. 
--Left Join, solda olup sağda olmayanları da getir. 
--Right Join, sağda olup solda olmayanları da getir.

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID inner join Orders o 
on o.OrderID = od.OrderID

--is null sadece PK'ya uygulanır. Çünkü sadece o null olamaz. 
Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

select * from Products
select * from Orders
select * from [Order Details]

select  p.ProductName as [Ürün Adı], Sum(od.UnitPrice*od.Quantity) as [Kazanılan Toplam Tutar]  from Products p inner join [Order Details] od
on p.ProductID = od.ProductID inner join Orders o
on od.OrderID = o.OrderID  group by ProductName order by [Kazanılan Toplam Tutar]

SELECT p.ProductName [Ürün Adı], 
Sum(od.UnitPrice*od.Quantity) [Kazanılan Toplam Tutar] 
FROM Products p
INNER JOIN [Order Details] od
ON p.ProductID = od.ProductID  
INNER JOIN Orders o
ON o.OrderID = od.OrderID 
GROUP BY p.ProductName 
ORDER BY [Kazanılan Toplam Tutar];