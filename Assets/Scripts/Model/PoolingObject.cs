using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingObject : SingletionMonoBehaviour<PoolingObject>
{
    [SerializeField]
    private int maxNumberObject;

    private List<GameObject> listobjectPooling;

	public GameObject ObjFruit;
    private void Awake()
    {
        listobjectPooling = new List<GameObject>();
    }
    public void CreateListObject()
    {
		//ObjFruit = (GameObject)Instantiate()
        for (int i = 0; i < maxNumberObject; i++)
        {
			var obj = Instantiate(ObjFruit) as GameObject;
			obj.transform.GetComponent<GameObject>().SetActive(false);
            listobjectPooling.Add(obj);
        }

    }
    public GameObject GetObjectPooling()
    {
        if (listobjectPooling.Count > 0)
        {
            for (int i = 0; i < listobjectPooling.Count; i++)
            {
                if (!listobjectPooling[i].transform.GetComponent<GameObject>().activeInHierarchy)
                {
                    return listobjectPooling[i];
                }
            }
        }
        return null;
    }
    
}
