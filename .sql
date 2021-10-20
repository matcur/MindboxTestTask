SELECT products.name, categories.name FROM products
LEFT JOIN category_product ON products.id = category_product.product_id
LEFT JOIN categories ON categories.id = category_product.category_id;

/* Предполагаемая схема базы данных */
CREATE TABLE products(
    id int,
    name char(20)
);
CREATE TABLE categories(
    id int,
    name char(20)
);
CREATE TABLE category_product(
    category_id int,
    product_id int,
    CONSTRAINT FK_category_id FOREIGN KEY(category_id)
    REFERENCES categories(id),
    CONSTRAINT FK_product_id FOREIGN KEY(product_id)
    REFERENCES products(id)
);