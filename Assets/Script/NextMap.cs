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
        if (other.gameObject.CompareTag("Map"))
        {
            Debug.Log(other.transform.parent.name);
            Debug.Log(other.transform.name);

            if (other.transform.parent.GetSiblingIndex() == 1)
            {
                MapHolder.GetChild(0).transform.position = MapHolder.GetChild(2).transform.position
                                                                + new Vector3(0, 0, 150f);

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

}
