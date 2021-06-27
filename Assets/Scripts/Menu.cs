using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button btn;
    public Button btn1;
    void Start()
    {
        Button StartBtn = btn.GetComponent<Button>();
        Button ExitBtn = btn1.GetComponent<Button>();
        StartBtn.onClick.AddListener(Load);
        ExitBtn.onClick.AddListener(Exit);
    }
    
    public void Load()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
