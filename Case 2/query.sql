SELECT ProductTable.ProductName, CategoryTable.CategoryName
FROM ProductTable
LEFT JOIN CategoryTable ON ProductTable.CategoryID = CategoryTable.ID