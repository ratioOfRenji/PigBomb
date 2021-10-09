using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridBuildingSystem : MonoBehaviour
{
    //public static GridBuildingSystem current;
    //public GridLayout _gridLayout;
    //public Tilemap _tilemap;
    //public Tilemap _tempTileMap;
    //public static Dictionary<TileTipe, TileBase> tileBases = new Dictionary<TileTipe, TileBase>();
    //#region Unity Methods
    //private void Awake()
    //{
    //    current = this;
    //}

    //private void Start()
    //{
    //    string tilePath = @"Tiles\";
    //    tileBases.Add(TileTipe.empty, null);
    //    tileBases.Add(TileTipe.white, Resources.Load<TileBase>(path: tilePath + "white")) ;
    //    tileBases.Add(TileTipe.empty, Resources.Load<TileBase>(path: tilePath + "green"));
    //    tileBases.Add(TileTipe.empty, Resources.Load<TileBase>(path: tilePath + "red"));


    //}

    //private void Update()
    //{
        
    //}


    //#endregion
    //#region TilemapManagment
    //private static TileBase[] GetTilesBlock(BoundsInt area, Tilemap tilemap)
    //{
    //    TileBase[] array
    //}
    //#endregion
    //#region Bulding Placement
    //#endregion
}
public enum TileTipe
{
    empty,
    green,
    white,
    red
}
