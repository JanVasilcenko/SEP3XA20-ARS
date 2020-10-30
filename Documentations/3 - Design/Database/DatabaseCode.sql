CREATE SCHEMA airline;
SET SEARCH_PATH TO airline;

/* CREATE DOMAIN ENTITIES */
CREATE DOMAIN id AS DECIMAL(10) NOT NULL;
CREATE DOMAIN Names AS VARCHAR(100) NOT NULL;
CREATE DOMAIN iata AS VARCHAR(3) NOT NULL;

/* CREATE TABLES */
CREATE TABLE Users(
	userId id PRIMARY KEY,
	userType VARCHAR(8) NOT NULL CHECK(userType IN ('operator', 'customer')) DEFAULT 'customer',
	email VARCHAR(100) NOT NULL,
	password VARCHAR(100) NOT NULL,
	firstName Names,
	lastNames Names,
	dateOfBirth DATE NOT NULL,
	phoneNumber DECIMAL(20) NOT NULL
);

CREATE TABLE CreditCard(
	creaditCardNumber VARCHAR(16) NOT NULL PRIMARY KEY,
	expirationDate VARCHAR(5) NOT NULL,
	cvv DECIMAL(3) NOT NULL,
	belongsTo id,
	FOREIGN KEY (belongsTo) REFERENCES Users(userId)
);

CREATE TABLE Passenger(
	passengerId id PRIMARY KEY,
	firstName Names,
	lastNames Names,
	dateOfBirth DATE NOT NULL,
	gender VARCHAR(1) NOT NULL CHECK(gender IN ('F', 'M')), 
	nationality VARCHAR(50) NOT NULL, 
	passportNumber DECIMAL(100) UNIQUE NOT NULL, 
	passportExpirationDate DATE NOT NULL, 
	creates id NOT NULL,
	FOREIGN KEY(creates) REFERENCES Users(userId)
);

CREATE TABLE Airplane(
	registrationNumber Id PRIMARY KEY,
	planeType VARCHAR(100) NOT NULL,
	numberOfSeats DECIMAL(5) NOT NULL
);

CREATE TABLE Flight(
	flightId id PRIMARY KEY,
	numberOfSeats DECIMAL(5) NOT NULL,
	flies id,
	FOREIGN KEY(flies) REFERENCES Airplane(registrationNumber)
);

CREATE TABLE Ticket(
	ticketId id PRIMARY KEY,
	price DECIMAL(10) NOT NULL,
	boughtBy id,
	reserved id,
	FOREIGN KEY(boughtBy) REFERENCES Passenger(passengerId),
	FOREIGN KEY(reserved) REFERENCES Flight(flightId)
);

CREATE TABLE Airport(
	iataCode iata PRIMARY KEY,
	airportName Names,
	city Names,
	country Names
);

CREATE TABLE Arrival(
	arrivalTime TIME NOT NULL,
	comes iata,
	arrives id,
	FOREIGN KEY(comes) REFERENCES Airport(iataCode),
	FOREIGN KEY(arrives) REFERENCES Flight(flightId)
);

CREATE TABLE Departure(
	departureTime TIME NOT NULL,
	leaves iata,
	departs id,
	FOREIGN KEY(leaves) REFERENCES Airport(iataCode),
	FOREIGN KEY(departs) REFERENCES Flight(flightId)
);