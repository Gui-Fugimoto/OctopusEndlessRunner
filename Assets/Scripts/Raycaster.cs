using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           RaycastHit hit;
                   Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                    if (Physics.Raycast(ray, out hit, 100.0f))
                    {
                        if (hit.transform != null)
                        {
                            hit.transform.gameObject.SendMessageUpwards("MovePlayer");
                        }

                    }
        }
        
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }
}
