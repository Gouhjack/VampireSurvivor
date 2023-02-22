using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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


    #endregion

    #region Private & Protected

    #endregion
}
