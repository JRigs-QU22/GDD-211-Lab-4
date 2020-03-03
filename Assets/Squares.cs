using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Squares : Enemy
{
    public Player Player;
    public Text Damage;
    float DamageTaken = 0;

    [Range(0f, 1f)] public float DamageMod;

    
    public override void TakeDamage(float dmg)
    {
        if (Player.hit)
        {
            float modDamage = dmg * (1f + DamageMod);
            Health += modDamage;

            DamageTaken = DamageTaken + modDamage;
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") + 1);
            Damage.text = Name + " has taken " + DamageTaken + " damage";
            Debug.Log(Name + " took " + modDamage);
        }
        
    }
}
