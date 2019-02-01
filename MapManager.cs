using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    [SerializeField] private int height = 16;
    [SerializeField] private int width = 16;

    public List<GameObject> rooms = new List<GameObject>();
    public float offset = 13;

    [SerializeField] public GameObject player;

    private Grid grid;

    void Start() {
        grid = new Grid(height, width);
        for(int i = 0; i < grid.Width; i++) {
            for(int j = 0; j < grid.Height; j++) {
                if(i == grid.Width / 2 && j == grid.Height / 2) {
                    grid.GetTile(i, j).Instance = Instantiate(rooms[Random.Range(0, rooms.Count)], new Vector3(i * offset, j * offset, 0), Quaternion.identity); // Instantiate starter room in the center of the grid
                    player.transform.position = grid.GetTile(i, j).Instance.transform.position + new Vector3(0, 0, -1); // Set player position in the center of the starting room
                }
                
            }
        }
        Grid = grid;
    }
    
    void Update() {
        
    }

    public Grid Grid {
        get; set;
    }

}
