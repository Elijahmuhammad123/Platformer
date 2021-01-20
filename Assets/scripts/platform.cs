using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public Vector3 targetPos;
    public float speed;
    Vector3 startpos;
    bool totarget = true;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;



    }

    // Update is called once per frame
    void Update()
    {

        if (totarget == true)
        {

            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);

        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startpos, speed);

        }
        if (transform.position == targetPos)
        {
            totarget = false; 
        }
        if (transform.position == startpos)
        {
            totarget = true;
        }

    }
}
