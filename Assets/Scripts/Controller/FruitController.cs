using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : ItemsGameController
{
    private Vector2 screenBonus;

    [SerializeField]
    private float speed;


    void Start()
    {
        screenBonus = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
		
        Spawn();
    }

    protected override void Spawn()
    {
		
		Vector3 endPoint = new Vector3(gameObject.transform.localPosition.x, -500f, 0);

		MoveTo(endPoint, () =>
		{
			BeDestroy();
		});

	}
    
    void Update()
    {

		CheckCollider();
	}
    protected override void BeDestroy()
    {
		PlaneObserver.Instance.Notify(TOPICNAME.FruitDestroy, null);
		Destroy(gameObject);
    }
	protected override void OnCollection(Collider2D collider)
	{
		
		
		if(collider.tag == "Shiled")
		{
			
			PlaneObserver.Instance.Notify(TOPICNAME.FruitWithShiled, null);
		}
		if (collider.tag == "Player")
		{
			
			PlaneObserver.Instance.Notify(TOPICNAME.FruitWithPlayer, null);
		}
		Destroy(this.gameObject);
	}
}
