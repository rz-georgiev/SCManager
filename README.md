# Name 
SCManager

# Description
SCManager is a semiconductors management application, that is directed for usage by electronics and electrician specialists, so they can keep track of what components they have in stash.
It can also be used in some warehouses/repair shops.

Project github url: https://github.com/rz-georgiev/SCManager

# About
This project will be used as a diploma work and for a CV upgrade.<br/><br/>
Supervisor: Associate Professor Dr. Lyudmila Dimitrova  
Head of a master's program: Associate Professor Dr. Stanislav Simeonov  
Head of department: Associate Professor Dr. Veselina Bureva  
Graduate: Radoslav Georgiev

# Installation
Download the project and start the solution.  
Create a profile and get a private key from https://sendgrid.com/  
Create a profile and get a private key from https://cloudinary.com/  
Now replace these keys in your appsettings.json file.  
The application will automatically apply the migrations and the sample data seeding for you, so just build and run the solution.  
Note: First launch can be a little bit slow, because of the database creation and the data seeding.

# Technologies:
* .NET Core 3.1
* Entity Framework Core
* AutoMapper
* BuildBundlerMinifier
* Cloudinary.Core
* HtmlSanitizer
* Bootstrap
* SendGrid
* Chart.js
* Datatables.js
* JQuery
* ML.NET for the Bayesian analysis

# Features
* Enabled ASP.NET Core Identity authentication [extended via ApplicationUser class]
* Enabled auto-generation of antiforgery token for each post request.
* Enabled by default - protection from XSS attacks via the HTML Razor symbol escape operations

# Usage

### Default account for testing [Administrator role]:  
Username: scmanager_test[at]mail[dot]com  
Password: Scmanager_test1

### User profile:
You can change your profile picture, email and password.
You can also download your personal data in a .json file format.
There is a option to delete your account and all related data to it.
In the Two-factor authentication tab, you can configure an authenticator app via a QR code or a private key, so when you login, you will have an additional layer of security.

### Dashboard:
You can see how many components you have in total of each type and what percentage it takes from the total components count [via a progress bar].
In the top right of the progress bar there is a total price for all the components of the type.
In the bottom there is a chart which shows you also the total price for each component type.

### My components:
Here you can add a new component and fill it with Quantites, Unit price and all other properties associated with it.
Also you can see in a nice card menu all components you have and their basic information.
Bayesian analysis TODO:

### Admin panel:
Displayed in a neat fully functional tables, you can manage the Users roles,
create/edit component types, create/edit unit multipliers and also edit the site Privacy and About tabs information.
To see and use the Admin panel you need to authorized and have the according roles ["Administrator"].

### Privacy policy:
There you can read all needed information about the GDPR agreements and your user rights. [Theres is an GDPR agreement option when you first visit the website].

### About: 
Well, this is the page you are currently reading.

# Support
Post your questions to scmanager_test@mail.com

# Contributing
Just copy the project and have fun

# Authors and acknowledgment
Special thanks to:

https://www.microsoft.com/en-us  
https://startbootstrap.com/themes/sb-admin-2/  
https://github.com/StartBootstrap/startbootstrap-sb-admin-2  
https://sendgrid.com/  
https://cloudinary.com/  
https://github.com/mganss/HtmlSanitizer  
https://www.chartjs.org/  
https://datatables.net/  
https://fontawesome.com/  
https://www.tiny.cloud/  
https://jquery.com/  
https://getbootstrap.com/
https://www.freepik.com/free-photos-vectors/web-banner  
https://undraw.co/illustrations  
Me: R. Georgiev


# License
MIT License
Copyright (c) [2020] [SCManager]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
Project status
Currently in development.
