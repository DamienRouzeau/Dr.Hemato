using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public GameObject menu;
    public GameObject option;
    public GameObject tuto;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void start()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void goOptions()
    {
        menu.SetActive(false);
        option.SetActive(true);
    }

    public void OtoM()
    {
        menu.SetActive(true);
        option.SetActive(false);
    }

    public void goTuto()
    {
        menu.SetActive(false);
        tuto.SetActive(true);
    }
    public void TtoM()
    {
        menu.SetActive(true);
        tuto.SetActive(false);
    }

    public void quit()
    {
        Application.Quit();
    }
}