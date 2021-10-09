using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    [SerializeField]
    private GameObject explotion;
    [SerializeField]
    private Transform _parent;

    [SerializeField]
    private Transform player;
    public float distance;
    [SerializeField]
    private GameObject bombColider;
    private void Awake()
    {
       
        StartCoroutine(waitBeforeStop());
    }
    private void OnEnable()
    {
         player = GameObject.FindWithTag("PlayerPos").GetComponent<Transform>();
    }
    private IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(3.3f);
        Instantiate(explotion, _parent.transform.position, _parent.transform.rotation);
        Destroy(gameObject);
    }
    private void Update()
    {
        if (this != null)
        {
            distance = Vector3.Distance(this.transform.position, player.transform.position);
            if (distance > 0.7f)
            {
             bombColider.SetActive(true);
            }
               
        }

    }
}
