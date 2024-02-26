# Animal Shelter

#### By _**Jason Falk**_

#### _Store data about animals currently in Animal Shelter._

## Technologies Used

* _Dotnet_
* _C#_
* _Html_
* _MVC_
* _MySqlWorkbench_

## Description

_Enter animal name, type, and breed to database. You can then sort by Date of admission, or type or breed alphabetically. A Fidgetech practice project._

## Setup/Installation Requirements

1. _Open Git Bash/Open terminal of your choice navigate to directory of your choice and run this command `git clone https://github.com/JasoFal/Animal_Shelter.Solution.git`_
2. _Once you have cloned the project, navigate to project folder using Git Bash/ a terminal of your choice using the cd command. Or you can use file explorer to open the project manually._
3. _Then once in the `Animal_Shelter` directory, run: `dotnet build`._
------------------
* _Optional Run_
1. _To run the app type `dotnet watch run` in terminal within Tamagotchi directory_
2. _Then using a browser of your choice enter https://localhost:5001 into search bar._

---

1. _Open MySqlWorkbench_
2. _In the Navigator > Administration window, select Data Import/Restore._
3. _In Import Options select Import from Self-Contained File._
4. _Navigate to the file we just created._
5. _Under Default Schema to be Imported To, select the New button._
6. _Enter the name of your database with _test appended to the end._
7. _In this case `animal_shelter_database`._
8. _Click Ok._
9. _Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window._
10. _Within the animal shelter create file named appsetting.json._
11. _locate file named `appsettings_example.json` and add example code to your appsettings.json adding your UID and Password._

## Known Bugs

* _No known bugs_

## License

_MIT_

Copyright (c) _2/26/24_ _Jason Falk_