
# Animal Shelter API

#### C# Friday Independant Project, 08.21.2020

## By Benjamin Russell

## Description

_The API will have several cats and dogs already seeded to the database, but will allow for full CRUD functionality so more can be added. The data will be able to be edited and deleted when something in the animals history changes or more photos uploaded. The delete will be for when an animal has been adopted to a new happy family._

## Setup/Installation Requirements

* Clone this repository from GitHub https://github.com/brussell36/AnimalShelter.Solution.git
* Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
* Install [.Net Core](https://dotnet.microsoft.com/download/dotnet-core/2.2) 
* To install the REPL dotnet script, run ```dotnet tool install -g dotnet-script``` in your terminal.
* Run ```dotnet restore``` in terminal to get all dependencies.
* Run the command ```dotnet build```.

#### Additional Setup/Installation Notes:

* You will need to have [MySQL](https://www.mysql.com/) installed on your computer to start the database for this project. 
* Once you have it installed open your terminal and run ```mysql -uroot -pepicodus```. This will start the mysql server on your computer. 
* With mysql running in your terminal copy/paste the code snippet below.
* Run ```dotnet ef migrations add Initial``` and ```dotnet ef database update``` to create the schema and all required tables.
* Then you will have the database correctly set up and you can start the project in a separate terminal that the one running mysql by running ```dotnet run```.

## Specifications

| Behavior | Input | Output |
| -------- | ----- | ------ |
| 1. Users will be able to look up all cats or dogs. | localhost:5000/api/cats or dogs | Full list of all cats or dogs |
| 2. Users will be able to query for specific names. | localhost:5000/api/cats/?name=Flash | Show details for a cat named Flash |
| 3. Users will be able to query for genders. | localhost:5000/api/dogs/?gender=Female | Show details of all female dogs in database |
| 4. Users will be able to look up details of specific Ids of cats and dogs.| localhost:5000/api/cats/3 | Raisin's details |

## Animal Shelter

_Access information on Cats and Dogs currently at the shelter._

## Http Request

```
GET /api/cats
POST /api/cats
GET /api/cats/{id}
PUT /api/cats/{id}
DELETE /api/cats/{id}
```
```
GET /api/dogs
POST /api/dogs
GET /api/dogs/{id}
PUT /api/dogs/{id}
DELETE /api/dogs/{id}
```
## Path Parameters

| Parameter | Type | Default | Required | Description |
| name | string | none | false | Returns matches by name. |
| gender | string | none | false | Returns matches by gender. |

## Example Query

```https://localhost:5000/api/cats/?gender=female&name=Maya```

## Sample JSON Response

```
{
  "Id": 2,
  "Name": "Jazz",
  "Story": "Biggest cuddler and sweetest boy.",
  "Age": 6,
  "Gender": "Male"
}
```

## Note on Pagination

_The AnimalShelter API returns a default of 20 results per page at a time, up to a maximum of 1000._

_To modify this, use the query parameters `limit` and `start` to alter the response results that display. The `limit` parameter will specify how many results will be displayed, and the `start` parameter will specify which element in the response the limit should start counting._

## Known Bugs

_No known issues. Please contact me if you have any problems._


## Support and contact details

Please feel free to contact me through GitHub (username: brussell36) with any questions, ideas or concerns.  

## Technologies Used

* C#
* .NET Core 2.2
* Visual Studio Code 
* Git and Git BASH 
* MySQL Workbench
* MySQL Database
* Entity Framework


### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_Benjamin Russell_**