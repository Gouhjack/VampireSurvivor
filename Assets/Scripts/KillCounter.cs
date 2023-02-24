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
    public GameObject BoostsPannel;
    [SerializeField] public AnimationCurve _killCurve;
    


    #endregion

    #region Unity LifeCycle
    void Start()
    {
        //BoostsPannel = GameObject.FindGameObjectWithTag("Pannel");
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
        if (_kills == 10)
        {
            Time.timeScale = 0;
            BoostsPannel.SetActive(true);

        }
        else if (_kills == 30) 
        {
            Time.timeScale = 0;
            BoostsPannel.SetActive(true);
        }
        else if (_kills == 60)
        {
            Time.timeScale = 0;
            BoostsPannel.SetActive(true);
        }
        else if (_kills == 100)
        {
            Time.timeScale = 0;
            BoostsPannel.SetActive(true);
        }


    }

    

    #endregion

    #region Private & Protected

    #endregion
}
