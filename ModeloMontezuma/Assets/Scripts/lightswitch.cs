using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch : MonoBehaviour
{
    //objeto que se va a prender
    public GameObject luzObj;

    public bool luz;

    //bool de prender y apagar
    private bool luzOnOff;

    public void OnOffLuz()
    {
        luzOnOff = !luzOnOff;

        if(luzOnOff == true)
        {
            luzObj.SetActive(true);
        }

        if(luzOnOff == false)
        {
            luzObj.SetActive(false);
        }
    }
}
