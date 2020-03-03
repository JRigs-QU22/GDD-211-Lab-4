using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string Name;
    public float Health;

    public virtual void TakeDamage(float dmg)
    {

    }
}
