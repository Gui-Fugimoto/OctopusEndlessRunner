using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarCena : MonoBehaviour
{
    
    public void MudarCenas(string nomeCena)
    {
        LoadScreenManager.Instance.LoadScene(nomeCena);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
