using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour, IDamagable
{
    [SerializeField]
    private GameObject objectToDestroy;
    public void ApplyDamage()
    {
        Destroy(objectToDestroy);
    }

    
}
