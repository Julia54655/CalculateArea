SELECT Products.name, Categories.name from Products
LEFT JOIN ProductsCategories
ON ProductsCategories.ProductId=Products.id
LEFT JOIN Categories
ON ProductsCategories.categoryId=Categories.id