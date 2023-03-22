select p.ProductName, c.CategoryName 
	from products p
	left join product_categories pc on pc.productId  = p.id
	left join categories c on c.id  = pc.id 
	
create table products (id int primary key not null auto_increment, ProductName varchar(255))
create table categories (id int primary key not null auto_increment, CategoryName varchar(255))
create table product_categories (id int primary key not null auto_increment, 
	categoryId int not null, productId int not null,
	foreign key (categoryId) references categories (Id),
	foreign key (productId) references products (Id))