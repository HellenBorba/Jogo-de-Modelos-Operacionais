using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Fim : MonoBehaviour
{
    public void vaiMenu()
    {
        SceneManager.LoadScene("Scene_Menu");
    }
    public void Jogar()
    {
        SceneManager.LoadScene("Scene_1");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
