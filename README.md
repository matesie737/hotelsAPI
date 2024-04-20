# Hotels API

## What is the use of this Repo
This project is a Web API used to manage Hotels.<br>
It allows user to get, post, update and delete informations about hotels, rooms and reservations

## Endpoints

<details>
  <summary>Hotels</summary>
<br>

| Endpoint                    | Description                  | Method |
|-----------------------------|------------------------------|--------|
| /api/hotel                  | Get all hotels               | GET    |
| /api/hotel/:id              | Get hotel by ID              | GET    |
| /api/hotel/reservation/:id  | Get hotel by reservation ID  | GET    |
| /api/hotel/room/:id         | Get hotel by room ID         | GET    |
| /api/hotel                  | Create a new hotel           | POST   |
| /api/hotel/:id              | Update hotel information     | PATCH  |
| /api/hotel/:id              | Delete hotel                 | DELETE |

</details>

<details>
  <summary>Rooms</summary>
<br>

| Endpoint                   | Description                 | Method |
|----------------------------|-----------------------------|--------|
| /api/room                  | Get all rooms               | GET    |
| /api/room/:id              | Get room by ID              | GET    |
| /api/room/hotel/:id        | Get rooms by hotel ID       | GET    |
| /api/room/reservation/:id  | Get room by reservation ID  | GET    |
| /api/room                  | Create a new room           | POST   |
| /api/room/:id              | Update room information     | PATCH  |
| /api/room/:id              | Delete room                 | DELETE |

</details>

<details>
  <summary>Reservations</summary>
<br>

| Endpoint                    | Description                      | Method |
|-----------------------------|----------------------------------|--------|
| /api/reservation            | Get all reservations             | GET    |
| /api/reservation/:id        | Get reservation by ID            | GET    |
| /api/reservation/hotel/:id  | Get reservation by hotel ID      | GET    |
| /api/reservation/room/:id   | Get reservation by room ID       | GET    |
| /api/reservation            | Create a new reservation         | POST   |
| /api/reservation/:id        | Update reservation information   | PATCH  |
| /api/reservation/:id        | Delete reservation               | DELETE |

</details>

## Used technologies and packages

1. [.Net](https://reactjs.org) Framework
2. [AutoMapper](https://mui.com) for mapping objects
3. [Npgsql](https://redux.js.org) as data provider for PostgreSQL

## Project Structure
```
├── Controllers
│   └── HotelController.cs
│   └── ReservationController.cs
│   └── RoomController.cs
├── Services
│   └── HotelService.cs
│   └── ReservationService.cs
│   └── RoomService.cs
├── Repositories
│   └── HotelRepository.cs
│   └── ReservationRepository.cs
│   └── RoomRepository.cs
├── Database
│   └── AppDbContext.cs
├── Utilities
│   └── Enums
│       └── RoomType.cs
│   └── Mapper
│       └── IMapFrom.cs
│       └── MappingProfile.cs
├── Interfaces
│   └── Repositories
│       └── IHotelRepository.cs
│       └── IReservationRepository.cs
│       └── IRoomRepository.cs
│   └── Services
│       └── IHotelService.cs
│       └── IReservationService.cs
│       └── IRoomService.cs
├── Models
│   └── DatabaseConfig.cs
├── DTOs
│   └── HotelDTO.cs
│   └── ReservationDTO.cs
│   └── RoomDTO.cs
├── Properties
│   └── launchSettings.json
├── appsettings.json
├── appsettings.Development.json
├── Hotels.csproj
├── Program.cs
```

## Versions

### .Net 8.0

Refer to [https://dotnet.microsoft.com/en-us/](https://dotnet.microsoft.com/en-us/) to install .Net 8.0

## Setting Up

To setup this project, you need to clone the git repo

```sh
$ git clone https://github.com/matesie737/hotelsAPI.git
$ cd Hotels
```

followed by

```sh
$ dotnet restore
```

in order to connect to database you need to create appsettingssecret.json file with following settings:

```
{
  "ConnectionStrings": {
    "WebApiDatabase": "Host=DBHost; Database=DBName; Username=username; Password=password"
  }
}
```

to migrate database use

```sh
$ dotnet ef migrations add initialMigration
$ dotnet ef update
```



