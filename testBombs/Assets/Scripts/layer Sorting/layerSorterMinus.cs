using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class layerSorterMinus : MonoBehaviour
{
    [SerializeField]
    private GameObject Parent;
    
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = Parent.GetComponent<SpriteRenderer>().sortingOrder - 3;
    }

    
}
