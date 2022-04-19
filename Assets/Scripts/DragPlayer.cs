using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragPlayer : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 direction;
    public float distanciaMinimaParaMover;
    public bool Limitador;

    public GameObject player;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                Limitador = true;
            }
            if (touch.phase == TouchPhase.Moved && Limitador == true)
            {
                direction = touch.deltaPosition; 
                if (Mathf.Abs(direction.x) >= distanciaMinimaParaMover)
                {
                    
                    Limitador = false;
                    if (direction.x >= 0)
                    {
                        Debug.Log("Mova o player RIGHT :)");
                        if (player.GetComponent<MovePlayer>().posicaoMeio == true)
                        {
                            player.GetComponent<MovePlayer>().MovePlayerRight();
                        }
                        else if (player.GetComponent<MovePlayer>().posicaoEsquerda == true)
                        {
                            player.GetComponent<MovePlayer>().MovePlayerRight();
                        }

                    }
                    if (direction.x <= 0)
                    {
                        Debug.Log("Mova o player LEFT :)");
                        if (player.GetComponent<MovePlayer>().posicaoMeio == true)
                        {
                            player.GetComponent<MovePlayer>().MovePlayerLeft();
                        }
                        else if (player.GetComponent<MovePlayer>().posicaoDireita == true)
                        {
                            player.GetComponent<MovePlayer>().MovePlayerLeft();
                        }
                    }
                }
            }

        }
    }
}
