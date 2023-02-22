using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    #region Exposed

    #endregion

    #region Unity LifeCycle
        public void Setup()
        {
            gameObject.SetActive(true);

        }
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    #endregion

    #region Methods

    #endregion

    #region Private & Protected

    #endregion
}
