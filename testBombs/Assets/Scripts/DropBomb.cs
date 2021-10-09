using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBomb : MonoBehaviour
{
    [SerializeField]
    private Transform _parent;
    [SerializeField]
    private GameObject bomb;

   public  GameObject bombInScene;
    void Update()
    {
       
        

    }
    public void _DropBomb()
    {
   bombInScene = GameObject.FindWithTag("Bomb");
        if(bombInScene == null)
        {
            Instantiate(bomb, _parent.transform.position, _parent.transform.rotation);
        }
    }
}
