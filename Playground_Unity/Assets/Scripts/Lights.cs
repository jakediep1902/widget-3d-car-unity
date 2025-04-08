using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour, IToggleable
{
    public Material matMain;
    public Light mainLight;
    public void ActiveFunction(bool isActive)
    {
       if(isActive)
        {
            matMain.EnableKeyword("_EMISSION");
           
        }
        else
        {
            matMain.DisableKeyword("_EMISSION");         
        }
        mainLight.enabled = isActive;
    } 
}
