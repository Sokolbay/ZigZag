using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Colliders : MonoBehaviour
{
    int pointsCount = 0;
    [SerializeField] Text pointsText;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.tag == "EndZone")
        {
            SceneManager.LoadScene(0);
        }
        if (collider.transform.tag == "Crystal")
        {
            Destroy(collider.gameObject);
            pointsCount = pointsCount + 1;
            pointsText.text = pointsCount.ToString();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Cube")
        {
           collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}
