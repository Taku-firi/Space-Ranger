using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageAreaManager : MonoBehaviour
{
    private static StorageAreaManager _instance;

    public static StorageAreaManager Instance
    {
        get
        {
            if (_instance != null)
                return _instance;
            else
            {
                return null;
            }
        }
    }

    public GameObject[,] objectsArr;



    private void Awake()
    {
        _instance = this;
        objectsArr = new GameObject[5, 5];

    }

    private void FixedUpdate()
    {
        for (int i = 0; i < 4; i++)
        {

            if (objectsArr[i, 1])
            {
                CheckObj(objectsArr[i, 1], i + 1, 2);
            }
            if (objectsArr[i, 3])
            {
                CheckObj(objectsArr[i, 3], i + 1, 4);
            }
        }

    }
    public void AddObj(GameObject obj, int row, int column)
    {
        objectsArr[row - 1, column - 1] = obj;
        if (!obj.CompareTag("Debris"))
        {
            CheckObj(obj, row, column);
        }
        //Debug.Log(objects[row - 1, column - 1]);
        //Debug.Log(objects[row - 1, column - 1].GetComponent<ObjectSetting>().row);
        //Debug.Log(objects[row - 1, column - 1].GetComponent<ObjectSetting>().column);
    }

    internal void CheckObj(GameObject obj, int row, int column)
    {
        switch (column)
        {
            case 1:
                switch (row)
                {
                    case 1:
                        if (obj.CompareTag("Red")||obj.CompareTag("Blue"))
                        {
                            if (objectsArr[0, 1] && objectsArr[0, 2] && objectsArr[0, 1].CompareTag("Green") && ((objectsArr[0, 2].CompareTag("Blue")&&obj.CompareTag("Red"))||(objectsArr[0,2].CompareTag("Red")&&obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[0, 0]);
                                Destroy(objectsArr[0, 1]);
                                Destroy(objectsArr[0, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                                for (int i = 0; i < 5; i++)
                                {
                                    if (objectsArr[i, 1])
                                    {
                                        objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                        objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                    }
                                    if (objectsArr[i, 2])
                                    {
                                        objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                        objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                    }
                                }
                            }
                        }

                        break;
                    case 2:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[1, 1] && objectsArr[1, 2] && objectsArr[1, 1].CompareTag("Green") && ((objectsArr[1, 2].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[1, 2].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[1, 0]);
                                Destroy(objectsArr[1, 1]);
                                Destroy(objectsArr[1, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                                for (int i = 0; i < 5; i++)
                                {

                                    if (objectsArr[i, 1])
                                    {
                                        objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                        objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                    }
                                    if (objectsArr[i, 2])
                                    {
                                        objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                        objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                    }
                                }

                            }
                        }
                        break;
                    case 3:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[2, 1] && objectsArr[2, 2] && objectsArr[2, 1].CompareTag("Green") && ((objectsArr[2, 2].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[2, 2].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[2, 0]);
                                Destroy(objectsArr[2, 1]);
                                Destroy(objectsArr[2, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                                
                                for (int i = 0; i < 5; i++)
                                {

                                    if (objectsArr[i, 1])
                                    {
                                        objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                        objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                    }
                                    if (objectsArr[i, 2])
                                    {
                                        objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                        objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                    }
                                }

                            }
                        }

                        if (obj.CompareTag(objectsArr[1, 0].tag) && obj.CompareTag(objectsArr[0,0].tag))
                        {
                            if (!objectsArr[3, 0])
                            {
                                Counter.Instance.AddColorGroup(obj.tag);
                                Destroy(objectsArr[2, 0]);
                                Destroy(objectsArr[1, 0]);
                                Destroy(objectsArr[0, 0]);
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(10);
                            }
                            else
                            {
                                if (obj.CompareTag(objectsArr[3, 0].tag))
                                {
                                    Counter.Instance.AddColorGroup(obj.tag);
                                    DestroyImmediate(objectsArr[3, 0]);
                                    Destroy(objectsArr[2, 0]);
                                    Destroy(objectsArr[1, 0]);
                                    Destroy(objectsArr[0, 0]);
                                    Counter.Instance.AddIpGroup();
                                    Counter.Instance.AddScore(10);
                                    //Debug.Log(3);
                                }
                                else
                                {
                                
                                    objectsArr[3, 0].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                    objectsArr[3, 0].GetComponent<Rigidbody>().isKinematic = false;

                                }
                            }

                        }
                        break;
                    case 4:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[3, 1] && objectsArr[3, 2] && objectsArr[3, 1].CompareTag("Green") && ((objectsArr[3, 2].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[3, 2].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[3, 0]);
                                Destroy(objectsArr[3, 1]);
                                Destroy(objectsArr[3, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                 
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }

                            }
                        }
                        try
                        {
                            if (obj.CompareTag(objectsArr[2, 0].tag) && obj.CompareTag(objectsArr[1, 0].tag))
                            {
                                Counter.Instance.AddColorGroup(obj.tag);
                                Destroy(objectsArr[3, 0]);
                                Destroy(objectsArr[2, 0]);
                                Destroy(objectsArr[1, 0]);
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(10);                                
                            }
                        }catch (MissingReferenceException e)
                        {
                            Destroy(objectsArr[3, 0]);
                            // Debug.Log("here 4 1");
                        }
                        break;
                    case 5:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[4, 1] && objectsArr[4, 2] && objectsArr[4, 1].CompareTag("Green") && ((objectsArr[4, 2].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[4, 2].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[4, 0]);
                                Destroy(objectsArr[4, 1]);
                                Destroy(objectsArr[4, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
           
                            }
                        }

                        if (obj.CompareTag(objectsArr[3, 0].tag) && obj.CompareTag(objectsArr[2, 0].tag))
                        {
                            Counter.Instance.AddColorGroup(obj.tag);
                            Destroy(objectsArr[4, 0]);
                            Destroy(objectsArr[3, 0]);
                            Destroy(objectsArr[2, 0]);
                            Counter.Instance.AddIpGroup();
                            Counter.Instance.AddScore(10);

                        }
                        break;
                }
                break;
            case 2:
                switch (row)
                {
                    case 1:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[0, 2] && objectsArr[0, 3] && objectsArr[0, 2].CompareTag("Green") && ((objectsArr[0, 3].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[0, 3].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {


                                Destroy(objectsArr[0, 1]);
                                Destroy(objectsArr[0, 2]);
                                Destroy(objectsArr[0, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                        
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                           
         
                            }
                        }

                        if(obj.CompareTag("Green"))
                        {
                            if(objectsArr[0, 0] && objectsArr[0, 2] && ((objectsArr[0, 0].CompareTag("Red") && objectsArr[0, 2].CompareTag("Blue")) || (objectsArr[0, 0].CompareTag("Blue") && objectsArr[0, 2].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[0, 0]);
                                Destroy(objectsArr[0, 1]);
                                Destroy(objectsArr[0, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 0])
                                        {
                                            objectsArr[i, 0].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 0].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                             
                   
                            }
                        }
                        break;
                    case 2:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[1, 2] && objectsArr[1, 3] && objectsArr[1, 2].CompareTag("Green") && ((objectsArr[1, 3].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[1, 3].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[1, 1]);
                                Destroy(objectsArr[1, 2]);
                                Destroy(objectsArr[1, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                   
                            }
                        }

                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[1, 0] && objectsArr[1, 2] && ((objectsArr[1, 0].CompareTag("Red") && objectsArr[1, 2].CompareTag("Blue")) || (objectsArr[1, 0].CompareTag("Blue") && objectsArr[1, 2].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[1, 0]);
                                Destroy(objectsArr[1, 1]);
                                Destroy(objectsArr[1, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 0])
                                        {
                                            objectsArr[i, 0].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 0].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                  
                            }
                        }
                        break;
                    case 3:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[2, 2] && objectsArr[2, 3] && objectsArr[2, 2].CompareTag("Green") && ((objectsArr[2, 3].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[2, 3].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[2, 1]);
                                Destroy(objectsArr[2, 2]);
                                Destroy(objectsArr[2, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                                
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                
                            }
                        }

                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[2, 0] && objectsArr[2, 2] && ((objectsArr[2, 0].CompareTag("Red") && objectsArr[2, 2].CompareTag("Blue")) || (objectsArr[2, 0].CompareTag("Blue") && objectsArr[2, 2].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[2, 0]);
                                Destroy(objectsArr[2, 1]);
                                Destroy(objectsArr[2, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 0])
                                        {
                                            objectsArr[i, 0].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 0].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                     
                            }
                        }

                        try
                        {
                            if (obj.CompareTag(objectsArr[1, 1].tag) && obj.CompareTag(objectsArr[0, 1].tag))
                            {
                                if (!objectsArr[3, 1])
                                {
                                    Counter.Instance.AddColorGroup(obj.tag);
                                    Destroy(objectsArr[2, 1]);
                                    Destroy(objectsArr[1, 1]);
                                    Destroy(objectsArr[0, 1]);
                                    Counter.Instance.AddIpGroup();
                                    Counter.Instance.AddScore(10);
                                }
                                else
                                {
                                    if (obj.CompareTag(objectsArr[3, 1].tag))
                                    {
                                        Counter.Instance.AddColorGroup(obj.tag);
                                        DestroyImmediate(objectsArr[3, 1]);
                                        Destroy(objectsArr[2, 1]);
                                        Destroy(objectsArr[1, 1]);
                                        Destroy(objectsArr[0, 1]);
                                        Counter.Instance.AddIpGroup();
                                        Counter.Instance.AddScore(10);
                                    }
                                    else
                                    {
                                      
                                            objectsArr[3, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[3, 1].GetComponent<Rigidbody>().isKinematic = false;
                                   
                                    }
                                }

                            }
                        }catch (MissingReferenceException e)
                        {
                        }
                        break;
                    case 4:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[3, 2] && objectsArr[3, 3] && objectsArr[3, 2].CompareTag("Green") && ((objectsArr[3, 3].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[3, 3].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[3, 1]);
                                Destroy(objectsArr[3, 2]);
                                Destroy(objectsArr[3, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                        }

                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[3, 0] && objectsArr[3, 2] && ((objectsArr[3, 0].CompareTag("Red") && objectsArr[3, 2].CompareTag("Blue")) || (objectsArr[3, 0].CompareTag("Blue") && objectsArr[3, 2].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[3, 0]);
                                Destroy(objectsArr[3, 1]);
                                Destroy(objectsArr[3, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                                
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 0])
                                        {
                                            objectsArr[i, 0].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 0].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                       
                                    }
                               
                            }
                        }
                        try
                        {
                            if (obj.CompareTag(objectsArr[2, 1].tag) && obj.CompareTag(objectsArr[1, 1].tag))
                            {
                                Counter.Instance.AddColorGroup(obj.tag);
                                Destroy(objectsArr[3, 1]);
                                Destroy(objectsArr[2, 1]);
                                Destroy(objectsArr[1, 1]);
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(10);
                            }
                        }
                        catch (MissingReferenceException e)
                        {
                            if(objectsArr[3, 1])
                            {
                              
                                objectsArr[3, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                objectsArr[3, 1].GetComponent<Rigidbody>().isKinematic = false;
                               
                            }
                        }
                        break;
                    case 5:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[4, 2] && objectsArr[4, 3] && objectsArr[4, 2].CompareTag("Green") && ((objectsArr[4, 3].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[4, 3].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[4, 1]);
                                Destroy(objectsArr[4, 2]);
                                Destroy(objectsArr[4, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                                
                            }
                        }

                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[4, 0] && objectsArr[4, 2] && ((objectsArr[4, 0].CompareTag("Red") && objectsArr[4, 2].CompareTag("Blue")) || (objectsArr[4, 0].CompareTag("Blue") && objectsArr[4, 2].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[4, 0]);
                                Destroy(objectsArr[4, 1]);
                                Destroy(objectsArr[4, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                            }
                        }

                        if (obj.CompareTag(objectsArr[3, 1].tag) && obj.CompareTag(objectsArr[2, 1].tag))
                        {
                            Counter.Instance.AddColorGroup(obj.tag);
                            Destroy(objectsArr[4, 1]);
                            Destroy(objectsArr[3, 1]);
                            Destroy(objectsArr[2, 1]);
                            Counter.Instance.AddIpGroup();
                            Counter.Instance.AddScore(10);
                            
                        }
                        break;
                }
                break;
            case 3:
                switch (row)
                {
                    case 1:
                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[0, 1] && objectsArr[0, 3] && ((objectsArr[0, 1].CompareTag("Red") && objectsArr[0, 3].CompareTag("Blue")) || (objectsArr[0, 1].CompareTag("Blue") && objectsArr[0, 3].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[0, 1]);
                                Destroy(objectsArr[0, 2]);
                                Destroy(objectsArr[0, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);

                                for (int i = 0; i < 5; i++)
                                {

                                    if (objectsArr[i, 1])
                                    {
                                        objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                        objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                    }
                                    if (objectsArr[i, 3])
                                    {
                                        objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                        objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                    }
                                }
                               
                            }
                        }

                        if(obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[0, 0] && objectsArr[0, 1] && objectsArr[0, 1].CompareTag("Green") && ((objectsArr[0,0].CompareTag("Blue") && obj.CompareTag("Red")) ||(objectsArr[0, 0].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[0, 0]);
                                Destroy(objectsArr[0, 1]);
                                Destroy(objectsArr[0, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 0])
                                        {
                                            objectsArr[i, 0].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 0].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                            if (objectsArr[0, 3] && objectsArr[0, 4] && objectsArr[0, 3].CompareTag("Green") && ((objectsArr[0, 4].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[0, 4].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[0, 4]);
                                Destroy(objectsArr[0, 3]);
                                Destroy(objectsArr[0, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 4])
                                        {
                                            objectsArr[i, 4].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 4].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                                
                            }
                        }
                        break;
                    case 2:
                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[1, 1] && objectsArr[1, 3] && ((objectsArr[1, 1].CompareTag("Red") && objectsArr[1, 3].CompareTag("Blue")) || (objectsArr[1, 1].CompareTag("Blue") && objectsArr[1, 3].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[1, 1]);
                                Destroy(objectsArr[1, 2]);
                                Destroy(objectsArr[1, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                                
                                
                            }
                        }

                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[1, 0] && objectsArr[1, 1] && objectsArr[1, 1].CompareTag("Green") && ((objectsArr[1, 0].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[1, 0].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[1, 0]);
                                Destroy(objectsArr[1, 1]);
                                Destroy(objectsArr[1, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 0])
                                        {
                                            objectsArr[i, 0].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 0].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                                
                            }
                            if (objectsArr[1, 3] && objectsArr[1, 4] && objectsArr[1, 3].CompareTag("Green") && ((objectsArr[1, 4].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[1, 4].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[1, 4]);
                                Destroy(objectsArr[1, 3]);
                                Destroy(objectsArr[1, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 4])
                                        {
                                            objectsArr[i, 4].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 4].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                        }
                        break;
                    case 3:
                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[2, 1] && objectsArr[2, 3] && ((objectsArr[2, 1].CompareTag("Red") && objectsArr[2, 3].CompareTag("Blue")) || (objectsArr[2, 1].CompareTag("Blue") && objectsArr[2, 3].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[2, 1]);
                                Destroy(objectsArr[2, 2]);
                                Destroy(objectsArr[2, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                        }

                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[2, 0] && objectsArr[2, 1] && objectsArr[2, 1].CompareTag("Green") && ((objectsArr[2, 0].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[2, 0].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[2, 0]);
                                Destroy(objectsArr[2, 1]);
                                Destroy(objectsArr[2, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 0])
                                        {
                                            objectsArr[i, 0].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 0].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                              
                            }
                            if (objectsArr[2, 3] && objectsArr[2, 4] && objectsArr[2, 3].CompareTag("Green") && ((objectsArr[2, 4].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[2, 4].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[2, 4]);
                                Destroy(objectsArr[2, 3]);
                                Destroy(objectsArr[2, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                             
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 4])
                                        {
                                            objectsArr[i, 4].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 4].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                                
                            }
                        }

                        if (obj.CompareTag(objectsArr[1, 2].tag) && obj.CompareTag(objectsArr[0, 2].tag))
                        {
                            if (!objectsArr[3, 2])
                            {
                                Counter.Instance.AddColorGroup(obj.tag);
                                Destroy(objectsArr[2, 2]);
                                Destroy(objectsArr[1, 2]);
                                Destroy(objectsArr[0, 2]);
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(10);
                            }
                            else
                            {
                                if (obj.CompareTag(objectsArr[3, 2].tag))
                                {
                                    Counter.Instance.AddColorGroup(obj.tag);
                                    DestroyImmediate(objectsArr[3, 2]);
                                    Destroy(objectsArr[2, 2]);
                                    Destroy(objectsArr[1, 2]);
                                    Destroy(objectsArr[0, 2]);
                                    Counter.Instance.AddIpGroup();
                                    Counter.Instance.AddScore(10);
                                    // Debug.Log("match4");
                                }
                                else
                                {
                                    
                                        objectsArr[3, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                        objectsArr[3, 2].GetComponent<Rigidbody>().isKinematic = false;
                              
                                }
                            }

                        }
                        break;
                    case 4:
                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[3, 1] && objectsArr[3, 3] && ((objectsArr[3, 1].CompareTag("Red") && objectsArr[3, 3].CompareTag("Blue")) || (objectsArr[3, 1].CompareTag("Blue") && objectsArr[3, 3].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[3, 1]);
                                Destroy(objectsArr[3, 2]);
                                Destroy(objectsArr[3, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                        }

                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[3, 0] && objectsArr[3, 1] && objectsArr[3, 1].CompareTag("Green") && ((objectsArr[3, 0].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[3, 0].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[3, 0]);
                                Destroy(objectsArr[3, 1]);
                                Destroy(objectsArr[3, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 0])
                                        {
                                            objectsArr[i, 0].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 0].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }

                                    }
                               
                            }
                            if (objectsArr[3, 3] && objectsArr[3, 4] && objectsArr[3, 3].CompareTag("Green") && ((objectsArr[3, 4].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[3, 4].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[3, 4]);
                                Destroy(objectsArr[3, 3]);
                                Destroy(objectsArr[3, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 4])
                                        {
                                            objectsArr[i, 4].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 4].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                              
                            }
                        }
                        try
                        {
                            if (obj.CompareTag(objectsArr[2, 2].tag) && obj.CompareTag(objectsArr[1, 2].tag))
                            {
                                Counter.Instance.AddColorGroup(obj.tag);
                                Destroy(objectsArr[3, 2]);
                                Destroy(objectsArr[2, 2]);
                                Destroy(objectsArr[1, 2]);
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(10);
                            }
                        }
                        catch (MissingReferenceException e)
                        {
                            Destroy(objectsArr[3, 2]);
                            //Debug.Log("here 4 3");
                        }
                        break;
                    case 5:
                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[4, 1] && objectsArr[4, 3] && ((objectsArr[4, 1].CompareTag("Red") && objectsArr[4, 3].CompareTag("Blue")) || (objectsArr[4, 1].CompareTag("Blue") && objectsArr[4, 3].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[4, 1]);
                                Destroy(objectsArr[4, 2]);
                                Destroy(objectsArr[4, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);          
                            }
                           
                        }

                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[4, 0] && objectsArr[4, 1] && objectsArr[4, 1].CompareTag("Green") && ((objectsArr[4, 0].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[4, 0].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[4, 0]);
                                Destroy(objectsArr[4, 1]);
                                Destroy(objectsArr[4, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                            }
                            if (objectsArr[4, 3] && objectsArr[4, 4] && objectsArr[4, 3].CompareTag("Green") && ((objectsArr[4, 4].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[4, 4].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[4, 4]);
                                Destroy(objectsArr[4, 3]);
                                Destroy(objectsArr[4, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                             
                            }
                        }

                        if (obj.CompareTag(objectsArr[3, 2].tag) && obj.CompareTag(objectsArr[2, 2].tag))
                        {
                            Counter.Instance.AddColorGroup(obj.tag);
                            Destroy(objectsArr[4, 2]);
                            Destroy(objectsArr[3, 2]);
                            Destroy(objectsArr[2, 2]);
                            Counter.Instance.AddIpGroup();
                            Counter.Instance.AddScore(10);
                            
                        }
                        break;
                }
                break;
            case 4:
                switch (row)
                {
                    case 1:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[0, 2] && objectsArr[0, 1] && objectsArr[0, 2].CompareTag("Green") && ((objectsArr[0, 1].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[0, 1].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[0, 1]);
                                Destroy(objectsArr[0, 2]);
                                Destroy(objectsArr[0, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                        }

                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[0, 4] && objectsArr[0, 2] && ((objectsArr[0, 4].CompareTag("Red") && objectsArr[0, 2].CompareTag("Blue")) || (objectsArr[0, 4].CompareTag("Blue") && objectsArr[0, 2].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[0, 4]);
                                Destroy(objectsArr[0, 3]);
                                Destroy(objectsArr[0, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 4])
                                        {
                                            objectsArr[i, 4].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 4].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                              
                            }
                        }
                        break;
                    case 2:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[1, 2] && objectsArr[1, 1] && objectsArr[1, 2].CompareTag("Green") && ((objectsArr[1, 1].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[1, 1].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[1, 1]);
                                Destroy(objectsArr[1, 2]);
                                Destroy(objectsArr[1, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                             
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                        }

                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[1, 4] && objectsArr[1, 2] && ((objectsArr[1, 4].CompareTag("Red") && objectsArr[1, 2].CompareTag("Blue")) || (objectsArr[1, 4].CompareTag("Blue") && objectsArr[1, 2].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[1, 4]);
                                Destroy(objectsArr[1, 3]);
                                Destroy(objectsArr[1, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 4])
                                        {
                                            objectsArr[i, 4].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 4].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                        }
                        break;
                    case 3:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[2, 2] && objectsArr[2, 1] && objectsArr[2, 2].CompareTag("Green") && ((objectsArr[2, 1].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[2, 1].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[2, 1]);
                                Destroy(objectsArr[2, 2]);
                                Destroy(objectsArr[2, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                        }

                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[2, 4] && objectsArr[2, 2] && ((objectsArr[2, 4].CompareTag("Red") && objectsArr[2, 2].CompareTag("Blue")) || (objectsArr[2, 4].CompareTag("Blue") && objectsArr[2, 2].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[2, 4]);
                                Destroy(objectsArr[2, 3]);
                                Destroy(objectsArr[2, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 4])
                                        {
                                            objectsArr[i, 4].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 4].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                              
                            }
                        }
                        try
                        {
                            if (obj.CompareTag(objectsArr[1, 3].tag) && obj.CompareTag(objectsArr[0, 3].tag))
                            {
                                if (!objectsArr[3, 3])
                                {
                                    Counter.Instance.AddColorGroup(obj.tag);
                                    Destroy(objectsArr[2, 3]);
                                    Destroy(objectsArr[1, 3]);
                                    Destroy(objectsArr[0, 3]);
                                    Counter.Instance.AddIpGroup();
                                    Counter.Instance.AddScore(10);
                                }
                                else
                                {
                                    if (obj.CompareTag(objectsArr[3, 3].tag))
                                    {
                                        Counter.Instance.AddColorGroup(obj.tag);
                                        DestroyImmediate(objectsArr[3, 3]);
                                        Destroy(objectsArr[2, 3]);
                                        Destroy(objectsArr[1, 3]);
                                        Destroy(objectsArr[0, 3]);
                                        Counter.Instance.AddIpGroup();
                                        Counter.Instance.AddScore(10);
                                    }
                                    else
                                    {
                                        
                                            objectsArr[3, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[3, 3].GetComponent<Rigidbody>().isKinematic = false;
                                      

                                    }
                                }

                            }
                        } catch (MissingReferenceException e)
                        {

                        }
                        break;
                    case 4:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[3, 2] && objectsArr[3, 1] && objectsArr[3, 2].CompareTag("Green") && ((objectsArr[3, 1].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[3, 1].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[3, 1]);
                                Destroy(objectsArr[3, 2]);
                                Destroy(objectsArr[3, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                             
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 1])
                                        {
                                            objectsArr[i, 1].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 1].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                              
                            }
                        }

                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[3, 4] && objectsArr[3, 2] && ((objectsArr[3, 4].CompareTag("Red") && objectsArr[3, 2].CompareTag("Blue")) || (objectsArr[3, 4].CompareTag("Blue") && objectsArr[3, 2].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[3, 4]);
                                Destroy(objectsArr[3, 3]);
                                Destroy(objectsArr[3, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                            
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 4])
                                        {
                                            objectsArr[i, 4].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 4].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                              
                            }
                        }
                        try
                        {
                            if (obj.CompareTag(objectsArr[2, 3].tag) && obj.CompareTag(objectsArr[1, 3].tag))
                            {
                                Counter.Instance.AddColorGroup(obj.tag);
                                Destroy(objectsArr[3, 3]);
                                Destroy(objectsArr[2, 3]);
                                Destroy(objectsArr[1, 3]);
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(10);
                            }
                        }
                        catch (MissingReferenceException e)
                        {
                            if (objectsArr[3, 3])
                            {
                             
                                    objectsArr[3, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                    objectsArr[3, 3].GetComponent<Rigidbody>().isKinematic = false;
                             
                            }
                        }
                        break;
                    case 5:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[4, 2] && objectsArr[4, 1] && objectsArr[4, 2].CompareTag("Green") && ((objectsArr[4, 1].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[4, 1].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[4, 1]);
                                Destroy(objectsArr[4, 2]);
                                Destroy(objectsArr[4, 3]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                            }
                        }

                        if (obj.CompareTag("Green"))
                        {
                            if (objectsArr[4, 4] && objectsArr[4, 2] && ((objectsArr[4, 4].CompareTag("Red") && objectsArr[4, 2].CompareTag("Blue")) || (objectsArr[4, 4].CompareTag("Blue") && objectsArr[4, 2].CompareTag("Red"))))
                            {
                                Destroy(objectsArr[4, 4]);
                                Destroy(objectsArr[4, 3]);
                                Destroy(objectsArr[4, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                            }
                        }

                        if (obj.CompareTag(objectsArr[3, 3].tag) && obj.CompareTag(objectsArr[2, 3].tag))
                        {
                            Counter.Instance.AddColorGroup(obj.tag);
                            Destroy(objectsArr[4, 3]);
                            Destroy(objectsArr[3, 3]);
                            Destroy(objectsArr[2, 3]);
                            Counter.Instance.AddIpGroup();
                            Counter.Instance.AddScore(10);
                            
                        }
                        break;
                }
                break;
            case 5:
                switch (row)
                {
                    case 1:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[0, 3] && objectsArr[0, 2] && objectsArr[0, 3].CompareTag("Green") && ((objectsArr[0, 2].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[0, 2].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[0, 4]);
                                Destroy(objectsArr[0, 3]);
                                Destroy(objectsArr[0, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                        }
                        break;
                    case 2:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[1, 3] && objectsArr[1, 2] && objectsArr[1, 3].CompareTag("Green") && ((objectsArr[1, 2].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[1, 2].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[1, 4]);
                                Destroy(objectsArr[1, 3]);
                                Destroy(objectsArr[1, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                               
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                               
                            }
                        }
                        break;
                    case 3:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[2, 3] && objectsArr[2, 2] && objectsArr[2, 3].CompareTag("Green") && ((objectsArr[2, 2].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[2, 2].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[2, 4]);
                                Destroy(objectsArr[2, 3]);
                                Destroy(objectsArr[2, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }
                             
                            }
                        }

                        if (obj.CompareTag(objectsArr[1, 4].tag) && obj.CompareTag(objectsArr[0, 4].tag))
                        {
                            if (!objectsArr[3, 4])
                            {
                                Counter.Instance.AddColorGroup(obj.tag);
                                Destroy(objectsArr[2, 4]);
                                Destroy(objectsArr[1, 4]);
                                Destroy(objectsArr[0, 4]);
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(10);
                            }
                            else
                            {
                                if (obj.CompareTag(objectsArr[3, 4].tag))
                                {
                                    Counter.Instance.AddColorGroup(obj.tag);
                                    DestroyImmediate(objectsArr[3, 4]);
                                    Destroy(objectsArr[2, 4]);
                                    Destroy(objectsArr[1, 4]);
                                    Destroy(objectsArr[0, 4]);
                                    Counter.Instance.AddIpGroup();
                                    Counter.Instance.AddScore(10);
                                }
                                else
                                {
                                   
                                        objectsArr[3, 4].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                        objectsArr[3, 4].GetComponent<Rigidbody>().isKinematic = false;
                                 
                                }
                            }

                        }
                        break;
                    case 4:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[3, 3] && objectsArr[3, 2] && objectsArr[3, 3].CompareTag("Green") && ((objectsArr[3, 2].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[3, 2].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[3, 4]);
                                Destroy(objectsArr[3, 3]);
                                Destroy(objectsArr[3, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                                    for (int i = 0; i < 5; i++)
                                    {

                                        if (objectsArr[i, 3])
                                        {
                                            objectsArr[i, 3].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 3].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                        if (objectsArr[i, 2])
                                        {
                                            objectsArr[i, 2].GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -2.0f, 0.0f);
                                            objectsArr[i, 2].GetComponent<Rigidbody>().isKinematic = false;
                                        }
                                    }

                            }
                        }
                        try
                        {
                            if (obj.CompareTag(objectsArr[2, 4].tag) && obj.CompareTag(objectsArr[1, 4].tag))
                            {
                                Counter.Instance.AddColorGroup(obj.tag);
                                Destroy(objectsArr[3, 4]);
                                Destroy(objectsArr[2, 4]);
                                Destroy(objectsArr[1, 4]);
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(10);
                            }
                        }
                        catch (MissingReferenceException e)
                        {
                            Destroy(objectsArr[3, 4]);
                            //Debug.Log("here");
                        }
                        break;
                    case 5:
                        if (obj.CompareTag("Red") || obj.CompareTag("Blue"))
                        {
                            if (objectsArr[4, 3] && objectsArr[4, 2] && objectsArr[4, 3].CompareTag("Green") && ((objectsArr[4, 2].CompareTag("Blue") && obj.CompareTag("Red")) || (objectsArr[4, 2].CompareTag("Red") && obj.CompareTag("Blue"))))
                            {
                                Destroy(objectsArr[4, 4]);
                                Destroy(objectsArr[4, 3]);
                                Destroy(objectsArr[4, 2]);
                                Counter.Instance.AddRgbGroup();
                                Counter.Instance.AddIpGroup();
                                Counter.Instance.AddScore(15);
                              
                            }
                        }

                        if (obj.CompareTag(objectsArr[3, 4].tag) && obj.CompareTag(objectsArr[2, 4].tag))
                        {
                            Counter.Instance.AddColorGroup(obj.tag);
                            Destroy(objectsArr[4, 4]);
                            Destroy(objectsArr[3, 4]);
                            Destroy(objectsArr[2, 4]);
                            Counter.Instance.AddIpGroup();
                            Counter.Instance.AddScore(10);
                           
                        }
                        break;
                }
                break;

        }
    }

}  
