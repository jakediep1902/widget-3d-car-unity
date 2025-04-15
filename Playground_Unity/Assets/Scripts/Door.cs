using UnityEngine;

public class Door : MonoBehaviour, IToggleable, IActions, ILockable
{
    // Rotation speed of the car door
    public float rotationSpeed = 5f;

    // Target angles for open and close states
    public float openAngle = 70f;
    public float maxAngle;
    public float closedAngle = 0f;

    // Current state of the door
    public bool isOpen = false;
    public bool isLocked = false;

    // Reference to the door GameObject
    public Transform doorTransform;

    // Update is called once per frame
    void Update()
    {      
        // Smoothly rotate the door to its target angle
        Quaternion targetRotation = Quaternion.Euler(0, openAngle, 0);
        doorTransform.localRotation = Quaternion.Slerp(doorTransform.localRotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
    
    // Method to toggle the door state
    public void OpenDoor()
    {
        if (isLocked) return;
        SetAngleDoor("90");
    }
    public void CloseDoor()
    {
        if (isLocked) return;
        SetAngleDoor("0");
    }

    public void LockDoor()
    {
        SetAngleDoor("0");
        isLocked = true;
    }

    public void UnLockDoor()
    {
        SetAngleDoor("0");
        isLocked = false;
    }
    //public void IsOpenDoor(bool value)
    //{
    //    if (isLocked) return;
    //    SetAngleDoor(value?"100":"0");
    //}

    public void ActiveFunction(bool isActive)
    {
        //if (!isLocked)
            //isOpen = isActive;
        if(!isActive)
        {
            WebGLInteraction.SetValueAPIBrowser($"{gameObject.name}_position","0"); 
        }
    }

    public void ActiveFunctionsByAction(string actionName, string options)
    {
        switch(actionName)
        {
            case "position":
                SetAngleDoor(options);            
                break;
        }
    }
    public void SetAngleDoor(string angle)
    {        
        if (float.TryParse(angle,out var result))
        {
            if (isLocked) return;
            if (result > 0)
            {
                WebGLInteraction.SetValueAPIBrowser(gameObject.name, "true");
            }
            else
            {
                WebGLInteraction.SetValueAPIBrowser(gameObject.name, "false");
            } 
            openAngle = result * maxAngle / 100f;
            WebGLInteraction.SendDataMessage(openAngle.ToString());
        }
    }

    public void Locked(bool bul)
    {      
            isLocked = bul;
    }
}
