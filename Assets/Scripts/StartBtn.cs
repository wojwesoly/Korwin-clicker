using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public Button btn;
    void Start()
    {
        Button StartBtn = btn.GetComponent<Button>();
        StartBtn.onClick.AddListener(Load);
    }

    void Update()
    {
        
    }

    public void Load()
    {
        SceneManager.LoadScene("Game");
    }
}
