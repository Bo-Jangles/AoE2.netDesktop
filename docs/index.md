---
layout: home
# multilingual page pair id; this must pair with translations of this page. (This name must be unique)
lng_pair: id_home

# image for page-specific usage
img: ":home-heading.jpg"
# publish date (used for SEO)
# If not specified, "site.time" will be used.
#date: 2022-03-03 12:32:00 +0000

# for override items in _data/lang/[language].yml
#title: My title
#button_name: "My button"
# for override side_and_top_nav_buttons in _data/conf/main.yml
#icon: "fa fa-bath"

# SEO
# If not specified, the date will be used.
#meta_modify_date: 2022-03-03 12:32:00 +0000
# check the meta_common_description in _data/lang/[language].yml
#meta_description: ""

# optional
# If you enabled image_viewer_posts, you don't need to enable this. This is only if image_viewer_posts = false
image_viewer_on: true
# If you enabled image_lazy_loader_posts, you don't need to enable this. This is only if image_lazy_loader_posts = false
image_lazy_loader_on: true
# exclude from on-site search
#on_site_search_exclude: true
# exclude from search engines
#search_engine_exclude: true
# to disable this page, set published: false or delete this file
# Don't forget that this is root index.html. If you disable this, there will be no index.html page to open
#published: false
---

AoE2.net Desktop is an application that displays the play history of Age of Empires II: Definitive Edition.

# install

Download the latest version on the Github release page.  
<https://github.com/teshiba/AoE2.netDesktop/releases/latest/>

The software uses the .Net 6.0 runtime, so if it does not work, please install the following runtime.  
<https://dotnet.microsoft.com/download/dotnet/6.0>

# How to use

1: Start the application, then the following window will display.
2: Register your Steam-ID or Profile-ID and press the <span class = "button"> Set ID </span> button.

![InitialSetting](:InitalSetting.png "InitialSetting")

3: If The ID is correct, the display will change to AoE2.net <span style = "color: green">**Online**</span>.

_If [AoE2.net](https://aoe2.net/ "AoE2.net") is available, and you can use this app._

![online](:online.png "online")

# Main screen

If the ID is correct, the main window will show the current match's or last match's result.  
The display layouts are different for 1v1 matches and team matches.  
They are displayed as follows.  

Your name is in an orange color font.  

## Team match

![Team](:TeamMatch.png "Team")

## 1v1 match

![1v1](:1v1match.png "1v1")

Window operations are on the OS specifications.  
And you can perform the following on the window.  

## Mouse operation

| Operation method | Area                    | Operation content                                |
| ---------------- | ----------------------- | ------------------------------------------------ |
| Right-click      | In the window           | Show context menu                                |
| Double-click     | Player name             | Display the history window of the clicked player |
| Drag             | Text/image display area | Window movement                                  |

## Keyboard operation

| Operation method          | Operation details                                                  |
| ------------------------- | ------------------------------------------------------------------ |
| Alt + F4                  | Exit Application                                                   |
| F5                        | Updated match information on the main window                       |
| Alt + cursor keys         | Scale window in 10-pixel increments in the direction of the cursor |
| Alt + Shift + Cursor Keys | Scale window in 1-pixel inclement in the direction of the cursor   |

## Context menu

Right-click to display the context menu.

![ContextMenu](:TeamMatch-contextMenu.png "ContextMenu")

| Item            | Operation details                            |
| --------------- | -------------------------------------------- |
| Settings        | Displays the settings window.                |
| Show my history | Displays the history window of the set user. |
| Update          | Update the match information.                |
| Exit            | Exit the application.                        |

# History window

## Matches tab

The match history of the player with the set ID is displayed.  
Select the leaderboard from the list and change the left list to the selected match type.  

| Items        | Contents                                                                     |
| ------------ | ---------------------------------------------------------------------------- |
| Map          | Used map                                                                     |
| Rate         | The rate at the time of the match and the change value of the rate           |
| Win          | Shows the status of victory or defeat <br> "○" is given to the winning game. |
| Civilization | Used civilization                                                            |
| Color        | player color number                                                          |
| Date         | Date and time of the match                                                   |
| Version      | Software version of the AoE2DE                                               |

The right graph shows the win or loss.  
Select "Data source" to switch between civilization and map.  

- Number of civilizations used

![MatchesTab-CivsData](:MatchesTab-CivsData.png "MatchesTab-CivsData")

- Number of maps

![MatchesTab-MapData](:MatchesTab-MapData.png "MatchesTab-MapData")

## Players tab

Displays information about enemy or ally players in the past.  
The left table shows a list of players and player information.  

| Items      | Contents                                                                                          |
| ---------- | ------------------------------------------------------------------------------------------------- |
| Name       | Player name                                                                                       |
| Country    | Country name                                                                                      |
| 1v1 Rate   | Rate when 1v1 played <br> Not display if you are not playing a 1v1 match with the player.         |
| Team Rate  | Rate when team match played <br> Not display if you are not playing a team match with the player. |
| Team Games | Number of games played with the players                                                           |
| Ally       | Number of games participated as the ally players                                                  |
| Enemy      | Number of games participated as the enemy players                                                 |
| 1v1        | Number of games played 1v1                                                                        |
| Last Date  | The Date of the last match                                                                        |

![PlayerTab](:PlayerTab.png "PlayerTab")

Input characters in the Find text box and can search for the player name by incremental search.  
If you want to ignore the case, check the "Ignore case" checkbox.  

![PlayerTabFilter](:PlayerTabFilter.png "PlayerTabFilter")

The right graph shows the number of players who have become opponents and teams in the past by country.  
Right-clicking on a column heading in the list will bring up a list of countries as a filter.  
It shows only players from the checked countries.  

![CountryFilter](:CountryFilter.png "CountryFilter")

## Statistics tab

Displays statistics and rate history graphs for each match type.

| Items          | Contents                                                    |
| -------------- | ----------------------------------------------------------- |
| Leaderboard    | The graph shows the match format with the checkbox checked. |
| Rank           | Rank                                                        |
| Rate           | Rate                                                        |
| Highest Rating | Highest Rate ever                                           |
| Game           | Number of games                                             |
| Win%           | Win rate                                                    |
| Wins           | Number of Wins                                              |
| Losses         | Number of defeats                                           |
| Drop           | Number of drop matches                                      |
| Streak         | Number of consecutive wins                                  |
| HighestStreak  | Maximum Number of consecutive wins                          |
| LowestStreak   | Maximum Number of consecutive defeats                       |

![History](:History.png "History")

# Setting window

Set the window settings and user settings.

![Settings](:settings.png "Settings")

## Display settings

| Items                      | Contents                                                    |
| -------------------------- | ----------------------------------------------------------- |
| Always on top              | Set the main window always front.                           |
| Hide title                 | Hides the title bar of the main window.                     |
| Transparency window        | Set the main window background transparent.                 |
| Opacity                    | Set text and background transparency of the main window.    |
| Chroma key                 | As chroma key, set the background color of the main window. |
| Draw high quality          | Sets the text drawing quality.                              |
| Auto reload the last match | Reload the current match information automatically.         |

## Player settings

| Items      | Contents                                             |
| ---------- | ---------------------------------------------------- |
| Steam-ID   | Select when set the user using your Steam account.   |
| profile-ID | Select when set the user using your AoE2net account. |
| Name       | Displays the player name of the ID.                  |
| Country    | Displays the country name of the ID.                 |
