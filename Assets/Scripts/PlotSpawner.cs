using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    private int initAmount = 2;

    private float plotSize = 57f;
    private float xPosLeft = -21.88f;
    private float xPosRight = 29.41f;
    private float lastZPos = 0f;

    public List<GameObject> plots;

    private List<GameObject> activePlots = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            SpawnPlot();
        }
    }

    // Update is called once per frame
    void Update()
    {
       // DeletePlot();
    }

    public void SpawnPlot()
    {
        int rand = Random.Range(0, plots.Count);// gera prefabs aleatorios no cenario

        GameObject plotLeft = plots[rand];
        GameObject plotRight = plots[rand];

        float zPos = lastZPos + plotSize;

        Instantiate(plotLeft, new Vector3(xPosLeft, 10f, zPos), plotLeft.transform.rotation);
        Instantiate(plotRight, new Vector3(xPosRight, 10f, zPos), new Quaternion(0, 180, 0, 0));

        lastZPos += plotSize;

        // limitar o spawn para surgir conforme as roads vão surgindo
    }

    //public void DeletePlot()
    // {
    //    Destroy(activePlots[0]);
        //activePlots.RemoveAt(0);
    //    Debug.Log("removed");
    //}
}
