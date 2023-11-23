using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scnmng : MonoBehaviour
{
    public void LoadScene1(string home)
    {
        
        SceneManager.LoadScene(0);
    }
    public void LoadScene2(string items)
    {

        SceneManager.LoadScene(1);
    }


    public void LoadScene3(string laptop)
    {

        SceneManager.LoadScene(2);
    }

    public void LoadScene4(string shoe)
    {

        SceneManager.LoadScene(3);
    }

    public void LoadScene5(string watch)
    {

        SceneManager.LoadScene(4);
    }

    public void LoadScene6(string glass)
    {

        SceneManager.LoadScene(5);
    }
    public void LoadScene7(string endpage)
    {

        SceneManager.LoadScene(6);
    }



    public void QuitGame()
    {
        
        Application.Quit();
    }
}
