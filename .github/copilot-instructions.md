# GitHub Copilot Instructions for Deep Storage Plus (Continued)

## Mod Overview and Purpose

Deep Storage Plus (Continued) is an extension mod for RimWorld, aimed at enhancing the storage options originally provided by LWM's Deep Storage mod. This mod introduces new storage buildings that are designed to complement existing ones without cluttering the Storage tab, following the principle of "more specific = more capacity." This ensures that your colonies have more efficient and versatile storage solutions.

## Key Features and Systems

- **Organ Fridge**: A non-electric fridge capable of storing up to 16 body parts (8 per cell). Requires Machining and Air Conditioning to unlock.
- **Barrel**: Stores up to 8 stacks of a single liquid type (e.g., chemfuel, milk). Supports Vanilla Expanded Brewing drinks and other mods on request. Requires Complex Furniture to unlock.
- **Firewood Rack**: Stores up to 14 stacks of wood (7 per tile) and prevents deterioration. Requires Complex Furniture to unlock.
- **Bin**: Fast to use, stores up to 6 stacks of one item type (e.g., raw food, kibble). Requires Machining to unlock.
- **Mod Compatibility**: Integrates with various mods to enhance storage effectiveness (e.g., Vanilla Brewing Expanded, Dubs Bad Hygiene, and others).

## Coding Patterns and Conventions

- **Namespaces**: Ensure that all classes and methods are encapsulated within appropriate namespaces to avoid any conflicts with other mods.
- **Class Naming**: Use PascalCase for class names, such as `CompDeepStorage_CapacityToStoreThingAt`.
- **Method Naming**: Use PascalCase for method names, even though they aren't explicitly detailed.
- **Class Modifiers**: Classes should generally be `public` or `internal` based on their usage scope.

## XML Integration

- **Defs**: Use XML files to define storage building properties and integrate them with the game's crafting and construction systems.
- **Tags**: Make use of XML tags appropriately, such as `<ThingDef>` for defining new storage items and their properties.

## Harmony Patching

- **Harmony Patches**: `DoHarmony` class implements Harmony patches to extend or modify game functionality.
- **Usage**: Use Harmony to patch methods that need alteration or enhancement without directly modifying base game code, facilitating easier updates and compatibility.

## Suggestions for Copilot

To make Copilot more effective in your project, consider:

1. **Clear Comments**: Ensure that your code includes well-explained comments, especially in regions where complex logic or essential functionality is implemented.
2. **Method Stubs**: Provide clear method stubs with the purpose and expected parameters/results when methods are omitted or not defined yet.
3. **Documentation**: Maintain thorough inline documentation and a central readme or document file explaining the purpose and flow of complex systems.
4. **Integration Points**: Specify integration points and expected external interactions, such as which classes are expected to collaborate closely with other mods.

By following these guidelines and utilizing Copilot's suggestions, you can simplify the development and maintenance of the Deep Storage Plus (Continued) mod, ensuring it remains a valuable part of the RimWorld modding community.



This markdown file provides an organized and structured set of instructions and details for collaborating with GitHub Copilot in the context of this RimWorld modding project.
