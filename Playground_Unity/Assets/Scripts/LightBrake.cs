using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBrake : LightCustoms
{
    [SerializeField] Material material;
    //[SerializeField] Color baseColor;
    public Animator anim;
    public void ActiveBrake(bool bul)
    {
        anim.SetBool("isBrake", bul);
    }
}
