using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneManager : MonoBehaviour
{
    public GameObject stonePrefab;
    public static StoneManager instance;



    private void Awake() => instance = this;


    public void SetUpStones()
    {
        foreach (var slot in Board.tileSlots)
        {
            bool stone = LevelManager.CheckStoneLayout(slot);

            if (!stone) continue;
            if (TileManager.FindTile(slot) != null) continue;

            CreateStoneTile(slot);
        }
    }


    public void CreateStoneTile(Vector2Int index)
    {
        var obj = Instantiate(stonePrefab, Board.instance.transform);
        var stone = obj.GetComponent<Stone>();
        stone.InitializeTile(index);
        TileManager.allTiles.Add(stone);
    }
}
