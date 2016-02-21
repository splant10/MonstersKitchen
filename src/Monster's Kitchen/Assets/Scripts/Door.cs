using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Door : MonoBehaviour, Interactable {
    public Transform objectDestination;
    public Transform cameraDestination;
    public bool lockObjectZ;
    public bool lockCameraZ;

    private List<DoorListener> listeners;

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

        foreach (DoorListener listener in listeners)
        {
            listener.OnDoor(this);
        }
    }

    void Awake()
    {
        listeners = new List<DoorListener>();
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddListener(DoorListener listener)
    {
        listeners.Add(listener);
    }
}
