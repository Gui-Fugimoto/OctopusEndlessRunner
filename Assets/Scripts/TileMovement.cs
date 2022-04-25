using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //StartCoroutine("IncreaseSpeed");
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        direction.z = -forwardSpeed;
        controller.Move(direction * Time.fixedDeltaTime);
    }

    //IEnumerator IncreaseSpeed()
    //{
    //    while (true)
    //   {
    //        yield return new WaitForSeconds(10);

    //        if(forwardSpeed < 8)
    //        {
    //            forwardSpeed += 0.2f;
    //        }

    //GameObject.Find("RoadSpawner").GetComponent<PlotSpawner>().
    //    }
    // }

    // StopCoroutine("IncreaseSpeed"); no script de morte do player 
}
