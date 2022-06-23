using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBurglarvs2 : MonoBehaviour
{
    [SerializeField] Image _gamestart;
    [SerializeField] Text _masterKey;
    [SerializeField] Text _key;
    [SerializeField] Text _bomb;
    [SerializeField] Image _clikBomb;
    [SerializeField] Image _clikKey;
    [SerializeField] Image _victory;
    [SerializeField] Image _defeat;
    [SerializeField] Image _messageMasterKey;
    float timer = 1f;
    int masterKey = 5;
    int key = 1;
    int bomb = 1;
    int pinOne;
    int pinTwo;
    int pinThree;
    int prPinOne;
    int prPinTwo;
    int prPinThree;
    bool proverka = false;
    void Start()
    {
        Print();
        variables();
    }

    
    void Update()
    {
      
    }

    public void onStartBullet()
    {
        _gamestart.gameObject.SetActive(true);
    }
    void variables()
    {
        
        pinOne = 8;
        pinTwo = 6;
        pinThree = 4;
        prPinOne = 6;
        prPinTwo = 10;
        prPinThree = 2;

    }
   

    public void onClicBomb()
    {
        _clikBomb.gameObject.SetActive(true);
    }
    public void onAgainButton()
    {
        SceneManager.LoadScene("Burglar_vs2");
    }
    public void onClikKeyButton()
    {
        _clikKey.gameObject.SetActive(true);
    }
    public void onResumeButton()
    {
        _clikKey.gameObject.SetActive(false);

    }
    public void onMasterKey()
    {
        variantRandom();
        if (!(masterKey == 0))
        {
            if (pinOne == prPinOne & pinTwo == prPinTwo & pinThree == prPinThree)
                _victory.gameObject.SetActive(true);
            else
            {
                _messageMasterKey.gameObject.SetActive(true);
              
            }

            masterKey--;
            Print();
        }
            else _defeat.gameObject.SetActive(true);
    }
   void variantRandom()
    {
        System.Random random = new System.Random();
        int vb = random.Next(2);
        if (!(vb == 1))
        {
            prPinOne += 1;
            prPinTwo -= 2;
            prPinThree += 1;

        }
        else
        {
            prPinOne -= 1;
            prPinTwo += 3;
            prPinThree += 1;
        }

    }
   public void onOkButton()
    {
        _messageMasterKey.gameObject.SetActive(false);
    }

    void Print()
    {
        _masterKey.text = "x" + masterKey.ToString();
        _key.text = "x" + key.ToString();
        _bomb.text = "x" + bomb.ToString();

    }
}
