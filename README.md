This my solution for Unit 4: Lab 5 "Blockbuster" in the 2022 C# .NET After-Hours Boot Camp at Grand Circus.
# BLOCKBUSTER

### Task: 
Create your own blockbuster video. Movies will come in 2 different formats: VHS and DVD. The user should be able to rent a movie from a list of movies and watch it.

### What will the application do?
Create an abstract Movie class with the following: 
- A property for Title that’s a string 
- A property for Category that’s of Enum Genre - if we haven’t covered this yet, just use a string 
- An int property for RunTime (in minutes) 
- A list of strings called Scenes
- A virtual method called PrintInfo() that prints all properties in the class to the console save for the scenes.
- A method called PrintScenes() that prints all the scenes in the list along with their index. 
- An abstract method with no return type called Play() (If we haven’t covered abstract yet, just make this method virtual instead) 


Create an Enum named Genre with the following values (for the sake of simplicity assume each movie will only have one Genre) (Also if haven’t learned enums yet just use strings) : 
- Drama
- Comedy 
- Horror
- Romance 
- Action

Next Create a child class of Movie called VHS and code the following:
- property called CurrentScene 
- method called Play() that plays the scene at the CurrentScene and then increments CurrentScene . 
- method called Rewind() that returns nothing and sets CurrentScene to 0. 

Create a child of Movie named DVD with the following code: 
- A method called Play() that takes no parameters and is void that will ask the user what scene they’d like to watch, print all the available scenes, and allow the user to select a scene from the list and print it out.

Lastly, create a class named Blockbuster that contains the following code: 
- Member variable called List<Movie> Movies
- Method called PrintMovies() - this will print all the movie titles in the Movies list along with their indexes.
- Method called CheckOut() - this will call PrintMovies() and ask the user which movie they’d like to check out, get an index from the user, select a movie from the list and PrintInfo() on that movie. The method should return the Movie object selected by the user.
- In your Main, create an instance of Blockbuster and manually populate its Movies list with at least 6 movies, 3 DVDs, 3 VHS all your choice.


### Console Example:
```
Welcome to GC Blockbuster! 
Please Select a Movie from the list:
1.	Star Wars: the good one
2.	Duck Tales 
3.	Whatever Marvel Nonsense 
4.	Saving Private Ryan
5.	Duck Tales 2: Zack Quack has a bad day
6.	Dora The Explorer: Swiper, yes Swiping!
Please select a movie you want to watch: {user input here, for example: 6 }

Dora The Explorer: Swiper, yes Swiping! 
Category: Horror 
Runtime: 92 minutes

Do you want to watch the movie? Y/N {user input here, for example: y }

Which Scene of the DVD Dora The Explorer: Swiper, yes Swiping! 
would you like to watch? Select 0 to 5: {user input here, for example: 4}

Scene 4: Shrek Shows up 

Watch another scene? {user input here, for example: n }

Bye! 
```
### Extended Exercise: 
- Create a PlayWholeMovie in both VHS and DVDs to play each scene from start to finish. 
