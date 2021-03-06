![Puppers](https://media1.tenor.com/images/ee9683d648f9c641067999fe1616667d/tenor.gif?itemid=12385063)
# Animal Shelter API

#### C# Friday Independant Project, 08.21.2020

## By Benjamin Russell

## Description

The API will have several cats and dogs already seeded to the database, but will allow for full CRUD functionality so more can be added. The data will be able to be edited and deleted when something in the animals history changes or more photos uploaded. The delete will be for when an animal has been adopted to a new happy family.

## Setup/Installation Requirements

* Clone this repository from GitHub https://github.com/brussell36/AnimalShelter.Solution.git
* Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
* Install [.Net Core](https://dotnet.microsoft.com/download/dotnet-core/2.2) 
* To install the REPL dotnet script, run `dotnet tool install -g dotnet-script` in your terminal.
* Run `dotnet restore` in terminal to get all dependencies.
* Run the command `dotnet build`.

#### Additional Setup/Installation Notes:

* You will need to have [MySQL](https://www.mysql.com/) installed on your computer to start the database for this project. 
* Once you have it installed open your terminal and run `mysql -uroot -pepicodus`. This will start the mysql server on your computer. 
* With mysql running in your terminal copy/paste the code snippet below.
* Run `dotnet ef migrations add Initial` and `dotnet ef database update` to create the schema and all required tables.
* Then you will have the database correctly set up and you can start the project in a separate terminal that the one running mysql by running `dotnet run`.

## Specifications

| Behavior | Input | Output |
| -------- | ----- | ------ |
| 1. Users will be able to look up all cats or dogs. | localhost:5000/api/cats or dogs | Full list of all cats or dogs |
| 2. Users will be able to query for specific names. | localhost:5000/api/cats/?name=Flash | Show details for a cat named Flash |
| 3. Users will be able to query for genders. | localhost:5000/api/dogs/?gender=Female | Show details of all female dogs in database |
| 4. Users will be able to look up details of specific Ids of cats and dogs.| localhost:5000/api/cats/3 | Raisin's details |

## Animal Shelter

Access information on Cats and Dogs currently at the shelter.

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
| --------- | ---- | ------- | -------- | ----------- |
| name | string | none | false | Returns matches by name. |
| gender | string | none | false | Returns matches by gender. |

## Example Query

```https://localhost:5000/api/cats/?gender=female&name=Maya```

## Sample JSON Response

```
{
  "catId": 2,
  "name": "Jazz",
  "story": "Biggest cuddler and sweetest boy.",
  "age": 6,
  "gender": "Male"
  "imageUrl": "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_weight_other/1800x1200_cat_weight_other.jpg?resize=600px:*"
}
```

## Using Swagger Documentation

To explore the AnimalShelter API with Swashbuckle, launch the project with `dotnet run` in the terminal or powershell. Then input the following URL into your browser: `http://localhost:5000`

## Note on Pagination

The AnimalShelter API returns a default of 20 results per page at a time, up to a maximum of 1000.

To modify this, use the query parameters `pageNumber` and `pageSize` to alter the response results that display. The `pageSize` parameter will specify how many results will be displayed, and the `pageNumber` parameter will specify which element in the response the pageSize should start counting.

Here is a sample query: `localhost:5000/api/cats/pages?pageNumber=1&pageSize=2`

## Known Bugs

No known issues. Please contact me if you have any problems.


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