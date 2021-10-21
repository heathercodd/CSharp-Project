CREATE TABLE sale (
	saleid INT UNIQUE NOT NULL AUTO_INCREMENT, 
	productname VARCHAR(128) NOT NULL, 
	quantity INT NOT NULL,
	price DECIMAL(8,2) NOT NULL,
	saledate DATE DEFAULT (current_date),
	PRIMARY KEY (saleid)
);

INSERT INTO sale (productname, quantity, price, saledate) values ("Goldfish", 2, 5.00, '2019-11-05'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Budgie", 1, 18.00, '2019-11-29'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Hamster", 1, 15.50, '2019-12-12'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Tropical Fish", 20, 10.20, '2019-12-20'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Guinea Pig", 2, 23.80, '2020-01-08');
INSERT INTO sale (productname, quantity, price, saledate) values ("Goldfish", 1, 5.00, '2020-01-26');  
INSERT INTO sale (productname, quantity, price, saledate) values ("Koi", 6, 16.00, '2020-02-14'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Rabbit", 2, 24.99, '2020-02-18'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Goldfish", 3, 5.00, '2020-03-04'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Hamster", 1, 15.50, '2020-03-19'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Rabbit", 4, 24.99, '2020-04-11'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Budgie", 12, 18.00, '2020-04-27'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Snake", 1, 280.00, '2020-05-12');
INSERT INTO sale (productname, quantity, price, saledate) values ("Tropical Fish", 18, 10.20, '2020-05-25'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Rabbit", 2, 24.99, '2020-06-02');
INSERT INTO sale (productname, quantity, price, saledate) values ("Goldfish", 3, 5.00, '2020-06-21');
INSERT INTO sale (productname, quantity, price, saledate) values ("Cat", 1, 800.00, '2020-07-08');
INSERT INTO sale (productname, quantity, price, saledate) values ("Cat", 2, 800.00, '2020-07-19');
INSERT INTO sale (productname, quantity, price, saledate) values ("Guinea Pig", 2, 23.80, '2020-08-16');
INSERT INTO sale (productname, quantity, price, saledate) values ("Budgie", 4, 18.00, '2020-08-27');
INSERT INTO sale (productname, quantity, price, saledate) values ("Dog", 2, 2400.00, '2020-09-13');
INSERT INTO sale (productname, quantity, price, saledate) values ("Koi", 8, 16.00, '2020-09-20');
INSERT INTO sale (productname, quantity, price, saledate) values ("Snake", 1, 280.00, '2020-10-06');
INSERT INTO sale (productname, quantity, price, saledate) values ("Hamster", 2, 15.50, '2020-10-23');
INSERT INTO sale (productname, quantity, price, saledate) values ("Goldfish", 2, 5.00, '2020-11-17');
INSERT INTO sale (productname, quantity, price, saledate) values ("Tropical Fish", 10, 10.20, '2020-11-30');
INSERT INTO sale (productname, quantity, price, saledate) values ("Cat", 1, 800.00, '2020-12-15');
INSERT INTO sale (productname, quantity, price, saledate) values ("Rabbit", 1, 24.99, '2020-12-16');
INSERT INTO sale (productname, quantity, price, saledate) values ("Dog", 1, 2400.00, '2021-01-01');
INSERT INTO sale (productname, quantity, price, saledate) values ("Guinea Pig", 1, 23.80, '2021-01-26');
INSERT INTO sale (productname, quantity, price, saledate) values ("Hamster", 1, 15.50, '2021-02-11');
INSERT INTO sale (productname, quantity, price, saledate) values ("Cat", 1, 800.00, '2021-02-14');
INSERT INTO sale (productname, quantity, price, saledate) values ("Tropical Fish", 15, 10.20, '2021-03-15');
INSERT INTO sale (productname, quantity, price, saledate) values ("Budgie", 6, 18.00, '2021-03-31');
INSERT INTO sale (productname, quantity, price, saledate) values ("Rabbit", 2, 24.99, '2021-04-09');
INSERT INTO sale (productname, quantity, price, saledate) values ("Goldfish", 4, 5.00, '2021-04-12');
INSERT INTO sale (productname, quantity, price, saledate) values ("Dog", 1, 2400.00, '2021-05-03');
INSERT INTO sale (productname, quantity, price, saledate) values ("Hamster", 2, 15.50, '2021-05-24');  
INSERT INTO sale (productname, quantity, price, saledate) values ("Snake", 1, 280.00, '2021-06-14');
INSERT INTO sale (productname, quantity, price, saledate) values ("Koi", 8, 16.00, '2021-06-26'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Hamster", 3, 15.50, '2021-07-10');
INSERT INTO sale (productname, quantity, price, saledate) values ("Rabbit", 2, 24.99, '2021-07-22'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Cat", 1, 800.00, '2021-08-08');
INSERT INTO sale (productname, quantity, price, saledate) values ("Budgie", 8, 18.00, '2021-08-15');  
INSERT INTO sale (productname, quantity, price, saledate) values ("Tropical Fish", 15, 10.20, '2021-09-13'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Cat", 2, 800.00, '2021-09-30'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Guinea Pig", 2, 23.80, '2021-10-05'); 
INSERT INTO sale (productname, quantity, price, saledate) values ("Dog", 1, 2400.00, '2021-10-19'); 