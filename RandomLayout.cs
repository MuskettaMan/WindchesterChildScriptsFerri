using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLayout : MonoBehaviour {

    [SerializeField] List<GameObject> layouts = new List<GameObject>();
    private void Start() {
        int random = Random.Range(0, layouts.Count);

        GameObject clone = Instantiate(layouts[random], new Vector3(0,0,0), Quaternion.identity);

        clone.transform.position = transform.position;
    }

}
