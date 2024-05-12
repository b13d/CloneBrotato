using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public int playerHP;

    public TextMeshProUGUI _txtScore;
    public Slider _sliderHpPlayer;

    public static GameManager instance;


    void Start()
    {
        if (instance == null)
        {
            instance = this;

            InitialData();
        } else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore()
    {
        score += 1;
        _txtScore.text = score.ToString();
    }

    public void DamageTaking()
    {
        playerHP -= 1;
        _sliderHpPlayer.value = playerHP;
    }

    void InitialData()
    {
        playerHP = 3;
        score = 0;

        _txtScore.text = score.ToString();
        _sliderHpPlayer.value = playerHP;
    }
}
