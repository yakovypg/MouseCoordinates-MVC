## Quick Start
Follow these steps:
- Install PostgreSQL (port: 5432).
- Add user `postgres` with password `postgres` if it wasn't added automatically.
- Make sure user `postgres` has password `postgres`.
- Make sure there is no table named `mousecoordinates` in the database.
- Make sure port `5211` is available on your computer.
- Clone repository.
    ```
    git clone https://github.com/yakovypg/MouseCoordinates-MVC.git
    ```
- Open created folder.
	```
	cd MouseCoordinates-MVC
	```
- Run application.
	```
	dotnet run --project MouseCoordinates
	```
- Open browser and go to the `http://localhost:5211`.