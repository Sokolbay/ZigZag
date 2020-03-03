using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    [SerializeField] Transform firstPoint, cubesParent, crystalsParent;
    [SerializeField] GameObject cube, crystal;
    Vector3 nextPoint;
    float randomSide, randomCrystal;
    bool spawn = false;
    // Start is called before the first frame update
    void Start()
    {
        nextPoint = Instantiate(cube, firstPoint.position, firstPoint.rotation, cubesParent).transform.position;
        for (int i = 1; i<20; i++)
        {
            SpawnCubesEverySecond();
        }
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && spawn == false)
        {
            InvokeRepeating("SpawnCubesEverySecond", 0, 0.25f);
            spawn = true;
        }

    }
    void SpawnCubesEverySecond()
    {
        randomSide = Mathf.Round(Random.value);
        randomCrystal = Random.value;
        if (randomSide == 0)
        {
            nextPoint = Instantiate(cube, new Vector3(nextPoint.x, nextPoint.y, nextPoint.z + 1), firstPoint.rotation, cubesParent).transform.position;
        }
        else if (randomSide == 1)
        {
            nextPoint = Instantiate(cube, new Vector3(nextPoint.x + 1, nextPoint.y, nextPoint.z), firstPoint.rotation, cubesParent).transform.position;
        }
        if (randomCrystal >=0 && randomCrystal <= 0.2f)
        {
            Instantiate(crystal, new Vector3(nextPoint.x, nextPoint.y + 1, nextPoint.z), firstPoint.rotation, crystalsParent);
        }
    }


}
