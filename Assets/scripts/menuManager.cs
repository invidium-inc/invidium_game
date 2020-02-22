using UnityEngine;

public class menuManager : MonoBehaviour
{

    public GameObject progressScreen;
    public GameObject quitScreen;


    public void VerifyQuit()
    {
        quitScreen.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        quitScreen.SetActive(false);
        progressScreen.SetActive(false);
    }
}
