using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{

    public GameObject redDoor;
    
    // Start is called before the first frame update
    void Start()
    {
        redDoor.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider triggered");
        redDoor.SetActive(false);
    }
}
