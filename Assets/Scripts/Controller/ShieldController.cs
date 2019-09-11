using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		PlaneObserver.Instance.AddObserver<GameData>(TOPICNAME.BoombWithShiled,Destroy );
		PlaneObserver.Instance.AddObserver<GameData>(TOPICNAME.FruitWithShiled, Destroy);
    }
	
	public void Destroy(GameData data)
	{
		Destroy(gameObject);
	}
	
}
