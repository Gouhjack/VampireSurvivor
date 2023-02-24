using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class EnnemyBehaviour : MonoBehaviour
{


    public Animator _animator;
    public bool isDead = false;
    KillCounter killCounterScript;
    RewardManager rwMana;




    private void Start()
    {
        killCounterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
        rwMana = GameObject.Find("RewardManager").GetComponent<RewardManager>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            rwMana.MonEvent.Invoke(transform.position);
            StartCoroutine(EnemyDeath());
            
            
        }
        
    }

    private IEnumerator EnemyDeath()
    {
        
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        _animator.SetBool("isDead", true);
        Debug.Log(rwMana.MonEvent);
        
        yield return new WaitForSeconds(1);
        
        Destroy(gameObject);
        killCounterScript.AddKills();

    }




}
