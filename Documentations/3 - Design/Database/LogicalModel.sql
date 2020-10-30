-----------STRONG ENTITIES-----------

Users(userId, userType, email, password, firstName, lastName, dateOfBirth, phoneNumber)
PRIMARY KEY(userId)

CreditCard(creditCardNumber, expirationDate, cvv, belongsTo)
PRIMARY KEY(creditCardNumber)
FOREIGN KEY(belongsTo) REFERENCES Users(userId)

Ticket(ticketId, price, passportNumber, firstName, lastName, dateOfBirth, gender, nationality, passportExpirationDate, luggage, creates, reserved)
PRIMARY KEY(ticketId)
PRIMARY KEY(passportNumber)
FOREIGN KEY(reserved) REFERENCES Flight(flightId)
FOREIGN KEY(creates) REFERENCES Users(userId)

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























