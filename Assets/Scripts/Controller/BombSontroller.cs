using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSontroller : ItemsGameController
{
	private void Start()
	{
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
		Destroy(gameObject);
	}
	protected override void OnCollection(Collider2D collider)
	{
		if (collider.tag == "Shiled")
		{

			PlaneObserver.Instance.Notify(TOPICNAME.BoombWithShiled, null);
		}
		if (collider.tag == "Player")
		{

			PlaneObserver.Instance.Notify(TOPICNAME.BoombWithPlayer, null);
		}
		Destroy(this.gameObject);
	}
}
