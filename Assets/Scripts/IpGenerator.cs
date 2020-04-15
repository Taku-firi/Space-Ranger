using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IpGenerator : MonoBehaviour
{
    public GameObject[] ipprefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateIp", 0, 2);   
    }


    private void CreateIp()
    {
        int num = Random.Range(0, ipprefabs.Length);
        GameObject ip = Instantiate(ipprefabs[num], new Vector3(0.0f, 6.5f, -1.0f), Quaternion.identity);
    }
}
