```markdown
# ObjectActivationController

**ObjectActivationController** is a Unity script that cycles through a list of GameObjects, activating one at a time for a specified duration before switching to the next. Only one object is active at any given time, forming a continuous loop.

## Features
- 🔄 **Sequential Activation** – Cycles through GameObjects in order.
- ⏳ **Customizable Durations** – Set a unique activation time for each object.
- ♻️ **Automatic Looping** – Runs continuously, ensuring seamless transitions.
- 🎮 **Easy to Use** – Add and manage objects via the Unity Inspector.

## Installation
1. **Clone or Download** the repository:
   ```sh
   git clone https://github.com/hsuehyt/ObjectActivationController.git
   ```
2. Add `ObjectActivationController.cs` to an **empty GameObject** in your Unity scene.
3. In the **Inspector**, add GameObjects to the list and set their activation durations.

## Usage
1. Attach `ObjectActivationController.cs` to an **empty GameObject** in your scene.
2. In the **Inspector**, add GameObjects to the **Activation Slots** list.
3. Assign a **GameObject** to each slot and define its **activation duration**.
4. Press **Play** in Unity to see objects activate in sequence.

### Example
If you add three GameObjects (A, B, C) with an activation duration of **10 seconds** each:
1. **A** is activated for 10 seconds, then deactivated.
2. **B** is activated for 10 seconds, then deactivated.
3. **C** is activated for 10 seconds, then deactivated.
4. The cycle repeats indefinitely.

## Contributing
Contributions are welcome! If you have improvements or bug fixes, feel free to submit a **pull request**.

## License
This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

## Author
Created by [hsuehyt](https://github.com/hsuehyt).