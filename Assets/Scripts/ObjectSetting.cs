using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSetting : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody rb;
    public float speed_x,speed_y,speed_z;
    public int column, row;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(speed_x, speed_y, speed_z);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.y > -1.5)
        {
            rb.velocity = new Vector3(speed_x, speed_y, speed_z);
        }
        else
        {
            if (rb.velocity.y == 0)
            {
                if (rb.isKinematic == false)
                {
                    Fixposition();
                    rb.isKinematic = true;
                    StorageAreaManager.Instance.AddObj(obj, row, column);

                }
            }
           
        }
    }



    private void Fixposition()
    {
        float pos_x = rb.position.x;
        if ( pos_x > -2.1 && pos_x < -1.9)
        {
            column = 1;
            Fixy(-2.0f);
        }
        else if (pos_x >-1.1 && pos_x < -0.9)
        {
            column = 2;
            Fixy(-1.0f);
        }
        else if (pos_x > -0.1 && pos_x < 0.1)
        {
            column = 3;
            Fixy(0.0f);
        }
        else if (pos_x > 0.9 && pos_x < 1.1)
        {
            column = 4;
            Fixy(1.0f);
        }
        else if (pos_x > 1.9 && pos_x <2.1)
        {
            column = 5;
            Fixy(2.0f);
        }
    }

    private void Fixy(float ft)
    {
        float pos_y = rb.position.y;
        if (pos_y > -5.6 && pos_y < -5.4)
        {
            obj.transform.position = new Vector3(ft, -5.5f, -1.0f);
            row = 1;
            return;
        }
        if (pos_y > -4.6 && pos_y < -4.4)
        {
            obj.transform.position = new Vector3(ft, -4.5f, -1.0f);
            row = 2;
            return;
        }
        if (pos_y > -3.6 && pos_y < -3.4)
        {
            obj.transform.position = new Vector3(ft, -3.5f, -1.0f);
            row = 3;
            return;
        }
        if (pos_y > -2.6 && pos_y < -2.4)
        {
            obj.transform.position = new Vector3(ft, -2.5f, -1.0f);
            row = 4;
            return;
        }
        if (pos_y > -1.6 && pos_y < -1.4)
        {
            obj.transform.position = new Vector3(ft, -1.5f, -1.0f);
            row = 5;
        }
    }
}
