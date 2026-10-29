# Deep Storage Plus (Continued) GitHub Copilot Instructions

## Mod Overview and Purpose

Deep Storage Plus (Continued) is an extension mod for RimWorld that enhances the Deep Storage mod by introducing additional storage buildings. These buildings are specifically designed to complement the existing options provided by LWM's Deep Storage without overcrowding the Storage tab. Each building offers more specific storage solutions, thereby increasing the mod's utility.

## Key Features and Systems

- **Organ Fridge**: Stores up to 16 body parts, 8 per cell, without requiring electricity.
- **Barrel**: Stores up to 8 stacks of one type of liquid and supports Vanilla Expanded Brewing drinks.
- **Firewood Rack**: Stores up to 14 stacks of wood and prevents deterioration.
- **Bin**: Stores up to 6 stacks of loose resources and supports raw food, raw plants, textiles, drugs, pemmican, kibble, herbal medicine.

## Coding Patterns and Conventions

### C# Files

The mod consists of several C# files that implement the functionality of the new storage buildings and handle compatibility with other mods. Key files include:

- **CompDeepStorage_CapacityToStoreThingAt.cs**: Contains the logic for determining the capacity of a storage building to store a specific type of thing.
- **CompSingleDeepStorage.cs**: Defines properties for single deep storage components.
- **DoHarmony.cs**: Handles Harmony patching for compatibility with other mods.
- **CompSecondLayer.cs**: Manages the second layer of graphics and drawing for storage buildings.
- **CompProperties_SingleDeepStorage.cs**: Defines properties for single deep storage components.

### XML Files

The mod uses XML files to define Harmony patches for compatibility with other mods. Key XML files include:

- **Patch_DubsBadHygiene.xml**: Patches related to Dubs Bad Hygiene.
- **Patch_SimpleChains_Leather.xml**: Patches related to Simple Chains - Leather.
- **Patch_ExpandedMaterialsPlastics.xml**: Patches related to Expanded Materials - Plastics.
- **Patch_SimpleChains_Lumber.xml**: Patches related to Simple Chains - Lumber.
- **Patch_ExpandedWoodworking.xml**: Patches related to Expanded Woodworking.

## XML Integration

The mod integrates with RimWorld through XML definitions. These XML files define the new storage buildings and their properties. The XML files are located in the `1.6/Patches` directory and follow the standard RimWorld XML structure.

## Harmony Patching

Deep Storage Plus (Continued) uses Harmony patching to ensure compatibility with other mods. Harmony patches are defined in the XML files mentioned above. These patches modify the behavior of RimWorld and other mods to enable the new storage buildings to function correctly.

## Suggestions for Copilot

When using GitHub Copilot with Deep Storage Plus (Continued), consider the following suggestions:

- **Focus on C# Logic**: Since the mod is primarily written in C#, prioritize using Copilot to generate code snippets and logic for C# files.
- **XML Definitions**: Use Copilot to help generate and modify XML definitions, especially for Harmony patches.
- **Compatibility Patches**: When adding support for new mods, use Copilot to help generate Harmony patches for compatibility.
- **Code Refactoring**: Use Copilot to assist with code refactoring and optimization of existing C# code.

By following these guidelines, you can efficiently use GitHub Copilot to enhance and maintain the Deep Storage Plus (Continued) mod for RimWorld.

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

