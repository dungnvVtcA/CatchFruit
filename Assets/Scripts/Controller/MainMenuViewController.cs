using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuViewController : MonoBehaviour
{
	[SerializeField]
	private UIButton BtnStart;
    void Start()
    {
		BtnStart.SetUpEvent(BtnClickStart); 
    }

	public void BtnClickStart()
	{
		Debug.Log("click");
		GamePlayController.Instance.isPauseGame = false;
		GamePlayController.Instance.SpawnFruit();
		
		gameObject.SetActive(false);
	}
}
