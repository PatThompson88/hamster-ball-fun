using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    
    private Vector3 offset = new Vector3(0.0f, 11.0f, -6.0f);
    // Start is called before the first frame update
    void Start()
    {
        // offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        if(!player){return;}
        transform.position = player.transform.position + offset;
    }
}
