-----------STRONG ENTITIES-----------

Users(userId, userType, email, password, firstName, lastName, dateOfBirth, phoneNumber)
PRIMARY KEY(userId)

CreditCard(creditCardNumber, expirationDate, cvv, belongsTo)
PRIMARY KEY(creditCardNumber)
FOREIGN KEY(belongsTo) REFERENCES Users(userId)

Passenger(passengerId, firstName, lastName, dateOfBirth, gender, nationality, passportNumber, passportExpirationDate, luggage, creates)
PRIMARY KEY(passengerId)
ALTERNATE KEY (passportNumber)
FOREIGN KEY(creates) REFERENCES Users(userId)

Ticket(ticketId, price, boughtBy, reserved)
PRIMARY KEY(ticketId)
FOREIGN KEY(boughtBy) REFERENCES Passenger(passengerId)
FOREIGN KEY(reserved) REFERENCES Flight(flightId)

Airplane(registrationNumber, planeType, numberOfSeats)
PRIMARY KEY(registrationNumber)

Flight(flightId, numberOfSeats, flies)
PRIMARY KEY(flightId)
FOREIGN KEY(flies) REFERENCES Airplane(registrationNumber)

Airport(iataCode, airportName, city, country)
PRIMARY KEY(iataCode)

-----------WEAK ENTITIES------------

Arrival(arrivalTime, comes, arrives)
FOREIGN KEY(comes) REFERENCES Airport(iataCode)
FOREIGN KEY(arrives) REFERENCES Flight(flightId)

Departure(departureTime, leaves, departs)
FOREIGN KEY(leaves) REFERENCES Airport(iataCode)
FOREIGN KEY(departs) REFERENCES Flight(flightId)























