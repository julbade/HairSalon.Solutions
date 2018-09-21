# Hair Salon

#### A Hair Salon Program.

#### By **Julius Bade**

## Description
  An app for a hair salon. The owner should be able to add a list of the stylists, and for each stylist, add clients who see that stylist. The stylists work independently, so each client only belongs to a single stylist.


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Program Gathers Name of Stylists** | Stylist 1: "Julius" | Stylist 2: "Mark" |
| **Program Gathers Name of Clients for each Stylists** | Client 1: "Jake" | Client 2 : "Jen"|
| **Program Adds Client for each Specific Sylist** | Client 2: "John" | Client 2 : "Alice"|
| **Program Adds Client for each Specific Sylist** | Client 3: "Sam" | Client 2 : "N/A"|


## Setup/Installation Requirements

1. Clone this repository at https://github.com/julbade/HairSalon.Solutions
2. Go to folder directory HairSalon.Solution/HairSalon
3. Open MAMP and start servers
4. Go to MySQL from terminal
5. > CREATE DATABASE hair_salon;
6. > USE hair_salon;
7. > CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));
8. > CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255));
9. Run through local host by typing "dotnet run"
10. Open Web Browser (Chrome, Mozilla, Safari, etc.)
11. Open http://localhost:5000 in web browser.

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C-Sharp
* MS Test
* Netcoreapp 1.1
* Atom
* GitHub
* MS MVC
* MySQL
* myPhpAdmin


## Support and contact details


_Julius Bade julbade21@gmail.com_

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2018 **_{Julius Bade}_**
