SELECT 
    p.product_name,
    c.category_name
FROM product p
LEFT JOIN category c ON p.product_name = c.product_name
