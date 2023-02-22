using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnnemyBehaviour : MonoBehaviour
{
    public Animator _animator;
    public bool isDead = false;
    
    KillCounter killCounterScript;

    

    private void Start()
    {
        killCounterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            StartCoroutine(EnemyDeath());
            
            
        }
        
    }

    private IEnumerator EnemyDeath()
    {
       
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        _animator.SetBool("isDead", true);
        yield return new WaitForSeconds(2);        
        Destroy(gameObject);
        
        killCounterScript.AddKills();

    }
}
