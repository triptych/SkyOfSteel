# SkyOfSteel

### Welcome to the GitHub repository of the game SkyOfSteel!

SkyOfSteel is a work in progress game built on the Godot game engine with C# and Mono. Currently builds with Godot 3.0.6

Contribution is not expected but welcome!



## Building

### Prerequisites

* A functioning installation of Godot Mono 3.0.6
* A functioning installation of Mono as specified by the Godot version (currently 5.12.0)

### Performing the Build

* Clone the git repo (or download as zip and extract)
* Open the Godot editor to the project and hit "Play" near the upper right corner (play icon)
  * The editor will proceed to build and launch the project



## Gameplay

Currently not much :(

The intended gameplay is intended to be a mix of Factorio, SkyBlock, and Unturned in a multiplayer private server setting. This section will expand as more gameplay items are implemented. This should not take long as most of the ground work has already been laid.



## Modding

SkyOfSteel has an innovative (and wip) modding API with full ECMAScript 5 support through the wonderful [Jurassic](https://github.com/paulbartrum/jurassic/ "Jurassic Github Page") project. With both server and client side mod scripting much can be accomplished. Servers can run gamemode scripts and send client side scripts to connecting clients similar to a webpage's scripts. In addition there is a full REPL ingame console.

The modding API is based around game events. Whenever something occurs ingame it is processed as an "event" which can be filtered, modified, or discarded by mod scripts. This allows for a great deal of flexibility even without the normal API for such things as setting player positions and the like.



## Player Input Handling

All player input is routed through the binding system which depending on the input will call a console command passing in a `double` ranging between 0 and 1 (up to infinity in some cases such as mouse movement). Key input pass in a 1 for keydown and a 0 for keyup while analog inputs such as mouse motion pass in a 0 for no movement on the specified axis and a number greater than 0 for motion on that axis (the number is the amount of motion).

**Note:** This is not restricted to built in movement and player control console commands. Any function declared in the console REPL can be bound to any key or input.



## Internal Structure

SkyOfSteel is built up of a number of singleton "libraries". Each one of these libraries deals with a portion of the game's actions and has a number of public static methods in order to be called from other libraries and classes.

Beyond these "libraries" the project directory is split up into pretty self explanatory folders which are almost like "modules" in that they (under most conditions) contain everything related to the folder name (ex: the `UI` folder has alls GUI scenes, script, and textures). Note that these folders are not self contained but instead all source files are pretty much entwined though the folder names are a good indication of where to look when trying to find the implementation of a specific feature.

**Note:** Currently the project is at the tail end of a refactorization and porting to C# so not all sources and files are properly placed in their sensible locations.



## Contributing

This is an ambitious project with much work left to do and you can help!

Feel free to contribute in the following ways:

* Test and report bugs
  * Much work has already been done and there are doubtless many bugs which remain undiscovered
* Test and report bugs to the [Jurassic](https://github.com/paulbartrum/jurassic/ "Jurassic Github Page") project
  * While not affiliated with the [Jurassic](https://github.com/paulbartrum/jurassic/ "Jurassic Github Page") project, SkyOfSteel relies heavily on the continuing success of this wonderful ECMAScript 5 library
* Fix reported bugs by getting down and dirty with the source code :)
  * Much work is left to be done and if you feel up to it you can help!
* Contribute art and sound skills
  * The term [Programmer Art](https://en.wikipedia.org/wiki/Programmer_art "Wikipedia page on Programmer Art") describes the temporary art and sound assets created hastily by those untalented in those fields in order to continue the development of a game. If you are talented in with modeling, texturing, or sound design please do contribute!
* Suggest new features
  * Are you an ideas man? You can still help!
* Spread information about SkyOfSteel
  * All projects need good PR :)



## Contact
For questions, comments, or to just discuss please join our [Discord](https://www.discord.gg/Ag5Yckw "Discord Server Invite Link")
Also feel free to follow me (ForLoveOfCats) on [Twitter](https://twitter.com/ForLoveOfCats "ForLoveOfCats Twitter Page") and [Youtube](https://www.youtube.com/channel/UCbqt-FR7-S2gTWMw0BCEkaw "ForLoveOfCats Youtube Channel")



## License

SkyOfSteel is licensed under the MIT license and utilizes the wonderful [Jurassic](https://github.com/paulbartrum/jurassic/ "Jurassic Github Page") project which is also under the MIT license