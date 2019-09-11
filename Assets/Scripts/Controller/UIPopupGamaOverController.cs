using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPopupGamaOverController : MonoBehaviour
{
	[SerializeField]
	private UIButton btnReplay;
    void Start()
    {
		btnReplay.SetUpEvent(BtnClickReplay);
    }
	public void BtnClickReplay()
	{
		gameObject.SetActive(false);

	}
    public void SetupData()
	{
		gameObject.SetActive(true);
	}
}
