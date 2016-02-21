using UnityEngine;
using System.Collections;
using System;

public class Door : MonoBehaviour, Interactable {
    public Transform objectDestination;
    public Transform cameraDestination;
    public bool lockObjectZ;
    public bool lockCameraZ;

    public void Interact(GameObject interactor)
    {
        float objectX = objectDestination.position.x;
        float objectY = objectDestination.position.y;
        float objectZ = objectDestination.position.z;

        float cameraX = cameraDestination.position.x;
        float cameraY = cameraDestination.position.y;
        float cameraZ = cameraDestination.position.z;

        if (lockObjectZ)
        {
            objectZ = interactor.transform.position.z;
        }
        interactor.transform.position = new Vector3(objectX, objectY, objectZ);

        if (lockCameraZ)
        {
            cameraZ = GameObject.Find("Main Camera").transform.position.z;
        }
        GameObject.Find("Main Camera").transform.position = new Vector3(cameraX, cameraY, cameraZ);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
