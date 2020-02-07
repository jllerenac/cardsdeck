# Project Title

This is a basic program that simulates a deck of cards. It has two simple functions. The first one is shuffling the deck of cards and the other one is to deliver a set of 5 cards to a group of players ranged from 4 to eight. 

## Getting Started

To have this program just download this file along with the cs file or simply open the cs file and copy the code.

### Prerequisites

This program was coded using Linux, I have not verified its functionality in Windows which I assume it should not be of a big deal to make it work there.

Since it was built in Linux, the following packages or similar need to be installed on your Linux System.

mono-core
mono-devel

This packages allow to build and run C# applications in Linux Systems.
To run on Windows, dotnet packages will have to be installed.
To edit this code is recommended to have visual studio.

### Installing

As mentioned, just to copy or download the source code into your local environment.

## Compiling

To compile and generate the exe file, simply run the following command:

csc CardsDeck.cs

## Running

To execute the program, simply run the following command:

mono CardsDeck.exe

## Authors

* **Jose Llerena** and you. 

## Key notes about this program

* This program only simulates the following:
* Having a new bought deck of cards which is defined in a readonly array
* Starts a game by instatiating the class an inmediately the new game gets the cards shuffled
* A method is created for shuffling but is applicable in using the constructor instead of a method
* And the other method that is simulated is to give each player 5 cards which is based from
* a game called donkey or "burro", this game is played between 5 and 8 players
* When giving cards to players, the shuffled deck gets those cards removed
* The order for giving the cards there was no need to give the cards one by one to each player
* what was enough to do is to give the whole 5 cards to one player and so on
* By running the program, the number of players have to be input and is thus validated by 
* number of players and also by data type, so if you try to crash the program by inputing string
* you will have to edit this code
* Additional functionalities are still pending to code
* The program is also built for the standar deck of cards, thats why number 52 is clearly used
* Each thing inside the program is coded by purpose, questions and suggestions for improvements are welcome 
