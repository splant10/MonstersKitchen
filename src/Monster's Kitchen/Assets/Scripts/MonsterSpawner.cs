using UnityEngine;
using System.Collections;
using System;

public class MonsterSpawner : MonoBehaviour, DoorListener {
    public Monster toSpawn;
    public Door[] doorsToCauseSpawn;
    private Monster monster;

    void Start()
    {
        foreach (Door door in doorsToCauseSpawn)
        {
            door.AddListener(this);
        }
    }

    public bool Spawn()
    {
        if (monster == null)
        {
            monster = Instantiate(toSpawn);
            monster.transform.position = gameObject.transform.position;
            monster.transform.SetParent(gameObject.transform);
            return true;
        }
        return false;
    }

    public void OnDoor(Door door)
    {
        Spawn();
    }
}
