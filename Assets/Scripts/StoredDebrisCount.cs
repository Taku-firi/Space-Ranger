using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoredDebrisCount : MonoBehaviour
{
    // Start is called before the first frame update
    public int stored_debris;
    public GameObject manager;
    void Start()
    {
        stored_debris = 0;
    }



    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Debris"))
        {
            ++stored_debris;
            if (stored_debris == 6)
            {
                manager.GetComponent<GameController>().Gameover2();
            }
        }
    }
}
