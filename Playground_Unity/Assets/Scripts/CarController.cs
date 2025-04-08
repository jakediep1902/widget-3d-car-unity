using System.Collections.Generic;
using UnityEngine;
// Data structure to hold component control information
public class ComponentControlData
{
    public string name; // Name of the component to control
    public string action; // Action to perform on the component
    public string options; // Additional options for the action
}

public class CarController : MonoBehaviour
{
    public float speed = 0.1f;     
    private float moveInput;
    public float lastSpeed = 0f;
    private float turnInput;
    public float acceleration = 0.0001f;
    public Vector3 rollbackPos;
    // References to car components
    public BackgroundManager background;
    public Door_Row1_Driver door1; // Driver-side door in row 1
    public Door_Row1_Passenger door2; // Passenger-side door in row 1
    public Door door3;
    public List<LightCustoms> lightsBeams; // High beam lights
    public List<LightCustoms> lightHazard; // Brake lights
    public List<LightCustoms> lightBrake;
    public Trunk trunkRear; // Rear trunk
    public Seat seat1;
    public Seat seat2;
    public Wipper wipperFront;
    public Mirror mirrorLeft;
    public Mirror mirrorRight;
    public GameObject[] arrComponent = new GameObject[100];
    //public List<IToggleable> toggleEntities;
    public Dictionary<string, GameObject> entitiesManager;
    //public Dictionary<string, Func<string,GameObject>> entitiesActions;
    private void Start()
    {
        //entitiesActions = new Dictionary<string, Func<string, GameObject>>()
        //{
        //    {"row2_door3", name => GetComponentCarByName(name)},
        //    //{"mirror_right",name => GetComponentCarByName(name)},
        //};

        //MoveCar(10);

        entitiesManager = new Dictionary<string, GameObject>()
        {
            {"mirror_left"              ,arrComponent[0]},
            {"mirror_right"             ,arrComponent[1]},
            {"beam_high"                ,arrComponent[2]},
            {"beam_low"                 ,arrComponent[3]},
            {"seat1"                    ,arrComponent[4]},
            {"seat2"                    ,arrComponent[5]},
            {"window_1"                 ,arrComponent[6]},
            {"window_2"                 ,arrComponent[7]},
            {"ambientlight_1"           ,arrComponent[8]},
            {"ambientlight_2"           ,arrComponent[9]},
            {"row2_door3"               ,arrComponent[10]},
            {"window_3"                 ,arrComponent[11]},
            {"window_4"                 ,arrComponent[12]},
            {"row2_door4"               ,arrComponent[13]},
            {"wheels"                   ,arrComponent[14]},
            {"trunk_front"              ,arrComponent[15]},
            {"trunk_rear"               ,arrComponent[16]},
            {"rear_light"               ,arrComponent[17]},
            {"front_light"              ,arrComponent[18]},
            {"license_plate"            ,arrComponent[19]},
            {"wipper_rear"              ,arrComponent[20]},
            {"seat3"                    ,arrComponent[21]},
            {"seat4"                    ,arrComponent[22]},
            {"air_bag"                  ,arrComponent[23]},
            {"wipper_front"             ,arrComponent[24]},
            {"row1_door1"               ,arrComponent[25]},
            {"row1_door2"               ,arrComponent[26]},
        };
    }
    private void Update()
    {
        moveInput = Mathf.Lerp(lastSpeed, moveInput, acceleration);
        transform.Translate(Vector3.right * moveInput * speed * Time.deltaTime);
        lastSpeed = moveInput;
        RollbackPosition();
    }
    // Method to control components based on JSON data
    public void ControlComponent(string jsonData)
    {
        // Deserialize JSON string into ComponentControlData object
        ComponentControlData data = JsonUtility.FromJson<ComponentControlData>(jsonData);
        string entityName = data.name; // Name of the entity to control
        string action = data.action; // Action to perform
        string options = data.options; // Additional options

        //if(entitiesActions.TryGetValue(entityName,out var actions))
        //{
        //   GameObject entitys = actions.Invoke(entityName);
        //    if (bool.TryParse(action, out var result))
        //    {
        //        IToggleable toggleFunctions = entitys.GetComponent<IToggleable>();
        //        if (toggleFunctions != null)
        //        {
        //            toggleFunctions.ActiveFunction(result);
        //        }
        //    }
        //    else
        //    {
        //        IActions actionName = entitys.GetComponent<IActions>();
        //        if (actionName != null)
        //        {
        //            actionName.ActiveFunctionsByAction(action, options);
        //        }
        //    }
        //}

        if (entitiesManager.TryGetValue(entityName, out var entity))
        {
            if (bool.TryParse(action, out var result))
            {
                switch (options)
                {
                    case "islocked":
                        ILockable lockable = entity.GetComponent<ILockable>();
                        if (lockable != null)
                        {
                            lockable.Locked(result);
                        }
                        break;
                    default:
                        IToggleable toggleFunctions = entity.GetComponent<IToggleable>();
                        if (toggleFunctions != null)
                        {
                            toggleFunctions.ActiveFunction(result);
                        }
                        break;
                }
            }
            else
            {
                IActions actionName = entity.GetComponent<IActions>();
                if (actionName != null)
                {
                    actionName.ActiveFunctionsByAction(action, options);
                }
            }
        }

        // Determine which component to control based on the name
        switch (entityName)
        {        
            case "light_brake":
                PerformLightsAction(lightBrake, action, options); // Perform action brake on Hazard lights
                break;
            case "hazard_signaling":
                PerformLightsAction(lightHazard, action, options); // Perform action on Hazard lights wipper_front
                break;
        }
    }
    // Method to perform actions on a door
    public void PerformDoorAction(Door door, string action, string options)
    {
        switch (action)
        {
            case "open_door":
                door.OpenDoor(); // Open the door
                break;
            case "close_door":
                door.CloseDoor(); // Close the door
                break;
            case "lock_door":
                door.LockDoor(); // Lock the door
                break;
            case "unlock_door":
                door.UnLockDoor(); // Unlock the door
                break;
        }
    }

    // Method to perform actions on a list of lights
    public void PerformLightsAction(List<LightCustoms> lights, string action, string options)
    {
        switch (action)
        {
            case "turn_on_beam_low":
                foreach (LightBeam light in lights)
                {
                    light.LowBeams(); // Turn on the lights beam low
                }
                break;
            case "turn_on":
                foreach (LightBeam light in lights)
                {
                    light.HighBeams(); // Turn on the lights 
                }
                break;
            case "turn_off":
                foreach (LightBeam light in lights)
                {
                    light.OffBeams(); // Turn off the lights
                }
                break;
            case "turn_on_brake":
                foreach (LightBrake light in lights)
                {
                    light.ActiveBrake(true); // Turn on the lights brake
                }
                break;
            case "turn_off_brake":
                foreach (LightBrake light in lights)
                {
                    light.ActiveBrake(false); // Turn off the lights brake
                }
                break;
            case "turn_on_signal":
                foreach (LightHazard light in lights)
                {
                    light.ActiveHazard(true);// Turn on the lights hazard
                }
                break;
            case "turn_off_signal":
                foreach (LightHazard light in lights)
                {
                    light.ActiveHazard(false);// Turn off the lights hazard
                }
                break;
        }
    }
    public GameObject GetComponentCarByName(string name)
    {
        foreach (var item in arrComponent)
        {
            if (name == item.name)
            {
                return item;
            }
        }
        return null;
    }
    public void MoveCar(float move, float turn = 0f)
    {
        moveInput = move;
        turnInput = turn;
    }
    public void RollbackPosition()
    {
        Vector3 temp = transform.localPosition;
        if (temp.x > 100 || temp.x<-25)
        {
            background.HiddenBackground(true);
            transform.localPosition = rollbackPos;
        }
    }
}
