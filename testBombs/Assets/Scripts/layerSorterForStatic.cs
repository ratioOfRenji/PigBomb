using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class layerSorterForStatic : MonoBehaviour
{
    
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = (int)(transform.position.y * -10);
    }

   
}
