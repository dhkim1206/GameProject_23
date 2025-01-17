using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoint;
	public SpawnData[] spawnData;

    float timer;

	int level;
	private void Awake()
	{
		spawnPoint = GetComponentsInChildren<Transform>();
	}

	void Update()
    {
		if (!GameManager.instance.isLive)
			return;

		timer += Time.deltaTime;

		level = Mathf.Min(Mathf.FloorToInt(GameManager.instance.gameTime / 10f), spawnData.Length - 1);

		if(timer >spawnData[level].spawnTime)
		{
			timer = 0;
			Spawn();
		}

        if(Input.GetButtonDown("Jump"))
		{
            GameManager.instance.poolManager.Get(1);
		}
    }

	void Spawn()
	{
		GameObject enemy = GameManager.instance.poolManager.Get(0);
		enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position;
		enemy.GetComponent<Monster>().Init(spawnData[level]);
	}
}

[System.Serializable]
public class SpawnData
{
	public float spawnTime;
	public int spriteType;
	public int health;
	public float speed;
}