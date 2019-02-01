using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    [SerializeField] private List<GameObject> doors = new List<GameObject>();
    
    public List<GameObject> Doors {
        get {
            return doors;
        }

        private set {
            doors = value;
        }
    }

}
