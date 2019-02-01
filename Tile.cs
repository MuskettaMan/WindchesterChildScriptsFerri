using UnityEngine;

public class Tile {

    public Tile(Vector3 position, GameObject instance = null) {
        Position = position;
        Instance = instance;
    }

    public Vector3 Position {
        get; set;
    }

    public GameObject Instance {
        get; set;
    }

    public bool Corner {
        get; set;
    }
}

