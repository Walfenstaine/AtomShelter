using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayerPressed()
    {
        SceneManager.LoadScene("Scene1");  //������ ���������� ���� � ������� �� ����� 1
        
    }

    public void ExitPressed()  
    {
        Application.Quit();  // ������ ����� �� ����
    }

    void Update()
    {
        
    }
}

