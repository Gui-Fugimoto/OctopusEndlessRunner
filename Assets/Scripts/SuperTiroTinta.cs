using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperTiroTinta : MonoBehaviour
{
    public float velocity;
    public GameObject Inimigo;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * velocity);
        gameObject.transform.Rotate(0, -90, 0);
        Destroy(gameObject, 6);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            
        }

       // if (other.gameObject.CompareTag("Obstaculo"))
       // //{
        //    Destroy(gameObject);
        //}
    }

}