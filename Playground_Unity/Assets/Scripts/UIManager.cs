using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   // public static UIManager instance;
    public Toggle togDeveloperMode;
    public GameObject scrollView;
    public Toggle togTest;
    
    private void Start()
    {
        //if (instance == null)
        //{
        //    instance = this;
        //}
        //DontDestroyOnLoad(this.gameObject);

        togDeveloperMode.onValueChanged.AddListener(bul => EnableDeveloperMode(bul));
    }
    public void EnableDeveloperMode(bool isActive)
    {
        scrollView.SetActive(isActive);
    }
}
