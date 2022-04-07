using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformClick : MonoBehaviour
{
    // public GameObject plataformaEsquerda;
    //  public GameObject plataformaMeio;
    //  public GameObject plataformaDireita;
    public GameObject Player;
    public bool esquerda;
    public bool meio;
    public bool direita;
    // Start is called before the first frame update
    

    
   

    void MovePlayer()
    {
        if (esquerda == true)
        {
            if (Player.GetComponent<MovePlayer>().posicaoMeio == true)
            {
                Player.GetComponent<MovePlayer>().MovePlayerLeft();
            }
        }
        else if (meio == true)
        {
            if (Player.GetComponent<MovePlayer>().posicaoDireita == true)
            {
                Player.GetComponent<MovePlayer>().MovePlayerLeft();
            }
            else if (Player.GetComponent<MovePlayer>().posicaoEsquerda == true)
            {
                Player.GetComponent<MovePlayer>().MovePlayerRight();
            }
        }
        else if (direita == true)
        {
            if (Player.GetComponent<MovePlayer>().posicaoMeio == true)
            {
                Player.GetComponent<MovePlayer>().MovePlayerRight();
            }
        }
    }
}
