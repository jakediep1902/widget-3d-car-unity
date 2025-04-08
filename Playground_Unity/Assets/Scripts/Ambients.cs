using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambients : MonoBehaviour, IActions, IToggleable
{
    //public string hexColor = "#0000FF"; // Màu xanh dương
    public Material mat;
    public float intensity = 6f;
    void Start()
    {
        //Renderer renderer = GetComponent<Renderer>();s
        //mat = renderer.material;
       
       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            //ChangeColorAmbient(hexColor);
           
        }
        if(Input.GetKeyUp(KeyCode.C))
        {
            //ChangeColorAmbient("#03fcfc");
        }
    }
    //public void ChangeColorAmbient(string hexColor)
    //{
    //    if (ColorUtility.TryParseHtmlString(hexColor, out Color emissionColor))
    //    {
    //        mat.SetColor("_EmissionColor", emissionColor * intensity); // Tăng độ sáng
    //        mat.EnableKeyword("_EMISSION"); // Bật Emission
    //    }
    //    else
    //    {
    //        Debug.LogError("Mã màu Hex không hợp lệ!");
    //    }
    //}

    public void ActiveFunctionsByAction(string actionName, string hexColor)
    {
        switch(actionName)
        {
            case"set_color":

                if (ColorUtility.TryParseHtmlString(hexColor, out Color emissionColor))
                {
                    mat.SetColor("_EmissionColor", emissionColor * intensity); // Tăng độ sáng
                    mat.EnableKeyword("_EMISSION"); // Bật Emission
                }
                else
                {
                    Debug.LogError("color Hex is wrong! ");
                }
                break;
        }
        
    }

    public void ActiveFunction(bool isActive)
    {
        if(isActive)
        { 
            mat.EnableKeyword("_EMISSION"); // Bật Emission
        }
        else
        {
            mat.DisableKeyword("_EMISSION");
        }
       
    }
}
