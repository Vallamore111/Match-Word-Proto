using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : Tile
{
    public override void SetName() => gameObject.name = "Tile [" + index.x + "," + index.y + "]: Stone";

    public override void InitializeTile(Vector2Int index)
    {
        SetIndex(index);
        SetName();
        SetPosition();
    }

}
