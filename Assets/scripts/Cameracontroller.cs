using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    public float camHeight;
    GameObject Player1;
    // Start is called before the first frame update
    void Start()
    {
        Player1 = GameObject.Find("Player1");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player1.transform.position.x, camHeight, -10);
    }
}
