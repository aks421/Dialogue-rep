using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointingRay : MonoBehaviour
{
    [SerializeField]
    Camera cam;
    Vector3 pos = new Vector3(200, 200, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(pos);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
    }
}
