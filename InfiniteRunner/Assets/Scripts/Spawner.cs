using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] tiles;
    public float SpawnAt = 0f;
    public float tilelength = -86f;
    public int numberoftiles = 4;
    public Transform player;

    private List<GameObject> activetiles = new List<GameObject>();
    void Start()
    {
        for (int i = 0; i < numberoftiles; i++)
        {
            Spawn(Random.Range(0, tiles.Length));
        }
    }

    private void Update()
    {
        if (player.position.z - 100 > SpawnAt - (numberoftiles * tilelength))
        {
            Spawn(Random.Range(0, tiles.Length));
            Deletetile();
        }

    }
    public void Spawn(int tileIndex)
    {
        GameObject tilescount = Instantiate(tiles[tileIndex], transform.forward * SpawnAt, transform.rotation);
        activetiles.Add(tilescount);
        SpawnAt += tilelength;
    }

    public void Deletetile()
    {
        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);
    }
}