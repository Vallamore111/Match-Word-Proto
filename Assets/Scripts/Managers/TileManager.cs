using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public static TileManager instance;
    public GameObject tilePrefab;
    public static List<Tile> columnTiles = new List<Tile>();
    public static List<Tile> rowTiles = new List<Tile>();
    public static HashSet<Tile> allTiles = new HashSet<Tile>();



    private void Awake() => instance = this;


    public void CreateTile(Vector2Int index)
    {
        var tileObj = Instantiate(tilePrefab, Board.instance.transform);
        var tile = tileObj.GetComponent<Tile>();
        tile.InitializeTile(index);
        allTiles.Add(tile);
    }


    public static Tile FindTile(Vector2Int index)
    {
        foreach (var tile in allTiles)
        {
            if (tile.index == index)
            { return tile; }
        }
        return null;
    }


    public static Vector3 GetPositionByIndex(Vector2Int index)
    {
        Vector3 pos = new Vector3(index.x, index.y, 0);
        return pos;
    }


    public static Vector2Int GetIndexByPosition(Vector3 position)
    {
        Vector2Int index = new Vector2Int((int)position.x, (int)position.y);
        return index;
    }


    public static void LockToBoardSlot(Tile tile)
    {
        Vector3 pos = tile.transform.position;
        Vector3 roundedPos = new Vector3(Mathf.Round(pos.x), Mathf.Round(pos.y), Mathf.Round(pos.z));
        tile.transform.position = roundedPos;
    }


    public static void FindColumnAndRow(Tile tile)
    {
        foreach (var slot in Board.tileSlots)
        {
            if (slot.x == tile.index.x)
            { columnTiles.Add(FindTile(slot)); }

            if (slot.y == tile.index.y)
            { rowTiles.Add(FindTile(slot)); }
        }
    }


    public static void UpdateAllIndices()
    {
        foreach (var tile in allTiles)
        {
            LockToBoardSlot(tile);
            Vector2Int index = GetIndexByPosition(tile.transform.position);
            tile.UpdateIndex(index);
        }
    }


    public static void FreeTiles()
    {
        foreach (var tile in allTiles)
        {
            tile.transform.parent = Board.instance.transform;
        }
    }


    public static void CleanUpTiles(Tile tile)
    {
        allTiles.Remove(tile);
        Destroy(tile.gameObject);
    }


    public static Tile FindTileAbove(Vector2Int hole)
    {
        for (int y = hole.y + 1; y < Board.boardHeight; y++)
        {
            Vector2Int nextSlot = new Vector2Int(hole.x, y);
            Tile tileAbove = FindTile(nextSlot);

            if (tileAbove != null) return tileAbove;
        }
        return null;
    }
}
