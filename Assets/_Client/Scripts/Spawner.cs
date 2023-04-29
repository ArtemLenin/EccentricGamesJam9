using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Collider2D[] spawnZones;
    [SerializeField] private Enemy _enemy;

    private void Awake()
    {
        spawnZones = GetComponents<Collider2D>();
    }

    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        int index = Random.Range(0, spawnZones.Length);

        float xMin = spawnZones[index].bounds.min.x;
        float xMax = spawnZones[index].bounds.max.x;
        float yMin = spawnZones[index].bounds.min.y;
        float yMax = spawnZones[index].bounds.max.y;

        float x = Random.Range(xMin, xMax);
        float y = Random.Range(yMin, yMax);

        Vector2 pos = new Vector2(x, y);

        Instantiate(_enemy, pos, Quaternion.identity);
    }
}