using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirBag : MonoBehaviour, IToggleable
{
    public SpriteRenderer spriteRenderer;
    public float alphaValue = 0.2f; 

    void Start()
    {
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();

        Color newColor = spriteRenderer.color;
        newColor.a = alphaValue;
        spriteRenderer.color = newColor;
    }
    public void Alert(bool bul)
    {
        if(bul)
        {
            alphaValue = 1f;
            Color newColor = spriteRenderer.color;
            newColor.a = alphaValue;
            spriteRenderer.color = newColor;
        }
        else
        {
            alphaValue = 0.2f;
            Color newColor = spriteRenderer.color;
            newColor.a = alphaValue;
            spriteRenderer.color = newColor;
        }
    }

    public void ActiveFunction(bool isActive)
    {
        Alert(isActive);
    }
}
