CREATE TABLE sale (
	saleid INT UNIQUE NOT NULL AUTO_INCREMENT, 
	productname VARCHAR(128) NOT NULL, 
	quantity INT NOT NULL,
	price DECIMAL(8,2) NOT NULL,
	saledate DATE DEFAULT (current_date),
	PRIMARY KEY (saleid)
);