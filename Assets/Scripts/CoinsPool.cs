using UnityEngine;
using System.Collections;

public class CoinsPool : MonoBehaviour
{
	public GameObject itemPrefab;							
	public int poolSize = 5;                                
	public float spawnRate = 3f;                            
	public float YMin = -1f;                                
	public float YMax = 3.5f;                               

	private GameObject[] items;                           
	private int currentItemIndex = 0;                          

	private Vector2 startItemPosition = new Vector2(-10, -25);  
	private float spawnXPosition = 10f;

	private float startSpawnDelay = 1.5f;
	private float timeSinceLastSpawned;

	void Start()
	{
		timeSinceLastSpawned = 0f;

		items = new GameObject[poolSize];

		for (int i = 0; i < poolSize; i++)
		{
			items[i] = (GameObject)Instantiate(itemPrefab, startItemPosition, Quaternion.identity);
		}
	}


	void Update()
	{
		if (Time.timeSinceLevelLoad < startSpawnDelay)
			return;

		timeSinceLastSpawned += Time.deltaTime;

		if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
		{
			timeSinceLastSpawned = 0f;

			float spawnYPosition = Random.Range(YMin, YMax);

			var item = items[currentItemIndex];
			item.transform.position = new Vector2(spawnXPosition, spawnYPosition);
			item.SetActive(true);

			currentItemIndex++;

			if (currentItemIndex >= poolSize)
			{
				currentItemIndex = 0;
			}
		}
	}
}