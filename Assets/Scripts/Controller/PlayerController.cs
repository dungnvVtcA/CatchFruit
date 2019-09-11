using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BehavierController
{
	private void Awake()
	{
		
	}
	void Start()
    {
		
		PlaneObserver.Instance.AddObserver<GameData>(TOPICNAME.FruitWithPlayer, UPgradeScore);
		PlaneObserver.Instance.AddObserver<GameData>(TOPICNAME.FruitDestroy, Destroy);
		PlaneObserver.Instance.AddObserver<GameData>(TOPICNAME.BoombWithPlayer, Destroy);

	}

	public void UPgradeScore(GameData data)
	{
		GamePlayController.Instance.GetgamePlayView().SettextCore(10);
	}

	public void Destroy(GameData data)
	{
		PlaneObserver.Instance.RemoveObserver<GameData>(TOPICNAME.FruitWithPlayer, UPgradeScore);
		PlaneObserver.Instance.RemoveObserver<GameData>(TOPICNAME.FruitDestroy, Destroy);
		GamePlayController.Instance.GamePlayLose();
		gameObject.SetActive(false);

	}
	
	void Update()
	{
		if (!GamePlayController.Instance.isPauseGame)
		{
			Vector3 endPoint = new Vector3(Input.mousePosition.x - Screen.width / 2, this.transform.localPosition.y, 0);
			MoveUpdate(endPoint);
		}
	}
}
