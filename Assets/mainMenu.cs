using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void playGame()
    {
        SceneManager.LoadScene("BasicLevel");
    }

    public void quitGame()
    {
        Debug.Log("Quit game bro");
        Application.Quit();
    }

    public void SetVolume(float vol)
    {
        audioMixer.SetFloat("volume", vol);
    }

    public void Start()
    {
        audioMixer.SetFloat("volume", 0);
    }
}
