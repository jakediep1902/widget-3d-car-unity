function sayHello() {
  alert("Hello");
}
function ShowInfo(info) {
  console.log("Info sent from Unity is: ----------->  " + Number(info));
}

function SetAPIFromUnity(name, value) {
  console.log(`Unity request set component ${name} ------>  ${value}`);
  switch (name) {
    case "door1":
      setApiValue("Vehicle.Cabin.Door.Row1.DriverSide.IsOpen", value);
      break;
    case "trunk_front":
      setApiValue("Vehicle.Body.Trunk.Front.IsOpen", value);
      break;
    case "trunk_front_position":
      setApiValue("Vehicle.Body.Trunk.Front.Position", value);
      break;
    case "trunk_rear":
      setApiValue("Vehicle.Body.Trunk.Rear.IsOpen", value);
      break;
    case "trunk_rear_position":
      setApiValue("Vehicle.Body.Trunk.Rear.Position", value);
      break;
    case "window_1":
      setApiValue("Vehicle.Cabin.Door.Row1.DriverSide.Window.IsOpen", value);
      break;
    case "window_2":
      setApiValue("Vehicle.Cabin.Door.Row1.PassengerSide.Window.IsOpen", value);
      break;
    case "window_3":
      setApiValue("Vehicle.Cabin.Door.Row2.DriverSide.Window.IsOpen", value);
      break;
    case "door_1":
      setApiValue("", value);
      break;
    case "door_2":
      setApiValue("", value);
      break;
    case "row2_door3":
      setApiValue("Vehicle.Cabin.Door.Row2.DriverSide.IsOpen", value);
      break;
    case "row2_door3_position":
      setApiValue("Vehicle.Cabin.Door.Row2.DriverSide.Position", value);
      break;
    case "row2_door4":
      setApiValue("Vehicle.Cabin.Door.Row2.PassengerSide.IsOpen", value);
      break;
    case "row2_door4_position":
      setApiValue("Vehicle.Cabin.Door.Row2.PassengerSide.Position", value);
      break;
    default:
      console.log("Unknown name: " + name);
      break;
  }
}
ReceiveCameraPosition = function (x, y, z) {
  const driver_x = -1.7
  const driver_y = 0.98
  const driver_z = 2.410

  let distance = 2.4*(Math.abs(x-driver_x) + Math.abs(y-driver_y))
  let divDistance = document.getElementById("distance")
  if(divDistance){
      console.log("ProximitySignalName", ProximitySignalName)
      if(ProximitySignalName && setApiValue) {
            setApiValue(ProximitySignalName, distance.toFixed(2))
      }
      divDistance.textContent  = distance.toFixed(2)
  }
//   console.log("distance", distance)
};
