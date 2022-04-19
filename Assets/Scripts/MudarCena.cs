using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    public string nomeCena;
    public void MudarCenas()
    {
        SceneManager.LoadScene(nomeCena);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
