using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayCount : MonoBehaviour
{
    public int count;
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 2)
        {
            manager.GetComponent<GameController>().Gameover3();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        count++;
    }

    private void OnTriggerExit(Collider other)
    {
        count--;
    }

    public void DebrisHit()
    {
        count--;
    }
}
