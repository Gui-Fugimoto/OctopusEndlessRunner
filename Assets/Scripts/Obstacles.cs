using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private int obsPosition;
    public int initialZrange;
    public int finalZrange;
    public float vectorX;
    public float vectorY;
    public float vectorZ;
    private float vectorZinicial;
    public bool isCollectible;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        //randomize positions
        GenerateRandX();
        GenerateRandZ();
        transform.position = new Vector3(vectorX, vectorY, vectorZinicial);

    }

    // Update is called once per frame
    void Update()
    {
        speed = FindObjectOfType<TileMovement>().forwardSpeed;
        transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (isCollectible == true)
        {
            if (other.gameObject.CompareTag("Inimigo"))
            {
                GenerateRandX();
                vectorZ = Random.Range(vectorZ, vectorZ + 15);
                transform.position = new Vector3(vectorX, vectorY, vectorZ);
                vectorZ -= 6;
            }

        }
        else if (isCollectible == false)
        {
            GenerateRandX();
            vectorZ = Random.Range(vectorZ, vectorZ + 15);
            transform.position = new Vector3(vectorX, vectorY, vectorZ);
            vectorZ -= 6;
        }


        //   if (other.gameObject.CompareTag("Inimigo"))
        //  {
        //     GenerateRandX();
        //      transform.position = new Vector3(vectorX, vectorY, vectorZ);
        //Debug.Log("colidiu INIMIGO");
        //   }
    }
    private void OnTriggerStay(Collider other)
    {
        if (isCollectible == true)
        {
            if (other.gameObject.CompareTag("Inimigo"))
            {
                GenerateRandX();
                vectorZ = Random.Range(vectorZ, vectorZ + 15);
                transform.position = new Vector3(vectorX, vectorY, vectorZ);
                vectorZ -= 6;
            }
            else if (other.gameObject.CompareTag("Player"))
            {
                GenerateRandX();
                vectorZ = Random.Range(vectorZ, vectorZ + 15);
                transform.position = new Vector3(vectorX, vectorY, vectorZ);
                vectorZ -= 6;
            }

        }
        else if (isCollectible == false)
        {
            GenerateRandX();
            vectorZ = Random.Range(vectorZ, vectorZ + 15);
            transform.position = new Vector3(vectorX, vectorY, vectorZ);
            vectorZ -= 6;

        }


    }
    private void GenerateRandX()
    {
        obsPosition = Random.Range(0, 3);
        if (obsPosition == 0)
        {
            vectorX = -14;
        }
        else if (obsPosition == 1)
        {
            vectorX = -0;
        }
        else if (obsPosition == 2)
        {
            vectorX = 14;
        }
    }
    private void GenerateRandZ()
    {
        vectorZinicial = Random.Range(initialZrange, finalZrange);
    }

}
