using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PWPawn : Pawn {

    public float StartingHealth = 100.0f;
    public float Health = 100.0f;

    public virtual void Horizontal(float value)
    {
        //LOG("PWPawn: Horizontal");
    }

    public virtual void Vertical(float value)
    {
        //LOG("PWPawn: Verticle");
    }

    public virtual void Fire1(bool value)
    {
        LOG("PWPawn: Fire1");   
    }

    public virtual void Fire2(bool value)
    {
        LOG("PWPawn: Fire2");
    }

    public virtual void Fire3(bool value)
    {
        LOG("PWPawn: Fire3");
    }

    public virtual void Fire4(bool value)
    {
        LOG("PWPawn: Fire4");
    }
}
