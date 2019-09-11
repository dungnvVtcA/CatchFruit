using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateController :  SingletionMonoBehaviour<CreateController>
{
    [SerializeField]
    private ShieldController _Shield;
    [SerializeField]
    private BombSontroller _Item;

	[SerializeField]
	private FruitController _Fruit;

    T createObject<T>(T Object,Vector3 position,Transform parent = null) where T : MonoBehaviour
    {
        if (parent == null) parent = this.transform;
        T _object = Instantiate<T>(Object,position,Object.transform.rotation,parent);
        _object.transform.localPosition = position;
        return _object;
    }

    public BombSontroller creatBoomb(Vector3 position, Transform parent = null){
        return createObject (_Item ,position,parent);
    }

	public FruitController creatFruit(Vector3 position, Transform parent = null)
	{
		return createObject(_Fruit, position, parent);
	}

	public ShieldController creatShield(Vector3 position, Transform parent = null)
	{
		return createObject(_Shield, position, parent);
	}
}
