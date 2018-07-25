using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512Cubes : MonoBehaviour {

    [SerializeField] private GameObject sampleCubePrefab;
    [SerializeField] private float maxScale = 10;
    private GameObject[] cubes = new GameObject[512];
    // Use this for initialization
	void Start () {
        for (int i = 0; i < 512; i++)
        {
            GameObject instanceSampleCube = Instantiate(sampleCubePrefab);
            instanceSampleCube.transform.position = this.transform.position;
            instanceSampleCube.transform.parent = this.transform;
            instanceSampleCube.name = "SampleCube " + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            instanceSampleCube.transform.position = Vector3.forward * 100f;
            cubes[i] = instanceSampleCube;
        }
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < 512; i++)
        {
            if (cubes != null)
            {
                cubes[i].transform.localScale = new Vector3(10, (AudioPeer.samples[i] * maxScale) + 2, 10);
            }
        }
	}
}
