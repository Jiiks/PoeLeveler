Simple app for helping leveling in Path of Exile.

Copy the images to your build dir. Add your own step images in there.

If you want different hotkeys then compile it with your own hotkeys for now.

Create a `route.json` in the root dir and add your route there. 

Something like:

```json
[
	{
		"id": "Start",
		"passives": "step1.png",
		"regex": "b-b-|-b-b|b-.-b|b-b|nne|r-.-b|b-r-|g-b-r|g-r|r-g",
		"links": ["BBB", "BBBB", "RGB", "GBB"],
		"steps": [
			"Get rolling magma from Hillock reward, replace fireball.",
			"Go mud flats, submerged passage wp back to Hailrake"
		]
	},
	{
		"id": "Step2",
		"passives": "step1.png",
		"regex": "b-b-|-b-b|b-.-b|b-b|nne|r-.-b|b-r-|g-b-r|g-r|r-g",
		"links": ["BBB", "BBBB", "RRR", "GBB"],
		"steps": [
			"Get ele prolif, flame wall and frostblink as rewards, buy holy flame totem and goat horns.",
			"Run to prison and do dweller at wp."
		]
	},
	{
		"id": "Step3",
		"passives": "step1.png",
		"regex": "b-b-|-b-b|b-.-b|b-b|nne|r-.-b|b-r-|g-b-r|g-r|r-g",
		"links": ["BBB", "GGGG", "RGB", "GBB"],
		"steps": [
			"Buy gear, coral/sapphire rings, flasks, goat horns, etc.",
			"Kill Brutus"
		]
	}
]
```

Ignore the horrible code and bad practices this was made in 20 minutes.


<img width="1533" height="840" alt="image" src="https://github.com/user-attachments/assets/f58c3993-29eb-4ba4-89cd-fb8addec8111" />

