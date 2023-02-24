using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class ShootPatern : StateMachineBehaviour
{
    [SerializeField] public GameObject _bulletPrefab;
    public float m_fireRate = 1.5f;
    private float _nexTimeToShoot;
    public static GameObject _bullet;
    public  float _speed = 2;
    public UnityEngine.Transform _playerTransform;
    public RewardManager rwMana;
    public static Animator animator;


    

    private void Awake()
    {
        rwMana = GameObject.Find("RewardManager").GetComponent<RewardManager>();
        
    }


    public static void DoubleShot()
    {
        var Shot = new ShootPatern();
        //Il y a 50 % de chance que le joueur tire une seconde fois.
        // Génère un nombre aléatoire entre 0 et 1
        float randomNum = Random.Range(0f, 1f);

         //  // Vérifie si le nombre aléatoire est supérieur ou égal à 0.5
         //  if (randomNum >= 0.5f)
         //  {
         //  Shot.Attack();
         //      // Fait quelque chose
         //      Debug.Log("Je fais quelque chose !");
         //  }
         //  else
         //  {
         //      // Ne fait rien
         //      Debug.Log("Je ne fais rien.");
         //  }



    }

    


    public void Attack()
    {
        Vector2[] _directions = new Vector2[4]
{
        Vector2.right,
        Vector2.left,
        Vector2.up,
        Vector2.down
};



        foreach (var direction in _directions)
        {

            _bullet = Instantiate(_bulletPrefab, animator.gameObject.transform.position, Quaternion.identity);
            //_nexTimeToShoot = Time.timeSinceLevelLoad + m_fireRate;
            //_rgb2D.velocity = direction * Time.fixedDeltaTime * 50;
            _bullet.GetComponent<Rigidbody2D>().velocity = direction * _speed;
            _bullet.transform.parent = GameObject.Find("BulletGroup").transform;
            Destroy(_bullet, 1);

        }
    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector2[] _directions = new Vector2[4]
{
        Vector2.right,
        Vector2.left,
        Vector2.up,
        Vector2.down
};

        

        foreach (var direction in _directions) 
        {

            _bullet = Instantiate(_bulletPrefab, animator.gameObject.transform.position, Quaternion.identity);
            //_nexTimeToShoot = Time.timeSinceLevelLoad + m_fireRate;
            //_rgb2D.velocity = direction * Time.fixedDeltaTime * 50;
            _bullet.GetComponent<Rigidbody2D>().velocity = direction * _speed;
            _bullet.transform.parent = GameObject.Find("BulletGroup").transform;
            Destroy(_bullet, 1);
            
        }

        rwMana.MonEvent2.Invoke();
        //Destroy(_bullet, 2);
    }

      






    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        


    }
}
// OnStateMove is called right after Animator.OnAnimatorMove()
//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
//{
//    // Implement code that processes and affects root motion
//}

// OnStateIK is called right after Animator.OnAnimatorIK()
//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
//{
//    // Implement code that sets up animation IK (inverse kinematics)
//}

