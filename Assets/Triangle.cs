using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triangle : Enemy
{
    public float DoubleScore;
   // int score;
   public Text Damage;
    public Player Player;
    float DamageTaken = 0;

    public override void TakeDamage(float dmg)
    {
        if (Player.hit)
        {
            if (Random.value < DoubleScore)
            {
                Health -= dmg;
                DamageTaken = DamageTaken + dmg;
                Damage.text = Name + " has taken " + DamageTaken + " damage";
                PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") * 2);
                //score = score * 2;
                //Score.text = "Score: " + score;
            }
            else
            {
                Health -= dmg;
                //score++;
                //Score.text = "Score: " + score;
                DamageTaken = DamageTaken + dmg;
                PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") + 1);
                Damage.text = Name + " has taken " + DamageTaken + " damage";
                Debug.Log(Name + " took " + dmg + " damage");
            }
        }
        
    }
}
