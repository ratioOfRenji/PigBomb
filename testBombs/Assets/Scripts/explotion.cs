using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explotion : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(waitBeforeStop());
    }
    private IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(1.5f);
       
        Destroy(gameObject);
    }
}
