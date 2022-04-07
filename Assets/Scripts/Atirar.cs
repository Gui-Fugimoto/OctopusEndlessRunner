using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atirar : MonoBehaviour
{
    public GameObject Polvo;

    public GameObject InkShot;

    public Button BotaoAtirar;

    public GameObject CanvasAtirar;
    //public float delay = 1f;


    // Start is called before the first frame update
    void Start()
    {
        BotaoAtirar.onClick = new Button.ButtonClickedEvent();
        BotaoAtirar.onClick.AddListener(() => atirar());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator ParadeAtirar()
    {
        yield return new WaitForSeconds(1);
        CanvasAtirar.SetActive(true);
    }

    public void atirar()
    {
        Debug.Log("atirou");
        Instantiate(InkShot, Polvo.transform.localPosition, Quaternion.Euler(transform.forward));
        CanvasAtirar.SetActive(false);
        StartCoroutine(ParadeAtirar());


    }

}
