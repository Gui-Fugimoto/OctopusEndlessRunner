using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroTinta : MonoBehaviour
{
    public float velocity;
    public GameObject Inimigo;
    
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<Rigidbody>().AddForce(transform.forward * velocity);
        gameObject.transform.Rotate(0, -90, 0);
        Destroy(gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            Destroy(gameObject);
        }

        //if (other.gameObject.CompareTag("Obstaculo"))
        //{
        //    Destroy(gameObject);
        //}
    }

}