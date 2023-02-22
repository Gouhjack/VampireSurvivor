using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class ShootPatern : StateMachineBehaviour
{
    public GameObject _bulletPrefab;
    public float m_fireRate = 1.5f;
    private float _nexTimeToShoot;
    public GameObject _bullet;
    public float _speed = 2;
    public UnityEngine.Transform _playerTransform;

    private void Awake()
    {
        
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
            
        }

        //Destroy(_bullet, 2);
    }

      




}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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

