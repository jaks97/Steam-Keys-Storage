# Steam Keys Storage
This is a tool I made to help myself to store Steam games keys in an easy way. It is made in C# using Windows Forms and stores the data in 
a SQLite based database file.

I made this tool for personal use, but I am sharing it now as it can be useful for others. This is why you can find some weird things on 
it, it was just made to suit personal needs.

If you want to try it just download it from the [releases page](https://github.com/jaks97/Steam-Keys-Storage/releases/latest).

## How to use it?
Just launch the .exe you have downloaded and it should open a window like this:
![](https://i.imgur.com/m1Ms1As.png)

You can also see that two files were created in the running directory of the app: `Keys.db` and `Keys.bak`.

`Keys.db` is where all your data will be stored. `Keys.bak` is just a backup file that I will explain more about below.

To start adding keys press the `Add` button. There you will be asked for an app name, an AppID, and a SubID. Filling an AppID will make the
tool to try to get the other items. Same happens when filling a SubID. AppID is a unique numeric identifier for Steam apps. SubID is a 
unique numeric identifier for Steam packages. A Steam key gives a license to own an specific package. This tool will map an AppID with a SubID. (I know, this is someway wrong, as a SubID may grant access to
access to multiple AppIDs).

If you don't know what to fill in SubID, just fill an AppID and the tool should gather a valid SubID. But check out that the tool will have
troubles to do this with games that were removed from Steam. That's were `Removed` checkbox is useful. When checked, the tool won't try to
connect to Steam and fetch any data.
