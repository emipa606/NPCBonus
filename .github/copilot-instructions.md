# GitHub Copilot Instructions for RimWorld Mod: NPC Bonus (Continued)

## Mod Overview and Purpose

**Mod Name:** NPC Bonus (Continued)  
**Mod Description:** This mod, originally designed by pelador and updated for the current version, provides an allowance balancing system for NPC AI in RimWorld. By adjusting the max and min values of pawn kind allowance details, the mod helps in managing the economic capabilities of NPC factions, especially when modded elements are added to the game. The goal is to ensure NPCs can access tech items such as weapons, apparel, and hediffs relative to their technological level.

## Key Features and Systems

- **Dynamic Allowance Adjustments:** Players can specify percentage adjustments to the base max and min values of NPC pawn kind allowances. These settings are applied at game start and require a restart to take effect.
- **Tech Level Segmentation:** The mod categorizes faction tech levels into three epochs—Pre-industrial (Neolithic, Medieval), Industrial, and Post-industrial (Spacer, Ultra, Archotech).
- **Minimum Weapon Allowance:** There is an option to set the minimum weapon allowance to ensure NPCs can afford weapons appropriate to their technological era, balancing gameplay.
- **Balancing Tool Usage:** Intended as a tool for balancing modded content, primarily extra technologies and items that might otherwise be unaffordable for NPCs.

## Coding Patterns and Conventions

- **C# Structure:** The mod consists of four C# files—Controller.cs, NPCBonus_Initializer.cs, NPCBonusUtility.cs, and Settings.cs. Functionality is modular and organized across these files for different aspects of the mod's operation.
- **Naming Conventions:** Classes and methods utilize PascalCase, aligning with C# conventions. Methods are descriptive for clarity regarding their function within the mod.
- **File Organization:** Each file is dedicated to specific aspects, such as initialization (NPCBonus_Initializer.cs), utility functions (NPCBonusUtility.cs), and settings management (Settings.cs).

## XML Integration

As of this version's summary, the mod does not include XML files. All functionality is implemented in C# code. Future developments might consider XML for more detailed mod configuration or integrating new game definitions.

## Harmony Patching

- **Basic Harmony Usage:** While not explicitly detailed in the files listed, ensuring compatibility with potential future code additions might require harmony for non-destructive code modifications. Harmony allows for method prefixing, postfixing, or transpiling, ensuring the mod integrates seamlessly with RimWorld's core mechanics.

## Suggestions for Copilot

- **Code Suggestions:** Leverage Copilot's AI to streamline code management, suggest code improvements, and automate testing processes. Utilize its suggestions for method refactoring, especially when adding new functionality that could impact multiple systems.
- **Error Handling:** Implement Copilot suggestions to improve error-handling capabilities, particularly when setting invalid values or integrating with other mods.
- **Testing Scenarios:** Use Copilot to generate test scenarios, especially for integration with other mods or when the mod adjusts global game parameters.

---

**Note:** For troubleshooting and errors, ensure only necessary mods are active and verify logs using the Log Uploader. Participate in support discussions on the Discord channel for real-time help and post resolved issues on GitHub. Use RimSort to manage mod load order efficiently. 

License: **CC BY-NC-SA 4.0**  
Tags: `npc ai, balancing`

--- 

For further details and updates, feel free to contribute to the GitHub repository for NPC Bonus (Continued).

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

