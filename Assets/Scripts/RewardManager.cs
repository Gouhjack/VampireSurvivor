using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.Events;
using UnityEngine.UI;
using JetBrains.Annotations;

public class RewardManager : MonoBehaviour
{

    public delegate void MyDelegate();

    public event MyDelegate MyEvent;

    public UnityEvent MonEvent;

    public void Start()
    {
        MonEvent.AddListener(BonusBullet);
    }

    public void Raise()
    {
        MyEvent.Invoke();
    }



    public static void BonusBullet()
    {
        //Un projectile bonus part d'un ennemi vaincu dans une direction aléatoire.

        Debug.Log("Balle Bonus");
        //Time.timeScale = 0f;



    }
    public static void DoubleShot()
    {
        //Il y a 50 % de chance que le joueur tire une seconde fois.

        Debug.Log("Double balle");




    }


}
