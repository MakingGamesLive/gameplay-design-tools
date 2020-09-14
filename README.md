# gameplay-dynamics-tools v1

This project combines some fundamental gameplay elements into gameplay dynamics, based on a new gameplay design paradigm I came up with.

The paradigm, concerned exclusively with gameplay and not other aspects of games, suggests the following in its current draft:

1) Objects and Variables are the fundamental 'mechanical' elements of gameplay
2) Events and Effects are the fundamental 'dynamic' elements of gameplay
3) Instructions and Rules are the fundamental 'aesthetic' elements of gameplay
4) Those six fundamental gameplay elements are tangible - the game designer can directly change them to alter gameplay

Remaining hypotheses:

1) Those six fundamental gameplay elements are the *only* six tangible fundamental gameplay elements. They are the *only* things a game designer can directly change to alter gameplay.
2) Other gameplay elements are actually just a combination of some of the six fundamentals. When a game designer alters such a complex gameplay element, they are actually altering one or more of the fundamental elements that comprises it. (Think molecules vs atoms.)
3) Elements that can't be expressed with only the six fundamentals must be non-gameplay elements. (They may still have some kind of impact on gameplay, but they (or at least some aspect of them) are not tangible and can't be directly changed by the game designer to alter gameplay.)
4) There is/are some kind of strong relationship(s) between the six fundamental gameplay elements and the set of all non-gameplay elements (which is not yet described by the paradigm) (includes everything we know about games that isn't solely made up of fundamentals: concepts such as players, agents/agency, etc.).

This version of the project is about the fundamental dynamic elements, Events and Effects. A 'gameplay dynamic' is simply an Event-Effect pair. Knowing this structure allows us to craft gameplay dynamics from a simple list of elements. The purpose of this version of the project (v1) is to demonstrate such crafting with a basic example.

First, I listed all of the fundamental mechanical & dynamic elements present in Atari's Breakout and expressed them in a structure of Unity GameObjects. Some of these elements depend on other elements, including crucial elements such as the Object-to-Object Collision Event: for those, I generated every possibility from the given set of base Breakout elements, in an arbitrary order, avoiding recursion. (The final version would give the user full step-by-step control over dependent element generation. For this version, it was important to limit the size of the results for usability, and to show that this basic case still contains many useful entries.)

Second, I wrote a simple function to combine every Event and every Effect, and store these combinations as new GameObjects with a name describing the combination (I know this isn't ideal; I lost some data, this is what's left) - each of these GameObjects represents a game dynamic (but the list is NOT exhaustive and never will be). This very large list of dynamics is in the lone Scene file, "Assets/Scenes/Prototype1_ProofOfConcept.unity" under the container object called "Dynamics (Event-Effect Pairs)" (be warned, very large). The list contains every dynamic that derives from the base elements of Breakout; there are many great ideas for gameplay that have been used by various successful Breakout derivatives, such as Taito's Arkanoid (as well as many bad ideas).

That's why this project exists - in 2017, a friend of mine was not able to come up with a significant amount of good gameplay ideas for his Breakout clone in a timely manner, so I coached him on how to do so and gave him a bunch of great ideas instantly using the method executed by this project. It helped a lot that I have a lot of experience with Arkanoid (I've owned a copy for a very long time and beaten it many times) and that I took a workshop on MDA in 2013. Beyond that, it was just a eureka moment, where I was able to see what I was doing to come up with gameplay ideas and describe the process to my friend, thus effectively teaching him how to do this aspect of gameplay design and earning me a spot in his credits. That process, before I realized it was part of a larger paradigm and wasn't just MDA, went like this:

1) Know that every number, string, and boolean in the game is a variable, and that you can change any of them at any time.
2) List all of the numbers, strings, and booleans in the game.
3) List all of the distinct events that take place in the game.
4) Gameplay Idea = When (an Event from #3) Occurs, Change (a Number or String or Boolean from #2).

I explained this to my friend and immediately came up with the following ideas for him, among others:

1) "When Ball hits Block, change Ball position somehow."
2) "When Ball hits Block, change the number of Blocks on the field in a different way than usual; i.e. spawn one or more blocks, or remove some extra blocks, or both."
3) "When Ball hits Block, change Paddle size somehow."

Of course, before these can be considered full gameplay ideas, they need a little more context, some of which would be provided by the final version of this software, but for now, a human could still get plenty of value out of the current version (if usability were added) by providing that context themselves. For example, my friend implemented the first idea as "Portal Blocks," a discrete Block subtype with its own distinct behavior, which is only natural. But there's also nothing stopping a savvy game designer from, for example, implementing those ideas as conditional global modifiers, or in some other arbitrary fashion. (This is where Instructions and Rules, my other two fundamental gameplay elements, would come in, but that will have to wait until a future version.)

Even without that extra context, there are plenty of very good ideas in plain sight. Simply looking at the Effects objects in the Scene is enough to help a game designer reduce time spent brainstorming significantly, but the above three particular examples of Block type ideas are also spelled out in the Dynamics list. The name structure is 'Pair_[EventName]_[EffectName]' (but many of the Event and Effect names have underscores... sorry -_-;). These are the names of the GameObjects that represent the three ideas listed above:

"Pair_Collision_Ball_Block_ChangeObjectNumberPropertyValue_Ball_xPosition"
"Pair_Collision_Ball_Block_ChangeObjectNumberPropertyValue_Ball_yPosition"
"Pair_Collision_Ball_Block_SpawnBlock"
"Pair_Collision_Ball_Block_DespawnBlock"
"Pair_Collision_Ball_Block_ChangeObjectNumberPropertyValue_Paddle_objectSprite.xScale"
"Pair_Collision_Ball_Block_ChangeObjectNumberPropertyValue_Paddle_objectSprite.yScale"

(This data used to also be stored in a script component attached to the object, but those got lost after trying and failing to crunch out prototype v2. Future versions of the Unity tool would absolutely store this data in a Prefab instance's script component (or export it).)

This example generated a lot of genuinely useful material from an extremely limited dataset - there's not a lot going on in Breakout, but it turns out that it's really just a few lines of code away from having most any of these great new ideas in some primitive form (not that there's necessarily room for any of that on the cartridge). This particular gameplay design territory is very well-trodden, so it should be a good case study for the paradigm: the basic examples shown here, which function adequately without context, will contrast against the myriad existing derivatives that don't (i.e. non-trivial interactions, such as collectibles), revealing key differences which will help define the shape of the rest of the paradigm.

By examining the difference between a plain old Breakout Block and a Block with one of these special Effects, the structure of game dynamics becomes clear: the designer is engineering situations where certain Events may occur, and the Effects of those Events are fully customizable. When one goes to brainstorm custom Block types for a Breakout clone (i.e. discrete Block subtypes with their own distinct behavior), one is choosing a custom Effect for the specific Event of a Ball colliding with a specific instance of a Block. Hence, a game dynamic is an Event-Effect pair. This version of the program just showcases a bunch of those, made under some arbitrary, realistic, and intentionally simple conditions.

Here are some other yet-unmentioned aspects of this project awaiting a future version or separate development:

1) Tools to generate sets of gameplay elements, which one would combine into dynamics using this project. The structure of the fundamental elements is expressible as JSON & JSON Schema, so a web tool for creating element sets in that format would enable engine-free gameplay design on any device. It's even trivial to directly convert the JSON & Schema into the engine scripts that describe the object structure (this is actually how all of those scripts were made for this project).
2) Element metadata.
3) Data visualization and analysis tools (which will change the industry forever).
4) Direct conversion of dynamics (and other gameplay elements) into fully-functional behaviour scripts, and eventually into working prototypes (will require the full paradigm, but will also change the industry forever).

However, the next thing on this project's to-do list is for me to read Robert Zubek's new book, Elements of Game Design, which sounds like it will either obsolete or uphold some or all of my paradigm; the future of this project will resemble whatever paradigm remains afterward.