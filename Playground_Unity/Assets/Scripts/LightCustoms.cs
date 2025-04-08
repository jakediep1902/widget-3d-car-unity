using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCustoms : MonoBehaviour
{    
    private void Start()
    {
        //gameObject.SetActive(false);      
    }
   
    public void SwitchOnOff(bool bul)
    {
        gameObject.SetActive(bul);
    }     
}
