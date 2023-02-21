using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    #region Exposed

    

    [SerializeField]
    float m_fireRate = 1.5f;





    #endregion

    #region Unity LifeCycle
    void Start()
    {

    }

    void Update()
    {
        if (/*Input.GetButtonDown("Fire3") && as*/Time.timeSinceLevelLoad > _nexTimeToShoot)
        {
            Debug.Log("ziz");
            _nexTimeToShoot = Time.timeSinceLevelLoad + m_fireRate;
            

        }

    }



    #endregion

    #region Methods

     



    #endregion

    #region Private & Protected

    private float _nexTimeToShoot;

    #endregion
}