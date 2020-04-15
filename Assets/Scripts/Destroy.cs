using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    GameObject obj;
    GameObject sf;
    GameObject overlay;
    ParticleSystem p;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("destroy_particle");
        sf = GameObject.Find("spacefighter");
        overlay = GameObject.Find("Overlay");
        p = obj.GetComponent<ParticleSystem>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Debris"))
        {
            p.Play();
            Destroy(other.gameObject);
            Counter.Instance.AddDH();
            Counter.Instance.AddScore(5);
            overlay.GetComponent<OverlayCount>().DebrisHit();
        }
        else
        {
            sf.GetComponent<MoveControl>().Lockup();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Debris"))
        {
            sf.GetComponent<MoveControl>().Lockup();
        }
    }
}
