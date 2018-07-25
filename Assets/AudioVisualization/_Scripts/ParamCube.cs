using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour {

    public int band;
    public float startScale, scaleMultiplier;
    public bool isUsingBuffer;
    public bool isUsingColorChanger;
    Material material;

    private void Start()
    {
        material = GetComponent<MeshRenderer>().materials[0];
    }

    void Update ()
    {
        if (isUsingBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioPeer.audiobandBuffer[band] * scaleMultiplier) + startScale, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioPeer.audioband[band] * scaleMultiplier) + startScale, transform.localScale.z);
        }

        if (isUsingColorChanger)
        {
            Color color = new Color(AudioPeer.audiobandBuffer[band], AudioPeer.audiobandBuffer[band], AudioPeer.audiobandBuffer[band]);
            material.SetColor("_EmissionColor", color);
        }
    }
}
