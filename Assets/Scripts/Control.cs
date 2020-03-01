using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    bool move = false;
    bool forward = false;
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && move == true)
        {
            if (forward == true) forward = false;
            else if (forward == false) forward = true;
        }
        if (Input.GetMouseButtonDown(0) && move == false)
        {
            start.SetActive(false);
            move = true;
            forward = true;
        }
        if (move == true)
        {
            if (forward == true)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 4 * Time.deltaTime);
            }
            if (forward == false)
            {
                transform.position = new Vector3(transform.position.x + 4 * Time.deltaTime, transform.position.y, transform.position.z);
            }
            Camera.main.transform.position = new Vector3(transform.position.x - 3, Camera.main.transform.position.y, transform.position.z - 2);
        }
    }
}
