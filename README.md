# Unity Bluesprint

Sample unity bluesprint project that show how to organise files, scripts in project and game objects in a scene. To solve a gernal case that often happen in game.

### The case

A player with stats will collide with number of different items that give player the buff/debuff or damage

### The solution

- Keep all the player/items data as scriptable object so that developer/designer can easily edit it from inspector. 
- Make a base effect and define other effect base on it so that can extend other effect later. With the [SerializeReference] the input data of effect can be change in inspector.
- A character controller will handle the input and the collision, then apply the item's effect to character.
- Cleam code, follow component oriented, each component can be re-used later: the effect component and base effect can be use for projectile, or event some place that need to trigger special effect affect player, the character info can be used to define enemy too,...

### Project structure

    Assets      -- Bluesprint   -- Scripts  -- Items
                                -- Shaders    
                -- TextMesh Pro
                ...
                
- Use a seperate folder {ProjectName} under Assets, because we can import/use any other packages, third-party file later like the TextMesh Pro above. This will keep all our project file structure unaffected by it.
- I use content type as the first level of folder, that way you always know where to put the file in. For the second/third level.. you can always decide depend on your project need. As in this sample, i use the oject they are using for: item, character or the functions they using for: UIs ...

### Scene structure

    Scene       -- Enviroments      -- Plane
                -- Item             -- ItemSpawn
                                    -- ItemManager
                ...
    
- Use an empty game object to parent other related game objects, it will help organise your hierarchy. It will not affect your game performance.
- When instantiating objects, have them a parent so you the hierarchy not cluttered with thing like projectiles, enemies, ... Example using ItemSpawn

### References

- [ScriptableObject](https://docs.unity3d.com/Manual/class-ScriptableObject.html)
- [SerializeReference](https://docs.unity3d.com/ScriptReference/SerializeReference.html)
- [Component Oriented](https://en.wikipedia.org/wiki/Component-based_software_engineering)
