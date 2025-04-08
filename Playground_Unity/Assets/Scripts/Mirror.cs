using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour, ILockable,IToggleable
{
    public Animator anim;
    bool isLocked = false;

    public void ActiveFunction(bool isActive)
    {
        if (isLocked) return;
        anim.SetBool("isFold", isActive);
    }

    //public float test { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Fold(bool isFold)
    {
        if (isLocked) return;
        anim.SetBool("isFold", isFold);
    }
    public void Locked(bool isLocked)
    {
        this.isLocked = isLocked;
    }

}
