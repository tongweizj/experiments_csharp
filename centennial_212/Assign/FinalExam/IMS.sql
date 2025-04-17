--Delete the IMS (Insurance Management System) database if it exists. 
IF EXISTS(SELECT * from sys.databases WHERE name='IMS') 
BEGIN 
    DROP DATABASE IMS; 
END 

CREATE DATABASE IMS;
GO

USE IMS;
GO

CREATE TABLE product(
	code VARCHAR(10)  PRIMARY KEY NOT NULL,
	name VARCHAR(50) NOT NULL);
GO

INSERT INTO product VALUES('PL001','Permanent Life Insurance');
INSERT INTO product VALUES('TL10','10-year Term Life Insurance');
INSERT INTO product VALUES('TL20','20-year Term Life Insurance');
INSERT INTO product VALUES('Par001','Par whole life Insurance');
INSERT INTO product VALUES('Whole001','Whole Life Insurnace');
INSERT INTO product VALUES('Travel001','Travel Insurance');

GO


CREATE TABLE Agent(
	id varchar(10) PRIMARY KEY NOT NULL,
	fname varchar(50) NULL,
	lname varchar(50) NULL,
	Email varchar(100) NULL);
Go
	
INSERT INTO Agent VALUES('100111222','Cindy','Smith','csmith@ABCInsurance.com');
INSERT INTO Agent VALUES('100222333','Tony','Blacks','tBlacks@ABCInsurance.com');
INSERT INTO Agent VALUES('100333444','Jacky','Martin','jMartin@ABCInsurance.com');
INSERT INTO Agent VALUES('100444555','Mary','Taylor','mTaylor@ABCInsurance.com');
INSERT INTO Agent VALUES('100555666','John','Wilson','hWilson@ABCInsurance.com');


CREATE TABLE InsurancePolicy(
	Id varchar(10) PRIMARY KEY NOT NULL, 
    Agent_Id varchar(10) NOT NULL,
	product_code varchar(10) NOT NULL,
	PolicyDate datetime not  null,
    Premium DECIMAL(7,2) NOT NULL,
    Insured varchar(50) NOT NULL,
	CONSTRAINT fk_sale_product FOREIGN KEY (product_code) REFERENCES product(code),
	CONSTRAINT fk_agent_id FOREIGN KEY (Agent_Id) REFERENCES Agent(id));
GO

INSERT INTO InsurancePolicy VALUES('25336490','100111222','PL001','2017-06-18 10:34:09',3454.34, 'Jeffrey Martin');
INSERT INTO InsurancePolicy VALUES('10344600','100111222','TL10','2017-07-11 14:05:35',122.58, 'Cindy Roy');
INSERT INTO InsurancePolicy VALUES('20214501','100111222','TL20','2017-05-09 10:34:09',154.66, 'Joel Lee');

INSERT INTO InsurancePolicy VALUES('25214501','100333444','PL001','2018-02-10 15:35:23',4563.12,'Paul Kim');
INSERT INTO InsurancePolicy VALUES('20223411','100333444','TL20','2017-04-20 10:34:09',243.89, 'Amily Jones');
INSERT INTO InsurancePolicy VALUES('30215567','100333444','Par001','2018-01-11 10:32:32',3456.43,'Tony Anderson');

INSERT INTO InsurancePolicy VALUES('25123450','100222333','PL001','2017-11-09 09:12:19',7634.32,'Jerry Zhang');
INSERT INTO InsurancePolicy VALUES('10214501','100222333','TL10','2018-02-08 10:32:32',423.12,'Honey Miller');
INSERT INTO InsurancePolicy VALUES('70221455','100222333','Whole001','2017-12-08 11:30:19',5675.34,'Shelly Campbell');

INSERT INTO InsurancePolicy VALUES('25338991','100555666','PL001','2018-03-05 09:23:21',3784.34,'Jimmy Smith');
INSERT INTO InsurancePolicy VALUES('70456315','100555666','Whole001','2017-11-09 12:38:12',7645.88,'Daniel Campbell');



