using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region Exposed

    public GameOverScreen GameOverScreen;

    #endregion

    #region Unity LifeCycle

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            {
                GameOver();
               
            }
    }


    public void GameOver()
    {
        GameOverScreen.Setup();
        Time.timeScale= 0f;
    }
    #endregion

    #region Methods

    #endregion

    #region Private & Protected

    #endregion
}
