# [NPC Bonus (Continued)](https://steamcommunity.com/sharedfiles/filedetails/?id=2195967255)

![Image](https://i.imgur.com/buuPQel.png)

Update of peladors mod
https://steamcommunity.com/sharedfiles/filedetails/?id=2000371183

![Image](https://i.imgur.com/pufA0kM.png)
	
![Image](https://i.imgur.com/Z4GOv8H.png)

# Overview
 V1.1

Apply balancing allowance factors to NPC AI. Helps to "balance the books" for NPCs if you are using modded elements.


# Mod Details


This mod adjusts the pawn allowance values for NPC Factions. It does this by providing mod options for the player to apply percentage adjustments to the base max and min values of the pawn kind allowance details.

It breaks down these elements into technology epoch ranges and also the apparel, weapon and additional hediff technology items (e.g. prosthetics, bionics etc.)

The technology ranges (faction tech level) have been applied as follows:

Pre-industrial: Factions with a tech level of Neolithic or Medieval.
Industrial: Industrial
Post-industrial: Spacer, Ultra and Archotech.

Note that the values are set at game load time, so if you change the mod option values you will need to restart RimWorld in order for any new options you have set to apply.

Note if you apply a negative adjustment value or if the allowance values haven't been set to an appropriate level by the mod creator then you can receive validation notifications on load to make you aware that insufficient allowance values are being used. (Though this tool may correct this where "wanted" applied adjustments has the potential to move these values into acceptable ranges, won't effect "0" value allowance settings, and won't create negative allowance values).

There is also an option to try and make the minimum weapon allowance value to be the lowest weapon value for the associated technological era for the pawn kinds (if the base setting is lower (wouldn't normally be so)). This is to try and ensure that pawns can at least afford a weapon. However, If the pawn kind doesn't have tags or other circumstances why it cannot use a weapon then as per pawn generation checks they may still not receive a weapon as equipment. Also this minimum cannot super-cede the maximum value. This is mostly to maintain design considerations that may be relevant by the original mod author. This setting combines with the above percentage adjustments and takes the adjusted values into account to see which is best to be applied.

# Reasoning


1) It allows for players to have another metric they can adjust to vary difficulty. Though remembering that events are applied based on points it means that the overall difficulty will be about the same as set by the incident or event, but that the quality of the pawn's equipment for those added will vary based on the adjustments added.

2) It was envisaged that with modded elements in addition to factions as game content that there needed to be a way for players to vary allowances in order to afford additional modded game content. This could be improved mod weapon items, additional clothing items and/or additional items in new layers (e.g. gloves, boots ...). And when considering that modded elements have the possibility of introducing more expensive items due to their improvements, then it seemed sensible to provide something for NPCs to also gain more potential access to these items.

In principal this means that using relatively small adjustments (e.g.  25%) allows for some additional balance considerations when compared to Player colonist potential use or capabilities, though this will be dependant on individual mod content. (Note the option of a negative offset does make things "easier" as in principal this lowers the NPCs allowance ranges or potential quality of equipment, but was added for completeness in case anyone wanted to apply offsets in this manner).

Applying large values will make the NPC be more capable on average to afford the very best tech available, especially if their pawn kind information tags them to use specific items where possible (though this could be by design). This comes with a "warning" however, since applying larger setting values will skew NPC equipment to make it begin to be more homogenised (less variety) as the tendency of equipment use will move towards the better tech available on average.

Note that since this modifies the max and min values of the allowance ranges, there will still be some variance based on the actual value for the pawn applied by the generator in the game. As such results will vary, but at least the adjusted allowances allow for a greater potential of NPCs being able to have an adjusted equipping potential on average.


# Mod Notes


Can be added and removed from save games.

Since mod content choices between players is very variable, it has been applied as a tool for players to estimate and find their own best settings based on their game play styles and content choices.


# Compatibility Notes


Expected to work with and will apply to any mod that applies allowances values for their pawn kind definitions and also for any faction that is defined in the above associated tech levels.

Would suggest adding this mod at the end of the mod list or at least after any faction mods. (This is just a catch all precaution in case other mods also apply C# tools to vary or introduce their allowance values.)

(CC BY-NC-SA 4.0)


![Image](https://i.imgur.com/PwoNOj4.png)



-  See if the the error persists if you just have this mod and its requirements active.
-  If not, try adding your other mods until it happens again.
-  Post your error-log using [HugsLib](https://steamcommunity.com/workshop/filedetails/?id=818773962) or the standalone [Uploader](https://steamcommunity.com/sharedfiles/filedetails/?id=2873415404) and command Ctrl+F12
-  For best support, please use the Discord-channel for error-reporting.
-  Do not report errors by making a discussion-thread, I get no notification of that.
-  If you have the solution for a problem, please post it to the GitHub repository.
-  Use [RimSort](https://github.com/RimSort/RimSort/releases/latest) to sort your mods

 

[![Image](https://img.shields.io/github/v/release/emipa606/NPCBonus?label=latest%20version&style=plastic&color=9f1111&labelColor=black)](https://steamcommunity.com/sharedfiles/filedetails/changelog/2195967255) | tags:  npc ai,  balancing
