using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemsGameController : BehavierController
{
    protected virtual void BeDestroy() { }

	protected virtual void Spawn() { }
}
