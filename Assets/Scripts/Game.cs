using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Button Btn;
    public Button UpgBtn;
    public Button MenuBtn;
    public Text txt;
    private int score;
    private int inc = 1;

    void Start()
    {
        Btn = GameObject.Find("MainBtn").GetComponent<Button>();
        UpgBtn = GameObject.Find("UpgBtn").GetComponent<Button>();
        MenuBtn = GameObject.Find("MenuBtn").GetComponent<Button>();
        txt = GameObject.Find("ScoreLbl").GetComponent<Text>();

        Btn.onClick.AddListener(Click);
        UpgBtn.onClick.AddListener(Upgrade);
        MenuBtn.onClick.AddListener(Menu);

    }

    void Update()
    {
        txt.text = "Points: " + score;
    }

    void Click()
    {
        score += inc;
    }

    void Upgrade()
    {
        if (score >= 5)
        {
            inc++;
            score -= 5;
        }
    }

    void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
