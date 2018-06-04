# Steam Keys Storage
This is a tool I made to help myself to store Steam games keys in an easy way. It is made in C# using Windows Forms and stores the data in 
a SQLite based database file.

I made this tool some time ago for personal use, but I am sharing it now as it can be useful for others. This is why you can find some weird things on 
it, it was just made to suit personal needs. Also, if you wanna check the code, I should warn you: it is really ugly.

If you want to try it just download it from the [releases page](https://github.com/jaks97/Steam-Keys-Storage/releases/latest).

It requires [.NET Framework 4.5.1](https://www.microsoft.com/en-us/download/details.aspx?id=40779) or greater to run. It only works on Windows.

## How to use it?
Just launch the .exe you have downloaded and it should open a window like this:
![](https://i.imgur.com/m1Ms1As.png)

You can also see that two files were created in the running directory of the app: `Keys.db` and `Keys.bak`.

`Keys.db` is where all your data will be stored. `Keys.bak` is just a backup file that I will explain more about below.

---

To start adding keys press the `Add` button. There you will be asked for an app name, an AppID, and a SubID. Filling an AppID will make the
tool to try to get the other items. Same happens when filling a SubID. AppID is a unique numeric identifier for Steam apps. SubID is a 
unique numeric identifier for Steam packages. A Steam key gives a license to own an specific package. This tool will map an AppID with a SubID. (I know, this is someway wrong, as a SubID may grant access to
access to multiple AppIDs).

![](https://i.imgur.com/1Xs5LJj.png)

If you don't know what to fill in SubID, just fill an AppID and the tool should gather a valid SubID. But check out that the tool will have
troubles to do this with games that were removed from Steam. That's were `Removed` checkbox is useful. When checked, the tool won't try to
connect to Steam and fetch any data.

The `Details` text box can be filled with anything you want. Those details will be stored for each of the keys you just added. They are stored per key, not per package.

---

To grab keys from there you should move them to the right table of the main window. You can do that by double clicking a game or just selecting it and pressing the `>>` button. You can do this multiple times if you want more copies.

Then click `Copy` and a new window with the keys should appear. The keys were also coppied to your clipboard.
![](https://i.imgur.com/Us2cFcf.png)

When you click `Mark used` those keys will be deleted from the database. If you don't want to delete them all, just untick the ones you don't want to delete from the list.

The keys are given in a first come first serve basis.

---

If you have a list of games in text, you can use the `Find games` button and paste it there so the tool will try to match them and add the games automatically.

---

You can export your games list clicking the propper button. In the window that it opens you can specify a custom format.

![](https://i.imgur.com/AwCOLFL.png)

To do so you have some "tags" that you can use. These are the following:
* {SUBID}
* {NAME}
* {APPID}
* {DETAILS}
* {CARDS}
* {APPURL}
* {PACKAGEURL}
* {COUNT}

So, for example, if you want them on markdown, you can specify the following format:
`[{GAME}]({APPURL})`

Same applies for keys export. Just the available tags are a bit different. Here they are:
* {SUBID}
* {NAME}
* {APPID}
* {DETAILS}
* {CARDS}
* {APPURL}
* {PACKAGEURL}
* {KEY}

---

Then you have the option to ecrypt your data with a password:

![](https://i.imgur.com/KCzHpvW.png)

Once you encrypted your data you will be asked for the password each time you open the program.

If you don't specify a new password, then encryption will be disabled.

---

### Why it asks for password when I haven't set up one? / It says my password is wrong?
There is a rare possibility that your `.db` file became corrupted. Sorry, your data is lost. Well, not all of it. You can use the backup file to restore it to a working point.

### How do I use the backup file to restore my data?
Just rename `Keys.bak` to `Keys.db` and launch the program. 

`Keys.bak` contains the data that was saved the last time that you started the program without any failures. It doesn't includes the data you wrote in that launch.

### I just downloaded the tool and it doesn't starts
Check out if it has permission to write in its actual directory. Otherwise it won't be able to do anything.

### There will be updates? / Can I request a feature/modification?
There are no plans for me to update this. Doesn't mean you can't request a feature, feel free to do it. I will maybe add it if I found it easy to add or I personally find it useful.

If you wanna contribute with code, feel free to submit a pull request. I will check it and merge it if it doesn't breaks anything :P
