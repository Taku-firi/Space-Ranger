using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomDisable : MonoBehaviour
{
    GameObject sf;

    // Start is called before the first frame update
    void Start()
    {
        sf = GameObject.Find("spacefighter");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Debris"))
        {
            sf.GetComponent<MoveControl>().Lockdown();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Debris"))
        {
            sf.GetComponent<MoveControl>().Lockdown();
        }
    }
}
