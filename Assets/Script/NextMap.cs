using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextMap : MonoBehaviour
{

    public Transform MapHolder;
    Transform coinHolder;

    private void OnTriggerEnter(Collider other)
    {
        
            Debug.Log(this.transform.parent.name);
            Debug.Log(this.transform.name);
        Debug.Log(this.transform.parent.parent.name);
        Debug.Log(this.transform.parent.GetSiblingIndex());

            if (this.transform.parent.GetSiblingIndex() == 1)
            {
                MapHolder.GetChild(0).transform.position = MapHolder.GetChild(2).transform.position
                                                                + new Vector3(0, 0, 150f);
            Debug.Log(MapHolder.GetChild(0).transform.position);
            Debug.Log(MapHolder.GetChild(2).transform.position);

                /*
                coinHolder = MapHolder.GetChild(0).GetChild(0);

                for (int i = 0; i < coinHolder.childCount; i++)
                {
                    coinHolder.GetChild(i).gameObject.SetActive(true);
                }
                */

                MapHolder.GetChild(0).SetSiblingIndex(2);



            }
    }
 
}
