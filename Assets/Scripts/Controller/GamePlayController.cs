using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : SingletionMonoBehaviour<GamePlayController>
{
	[SerializeField]
	private float TimeSpawnFruit;

	[SerializeField]
	private GamePlayViewController gamePlayeView;

	public bool isPauseGame;
	
	private void Awake()
	{
		isPauseGame = true;
		
	}
	void Start()
    {
		
		//PoolingObject.Instance.CreateListObject();
	}
	public void SpawnFruit()
	{
		
		Debug.Log("Spawn");
		CreateController.Instance.creatFruit(new Vector3(Random.Range(-150f, 150f), 500f, 0));
		SpawnBoomb();
		StartCoroutine(SpawnFR(TimeSpawnFruit));

	}
	IEnumerator SpawnFR(float TimeSpawn)
	{
		yield return new WaitForSeconds(TimeSpawn);
		SpawnFruit();
	}
	public GamePlayViewController GetgamePlayView()
	{
		return gamePlayeView;
	}
    // Update is called once per frame
	public void GamePlayLose()
	{
		gamePlayeView.OnShowPopUpGameLose();
	}
	
	public void SpawnBoomb()
	{
		int i = Random.Range(0, 4);
		if(i == 1 && gamePlayeView.score > 100)
		{
			CreateController.Instance.creatBoomb(new Vector3(Random.Range(-150f, 150f), 500f, 0));
		}
		
	}
}
