using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public bool posicaoEsquerda;
    public bool posicaoMeio;
    public bool posicaoDireita;

    public float movementUnits;
    void Start()
    {
        posicaoEsquerda = false;
        posicaoMeio = true;
        posicaoDireita = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MovePlayerLeft()
    {
        transform.Translate(-movementUnits, 0, 0);

        if (posicaoMeio == true)
        {
            posicaoMeio = false;
            posicaoEsquerda = true;
        }

        else if (posicaoDireita == true)
        {
            posicaoMeio = true;
            posicaoDireita = false;
        }
    }
    public void MovePlayerRight()
    {
        transform.Translate(+movementUnits, 0, 0);

        if (posicaoMeio == true)
        {
            posicaoMeio = false;
            posicaoDireita = true;
        }

        else if (posicaoEsquerda == true)
        {
            posicaoMeio = true;
            posicaoEsquerda = false;
        }
    }

}
