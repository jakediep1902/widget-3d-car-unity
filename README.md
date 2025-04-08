# Introduction

The 3D-Car project is an application that displays and controls a 3D car model in a browser using Unity WebGL build. Users can interact with the car through a web interface embedded in Playground, which provides APIs to control the car's functions.

## Technologies Used
- Blender: Editing and optimizing the 3D car model.
- Unity WebGL: Exporting the car model as WebGL to run in a browser.
- HTML, JavaScript: Web interface for displaying and controlling the car.
  
## Workflow
- Edit the car model in Blender and export it to Unity.
- In Unity, set up components and program the car's functions.
- Build the Unity project as WebGL and embed it into Playground.
- Playground provides APIs to communicate with the WebGL build.
- The HTML interface receives data from the Playground API and controls the car model.
  
## Directory Structure
```
3D-Car/
¦-- Playground Unity/                 # Folder containing all Unity assets
¦-- Build/                            # Unity WebGL build
¦-- Web/                                       
¦   +-- MainIndex.html               # Folder containing HTML files and web resources
¦   +-- FromUnity.js                 # Handles interaction with MainIndex.html from Unity
¦-- README.md                        # Project documentation
```

## Usage Guide
- Run WebGL Build:
- Open the Build/ folder and run the WebGL build.
- Embed MainIndex.html into Playground to connect with the API.
  
## Integration with Playground:
- Playground sends control data to WebGL via API.
- Actions such as changing the car color, adjusting speed, etc., are executed using Unity functions.
  
## Contribution
For any suggestions or improvements, please open an issue or submit a pull request!

The project is under development, please update the documentation as changes occur.
