using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour,IClickable
{
    public Door doorParent;
    public bool isHandleActive = false;
    public void OnClickAction()
    {
        if(isHandleActive)
        {
            doorParent.OpenDoor();
            isHandleActive = !isHandleActive;
            WebGLInteraction.SetValueAPIBrowser(doorParent.name,"true");
        }
        else
        {
            doorParent.CloseDoor();
            isHandleActive = !isHandleActive;
            WebGLInteraction.SetValueAPIBrowser(doorParent.name, "false");
        }  
    }
}
