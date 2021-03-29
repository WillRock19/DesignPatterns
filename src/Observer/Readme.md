#Pattern: Observer

##1. About the pattern

###Specification

We have two types of object here: the SUBJECTS, that has some data that may change, and the OBSERVER, that subscribe to a subject and
must be alerted if any of the data on it changes.

###Considerations

We could have many observers, each one responsible for displaying the information in different ways. Since the observable is responsible
for instantiating the subjects, the choices we make only will consume it.


##2. About this project

###The problem

This project try to solve the following problem: we have an metheorologic application capable of obtaining weather data and displaying it
in many ways. We could display it as **current conditions**, **status**, **previsions**, or any other way that we think as good.

###How does the program works

In a given interval, the program will load the weather informations using the **WheaterGetterService**, and, if the info 
is different from the information contained in the **WheatherDataService**, the **WheatherDataService** will warn all the observers 
that are subscribed to it, and then they will print the new information in the console. 

###Classes

####WheatherDataService

Class responsible for broadcast any changes in temperature. It uses an auxiliar class to obtain those information from a .json file and
then it loads it in memory. If the configurations are different from the previous, it broadcast to any observers that it changes and 
make then update those information.

####CurrentConditionsDisplayService

Class responsible for display the wheather conditions in the console. When the WheatherDataService notice some data has changed, it will
call this observer, that will be responsible for printing the new values in the console.

####WheaterGetterService

Class responsible for get the weather information from a file. When executing the application, you'll have to change the file information
manually; this class will try to read the file in a given interval and return it's value, so if you change it the new values will be loaded
without a problem.

####TimerService

Class responsible for creating a timer. The timer will run in a given interval (setted in the appsettings.json), and then it's going to 
execute a function passed for it. The function in this program will be the NotifyObservers() function from **WheatherDataService**.