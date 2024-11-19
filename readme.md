Employement Assessment
Appointment management system for a clinic.

Development
Prerequisites
Make sure you have the following installed before getting started:

.NET SDK (version 6.0 or higher)
MySQL (version 8.0 or higher)
Git
To clone this repository:
 Git clone https://github.com/carobte/riwi-assesment 
To restore dependencies
Restore NuGet packages:

 dotnet restore 
.env file
Make sure you add the environment variables locally in the .env file:

DB_HOST =
DB_PORT =
DB_DATABASE =
DB_USERNAME =
DB_PASSWORD =

JWT_KEY =
JWT_ISSUER =
JWT_AUDIENCE =
JWT_EXPIREMINUTES =

To run the project in dev mode
 dotnet run 
Note: Remember to add the /swagger to your localhost so you can see the available endpoints or use the welcome page to be redirected.