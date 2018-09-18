using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour {

    public GameObject[] tilePrefabs;

    private Transform playerTransform;

    private float spawnZ = 30f; //where in Z to spawn object
    private float tileLength = 80.0f; //length of prefabs
    private int tilesOnScreen = 5;
    private float safeZone = 90.0f;
    private int lastPrefabIndex = 0;

    private List<GameObject> activeTiles;

	// Use this for initialization
	private void Start ()
    {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i=0; i<tilesOnScreen; i++)
        {
            if (i < 2)
                spawnTile(0);
            else
                spawnTile();
        }
    }
	// Update is called once per frame
	private void Update ()
    {
		if(playerTransform.position.z - safeZone >(spawnZ - tilesOnScreen * tileLength))
        {
            spawnTile();
            deleteTile();
        }
	}
    private void spawnTile(int prefabIndex = -1)
    {
        GameObject go;
        if (prefabIndex == -1)
            go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        else
            go = Instantiate(tilePrefabs[prefabIndex]);
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add(go);
    }
    private void deleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
    private int RandomPrefabIndex()
    {
        if (tilePrefabs.Length <= 1)
            return 0;

        int randomIndex = lastPrefabIndex;
        while(randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }
        lastPrefabIndex = randomIndex;
            return randomIndex;
    }

}
