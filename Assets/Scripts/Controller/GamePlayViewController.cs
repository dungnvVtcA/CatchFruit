using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayViewController : MonoBehaviour
{
	[SerializeField]
	private Text Score;

	[SerializeField]
	private UIPopupGamaOverController popupGameLose;

	[SerializeField]
	private Text HightScore;

	public int score;
	int currentHightScore;
	private void Awake()
	{
		currentHightScore = DataManager.Instance.LoadDataHightScore("Data.json");
	}
	void Start()
    {
		SetupData();
    }

	public void OnShowPopUpGameLose()
	{
		popupGameLose.SetupData();
	}
	public void SetupData()
	{
		score = 0;
		Score.text = "Score : 0";
		SetHightScore(currentHightScore);
	}
	public void SetHightScore(int newHightScore)
	{
		HightScore.text = "Hight Score : "+ newHightScore.ToString(); 
	}
	
	public void SettextCore(int score_)
	{
		score += score_;
		Score.text = "Score : "+ score.ToString();
		if(score > currentHightScore)
		{
			SetHightScore(score);
			DataManager.Instance.SaveData("Data.json", score);
		}
	}
	
}
