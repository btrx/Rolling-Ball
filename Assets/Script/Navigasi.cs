using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigasi : MonoBehaviour
{
    public void Ulang()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void Keluar()
    {
        Application.Quit ();
    }

    public void Mulai()
    {
        SceneManager.LoadScene ("Main");
    }

    public void Help()
    {
        SceneManager.LoadScene ("Help");
    }
}
