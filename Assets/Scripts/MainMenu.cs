using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayerPressed()
    {
        SceneManager.LoadScene("Scene1");  //кнопка продолжить игру и перейти на сцену 1
        
    }

    public void ExitPressed()  
    {
        Application.Quit();  // кнопка выйти из игры
    }

    void Update()
    {
        
    }
}

