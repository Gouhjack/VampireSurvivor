using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class KillCounter : MonoBehaviour
{
    #region Exposed

    public TextMeshProUGUI _counterText;
    public int _kills;
    
    
    


    #endregion

    #region Unity LifeCycle
    void Start()
    {
        
    }

    void Update()
    {


        ShowKills();


    }
    private void FixedUpdate()
    {
        
    }
    #endregion

    #region Methods

    private void ShowKills()
    {
        _counterText.text = _kills.ToString();
    }

    public void AddKills()
    {
        _kills++;
    }

    public void ShowButton()
    {
        if (_kills == 10)
        {
            Time.timeScale = 0;
            

        }


    }

    #endregion

    #region Private & Protected

    #endregion
}
