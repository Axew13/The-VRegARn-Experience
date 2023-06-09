# VRegARn-Experience
University VR/AR project that I might expand on. Teaches about the environmental impact of animal farming (as per the assignment), but also the ethics of it. Title is an awkward way of combining "VR," "AR," and "Vegan."

Packages are not included. You will need to download:
- Vuforia (latest version)
- TextMeshPro (may automatically download)

## Main Goals
- [x] Dialogue system that loads from text files and works on all devices
- [ ] Linear storyline where you learn about cow farming vs. plant farming and convert a factory to produce plant-based food
- [x] AR support where you tap objects imposed onto an image target
- [ ] VR support where you can see the scene on a virtual table in an entirely VR space, and touch objects in it (alternatively, tracking when objects are near the center of view, or a tool (eg. wand, laser beam) can be used)

## Stretch Goals
- [ ] Add audio
- [ ] Modify VR support to allow you to walk around inside the scene (may be uncomfortable due to low-poly)
- [ ] Add AR+VR Mode which is just the old VR mode but it projects onto the paper
- [ ] Merge pop-up management into the `DialogueManager` class. Right now, pop-ups are managed by a `Popup` class on every pop-up.
- [ ] Have a way to manage scene scripts from `Raycastable` objects without `GameObject.Find()`ing them.

## Credits
- :musical_note: [GreaseMonkey - Rinse](https://soundcloud.com/iamgreaser/fromage-rinse) - Licensed under CC BY-SA 3.0
- :musical_note: [GreaseMonkey - Lather](https://soundcloud.com/iamgreaser/lather-fromage-ost) - Licensed under CC BY-SA 3.0