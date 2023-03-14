# [Задания №1 (клик)](https://github.com/OptisMike/MB/blob/master/Shape/Square.cs)

# Задание №2:

```sql
SELECT P.Name AS Product, C.Name AS Category
FROM Products P
LEFT JOIN ProductСategory PC
ON P.Id = PC.ProductId
LEFT JOIN Сategory C
ON PC.CategoryId = C.Id;
```
