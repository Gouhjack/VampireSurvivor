using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Exposed

    [SerializeField] private float _moveSpeed = 4f;   


    #endregion

    #region Unity LifeCycle

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    void Update()
    {
        SetDirection();
    }
    private void FixedUpdate()
    {
        _rb2D.velocity = _direction * Time.fixedDeltaTime * 50;

    }
    #endregion

    #region Methods

    private void SetDirection()
    {
        _direction.x = Input.GetAxisRaw("Horizontal") * _moveSpeed;
        _direction.y = Input.GetAxisRaw("Vertical") * _moveSpeed;

    }

    #endregion

    #region Private & Protected

    private Rigidbody2D _rb2D;
    private Vector2 _direction;
    private float _currentSpeed;



    #endregion
}
