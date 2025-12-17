using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToXQ()
    {
        SceneManager.LoadScene("先秦");
    }
    public void ToHJ()
    {
        SceneManager.LoadScene("汉晋");
    }
    public void ToTS()
    {
        SceneManager.LoadScene("唐宋");
    }
    public void ToYMQ()
    {
        SceneManager.LoadScene("元明清");
    }
    
    public void ToZM()
    {
        SceneManager.LoadScene("正门");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ToXQ();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ToHJ();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ToTS();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ToYMQ();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            ToZM();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            UnityEngine.Application.Quit();
        }
    }
}
