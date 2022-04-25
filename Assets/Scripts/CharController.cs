using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    // public float movementSpeed = 10f;
    public SpawnManager spawnManager;
    //public RoadSpawner roadSpawner;
    public TileMovement tile;
    public AudioSource theme;
    public int passou = 0;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("OnTriggerEnter", 30f, )
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpawnTrigger"))
        {
            //roadSpawner.MoveRoad();
            spawnManager.SpawnTriggerEntered();
            Debug.Log("loop");
            passou++;

            if (passou == 10 | passou == 20 | passou == 30)
            {
                tile.forwardSpeed+=5;
                theme.pitch += 0.05f;// aumenta velocidade da musica tema 
            }
        }
    }


}
