using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnnemyMovement : MonoBehaviour
{
    #region Exposed
    private Transform _moveTarget;
    [SerializeField] public float _speed;
    [SerializeField] public Animator _animator;
    #endregion

    #region Unity LifeCycle
    void Start()
    {
        _moveTarget = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _moveTarget.position, (Time.deltaTime * _speed));
        if (_animator.GetCurrentAnimatorStateInfo(0).IsName("DeadEnemy") == true)
        {
            _speed = 0;
        }
    }
    private void FixedUpdate()
    {
        
    }
    #endregion

    #region Methods

    #endregion

    #region Private & Protected

    #endregion
}
