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

# List APIs:

## Group 1: Speed & Wiper & Trunk
```
Vehicle.AverageSpeed
Vehicle.Body.Windshield.Front.Wiping.Mode
Vehicle.Body.Windshield.Rear.Wiping.Mode
Vehicle.Body.Trunk.Front.IsLocked
Vehicle.Body.Trunk.Front.IsOpen
Vehicle.Body.Trunk.Front.Position
Vehicle.Body.Trunk.Front.IsLightOn
Vehicle.Body.Trunk.Rear.IsLocked
Vehicle.Body.Trunk.Rear.IsOpen
Vehicle.Body.Trunk.Rear.Position
Vehicle.Body.Trunk.Rear.IsLightOn
```

## Group 2: Row1: Door & Seat & Window
```
Vehicle.Cabin.Door.Row1.DriverSide.IsLocked
Vehicle.Cabin.Door.Row1.DriverSide.IsOpen
Vehicle.Cabin.Door.Row1.DriverSide.Position
Vehicle.Cabin.Door.Row1.DriverSide.Window.IsOpen
Vehicle.Cabin.Door.Row1.DriverSide.Window.Position
Vehicle.Cabin.Seat.Row1.DriverSide.Position
Vehicle.Cabin.Seat.Row1.DriverSide.Height

Vehicle.Cabin.Door.Row1.PassengerSide.IsLocked
Vehicle.Cabin.Door.Row1.PassengerSide.IsOpen
Vehicle.Cabin.Door.Row1.PassengerSide.Position
Vehicle.Cabin.Door.Row1.PassengerSide.Window.IsOpen
Vehicle.Cabin.Door.Row1.PassengerSide.Window.Position
Vehicle.Cabin.Seat.Row1.PassengerSide.Position
Vehicle.Cabin.Seat.Row1.PassengerSide.Height
```

## Group 3: Row2 Door & Seat & Window
```
Vehicle.Cabin.Door.Row2.DriverSide.IsLocked
Vehicle.Cabin.Door.Row2.DriverSide.IsOpen
Vehicle.Cabin.Door.Row2.DriverSide.Position
Vehicle.Cabin.Door.Row2.DriverSide.Window.IsOpen
Vehicle.Cabin.Door.Row2.DriverSide.Window.Position
Vehicle.Cabin.Seat.Row2.DriverSide.Position
Vehicle.Cabin.Seat.Row2.DriverSide.Height

Vehicle.Cabin.Door.Row2.PassengerSide.IsLocked
Vehicle.Cabin.Door.Row2.PassengerSide.IsOpen
Vehicle.Cabin.Door.Row2.PassengerSide.Position
Vehicle.Cabin.Door.Row2.PassengerSide.Window.IsOpen
Vehicle.Cabin.Door.Row2.PassengerSide.Window.Position
Vehicle.Cabin.Seat.Row2.PassengerSide.Position
Vehicle.Cabin.Seat.Row2.PassengerSide.Height
```

## Group 4: Lights & Mirrors
```
Vehicle.Body.Lights.Beam.High.IsOn
Vehicle.Body.Lights.Beam.Low.IsOn
Vehicle.Body.Lights.Brake.IsActive
Vehicle.Body.Lights.Hazard.IsSignaling
Vehicle.Body.Lights.LicensePlate.IsOn
Vehicle.Cabin.Light.AmbientLight.Row1.DriverSide.Color
Vehicle.Cabin.Light.AmbientLight.Row1.DriverSide.IsLightOn
Vehicle.Cabin.Light.AmbientLight.Row1.PassengerSide.Color
Vehicle.Cabin.Light.AmbientLight.Row1.PassengerSide.IsLightOn
Vehicle.Body.Mirrors.DriverSide.IsFolded
Vehicle.Body.Mirrors.DriverSide.IsLocked
Vehicle.Body.Mirrors.PassengerSide.IsFolded
Vehicle.Body.Mirrors.PassengerSide.IsLocked
```


# Instruction: 
Copy any API above to "apis" in Edit Widget to active the API function
```json
{
    "apis": [
        "Vehicle.Body.Windshield.Rear.Wiping.Mode",             <---API need to active
        "Vehicle.AverageSpeed",                                 <---API need to active
        "Vehicle.Cabin.Seat.Row2.PassengerSide.Height"          <---API need to active
    ],
    "vss_json": "https://bewebstudio.digitalauto.tech/data/projects/sHQtNwric0H7/vss_rel_4.1.json"
}
```
