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

List APIs:
1	Vehicle.Cabin.Door.Row1.DriverSide.IsLocked
2	Vehicle.Cabin.Door.Row1.DriverSide.IsOpen
3	Vehicle.Cabin.Door.Row1.DriverSide.Position
4	Vehicle.Cabin.Door.Row1.DriverSide.Window.IsOpen
5	Vehicle.Cabin.Door.Row1.DriverSide.Window.Position
6	Vehicle.Cabin.Door.Row1.PassengerSide.IsLocked
7	Vehicle.Cabin.Door.Row1.PassengerSide.IsOpen
8	Vehicle.Cabin.Door.Row1.PassengerSide.Position
9	Vehicle.Cabin.Door.Row1.PassengerSide.Window.IsOpen
10	Vehicle.Cabin.Door.Row1.PassengerSide.Window.Position
11	Vehicle.Cabin.Door.Row2.DriverSide.IsLocked
12	Vehicle.Cabin.Door.Row2.DriverSide.IsOpen
13	Vehicle.Cabin.Door.Row2.DriverSide.Position
14	Vehicle.Cabin.Door.Row2.DriverSide.Window.IsOpen
15	Vehicle.Cabin.Door.Row2.DriverSide.Window.Position
16	Vehicle.Cabin.Door.Row2.PassengerSide.IsLocked
17	Vehicle.Cabin.Door.Row2.PassengerSide.IsOpen
18	Vehicle.Cabin.Door.Row2.PassengerSide.Position
19	Vehicle.Cabin.Door.Row2.PassengerSide.Window.IsOpen
20	Vehicle.Cabin.Door.Row2.PassengerSide.Window.Position
21	Vehicle.Body.Mirrors.DriverSide.IsFolded
22	Vehicle.Body.Mirrors.DriverSide.IsLocked
23	Vehicle.Cabin.Seat.Row2.PassengerSide.Position
24	Vehicle.Cabin.Seat.Row2.PassengerSide.Height
25	Vehicle.Body.Mirrors.PassengerSide.IsFolded
26	Vehicle.Body.Mirrors.PassengerSide.IsLocked
27	Vehicle.Cabin.Seat.Row2.DriverSide.Position
28	Vehicle.Cabin.Seat.Row2.DriverSide.Height
29	Vehicle.Body.Trunk.Front.IsLocked
30	Vehicle.Body.Trunk.Front.IsOpen
31	Vehicle.Body.Trunk.Front.Position
32	Vehicle.Body.Trunk.Front.IsLightOn
33	Vehicle.Body.Trunk.Rear.IsLocked
34	Vehicle.Body.Trunk.Rear.IsOpen
35	Vehicle.Body.Trunk.Rear.Position
36	Vehicle.Body.Trunk.Rear.IsLightOn
37	Vehicle.Body.Lights.Beam.High.IsOn
38	Vehicle.Body.Lights.Beam.Low.IsOn
39	Vehicle.Body.Lights.Brake.IsActive
40	Vehicle.Body.Lights.Hazard.IsSignaling
41	Vehicle.Body.Lights.LicensePlate.IsOn
42	Vehicle.Cabin.Light.AmbientLight.Row1.DriverSide.Color
43	Vehicle.Cabin.Light.AmbientLight.Row1.DriverSide.IsLightOn
44	Vehicle.Cabin.Light.AmbientLight.Row1.PassengerSide.Color
45	Vehicle.Cabin.Light.AmbientLight.Row1.PassengerSide.IsLightOn
46	Vehicle.AverageSpeed
47	Vehicle.Body.Windshield.Front.Wiping.Mode
48	Vehicle.Body.Windshield.Rear.Wiping.Mode
49	Vehicle.Cabin.Seat.Row1.DriverSide.Height
50	Vehicle.Cabin.Seat.Row1.PassengerSide.Height

Instruction: 
Copy any API above to "apis" in Edit Widget to active the API function
{
    "apis": [
        "Vehicle.Body.Windshield.Rear.Wiping.Mode",             <---API need to active
        "Vehicle.AverageSpeed",                                 <---API need to active
        "Vehicle.Cabin.Seat.Row2.PassengerSide.Height"          <---API need to active
    ],
    "vss_json": "https://bewebstudio.digitalauto.tech/data/projects/sHQtNwric0H7/vss_rel_4.1.json"
}
///
