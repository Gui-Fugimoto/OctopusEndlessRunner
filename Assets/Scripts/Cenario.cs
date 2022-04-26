using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    public float speed;
    public float vectorZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = FindObjectOfType<TileMovement>().forwardSpeed;
        transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.Translate(new Vector3(0, 0, vectorZ));
        }
    }
}
