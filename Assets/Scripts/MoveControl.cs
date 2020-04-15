using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    protected float speed;
    protected GameObject obj;
    protected bool canup;
    protected bool candown;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3.0f;
        obj = GameObject.Find("spacefighter");
        canup = true;
        candown = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow) && canup)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (obj.transform.position.y > 1.25f)
            {
                var v = obj.transform.position;
                v.y = 1.25f;
                obj.transform.position = v;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow) && candown)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (obj.transform.position.y < -0.25f)
            {
                var v = obj.transform.position;
                v.y = -0.25f;
                obj.transform.position = v;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (obj.transform.position.x < -1.75f)
            {
                var v = obj.transform.position;
                v.x = -1.75f;
                obj.transform.position = v;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (obj.transform.position.x > 1.75f)
            {
                var v = obj.transform.position;
                v.x = 1.75f;
                obj.transform.position = v;
            }
        }

    }

    public void Lockup()
    {
        if (canup)
        {
            canup = false;
        }
        else
        {
            canup = true;
        }
    }

    public void Lockdown()
    {
        if (candown)
        {
            candown = false;
        }else
        {
            candown = true;
        }
    }
}
