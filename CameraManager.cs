using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [SerializeField] private MapManager mapManager;
    [SerializeField] private GameObject player;

    public Vector2 pos = new Vector2(8, 8);

    private void Start() {
        transform.position = player.transform.position; // Set camera on the same position as the player when the game starts;
    }

    private void Update() {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, pos.x * mapManager.offset, Time.deltaTime * 5), Mathf.Lerp(transform.position.y, pos.y * mapManager.offset, Time.deltaTime * 5), -11); // Update camera to follow the player in rooms
    }

}
