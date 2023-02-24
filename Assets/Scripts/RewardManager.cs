using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.Events;
using UnityEngine.UI;
using JetBrains.Annotations;


public class EventVector3 : UnityEvent<Vector3>
{

}
public class RewardManager : MonoBehaviour
{


    public EventVector3 MonEvent;
    public UnityEvent MonEvent2;
    [SerializeField] public GameObject bonusProjectilePrefab;
    [SerializeField] public float bonusProjectileSpeed = 10;


    public void Start()
    {
        MonEvent = new EventVector3();
        
    }


    public static void DoubleShot()
    {
        //Il y a 50 % de chance que le joueur tire une seconde fois.

        Debug.Log("Double balle");
        


    }

    public void BonusBullet(Vector3 position)
    {
        //Un projectile bonus part d'un ennemi vaincu dans une direction aléatoire.

        Debug.Log("Balle Bonus");
        // Créer un nouveau projectile bonus
        GameObject bonusProjectile = Instantiate(bonusProjectilePrefab, position, Quaternion.identity);
        bonusProjectile.name = "Projectile Bonus";
        // Utiliser un générateur de nombres aléatoires pour déterminer la direction dans laquelle le projectile bonus partira

        float angle = Random.Range(0, 360);
        Vector2 direction = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad));

        // Appliquer une force au projectile bonus dans la direction aléatoire
        Rigidbody2D bonusProjectileRigidbody = bonusProjectile.GetComponent<Rigidbody2D>();
        bonusProjectileRigidbody.AddForce(direction * bonusProjectileSpeed, ForceMode2D.Impulse);
    }

    public void ClickEffect1()
    {
        Debug.Log("Effect1");
        MonEvent.AddListener(BonusBullet);
        Time.timeScale = 1;

    }




    public void ClickEffect2()
    {
        Debug.Log("Effect2");
        MonEvent2.AddListener(DoubleShot);
        Time.timeScale = 1;


    }

}
