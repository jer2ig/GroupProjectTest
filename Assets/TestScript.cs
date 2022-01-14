using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Sphere;
    public int numSpheres = 10;
    private GameObject[] sphereArray;
    void Start()
    {
        sphereArray = new GameObject[numSpheres];
        for (int i = 0; i < numSpheres; i++)
        {
            sphereArray[i] = Instantiate(Sphere, new Vector3(i * 2.0F+10, 8, -9), Quaternion.identity) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        print("Hello World!");        
    }
}
