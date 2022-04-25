using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    public GameObject[] tilePref;
    public float zSpawn = 0;
    public float tileLength = 60;
    public int numberOfTiles = 5;
    public Transform player;

    private List<GameObject> activeTiles = new List<GameObject>();

   
    void Start()
    {
        for(int i =0; i < numberOfTiles; i++)
        {
            if (i == 0)
                SpawnTile(0);
            else
                SpawnTile(Random.Range(0, tilePref.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.z - 35 > zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePref.Length));
            DeleteTile();
        }
    }

    public void SpawnTile(int tileIndex)
    {
        GameObject go = Instantiate(tilePref[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
