using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBurglarScript : MonoBehaviour
{
    [SerializeField]  Text _timerText;
    [SerializeField]  Text _pinOne;
    [SerializeField]  Text _pinTwo;
    [SerializeField]  Text _pinThree;
    [SerializeField]  Image _victory;
    [SerializeField]  Image _defeat;
    float timer = 30f;
    int pinOne;
    int pinTwo;
    int pinThree;
    int prPinOne;
    int prPinTwo;
    int prPinThree;

    void Start()
    {
        variablesRandom();
        Print();
  

    }

    void Update()
    {
         Timer();
         messageVictory();      
    }
    void Timer()
    {
        if (timer > 0)
            timer-=Time.deltaTime;
        if (timer <= 0)
        {
            timer = 0;
            _defeat.gameObject.SetActive(true);
        }
            
           _timerText.text = Mathf.Round(timer).ToString();
    }
    
   public void onDrillButton()
    {
        prPinOne += 1;
        prPinTwo -= 1;
        Print();
    }
   public void onHammerButton()
    {
        prPinOne -= 1;
        prPinTwo = 2;
        prPinThree -= 1;

        Print();

    } 
   public void onMasterKeyButton()
    {
        prPinOne -= 1;
        prPinTwo += 1;
        prPinThree += 1;
        Print();

    }
    public void onAgainButton()
    {

        SceneManager.LoadScene("Burglar_vs1");

    }
    void Print()
    {
        _pinOne.text = prPinOne.ToString();
        _pinTwo.text = prPinTwo.ToString();
        _pinThree.text = prPinThree.ToString();
       
    }
    void variablesRandom()
    {
        System.Random random = new System.Random();
        pinOne = 5;
        pinTwo = 5;
        pinThree = 5;
        prPinOne = 6;
        prPinTwo = 4;
        prPinThree = 4;  
    }
    void messageVictory()
    {
       if (pinOne == prPinOne & pinTwo == prPinTwo & pinThree == prPinThree)
        {
            _victory.gameObject.SetActive(true);
        }
    }
    

}
