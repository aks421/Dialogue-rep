using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectionsManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";

    private Transform _selection;
    private bool handsFull = false;

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag)) {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null) {
                    if (Input.GetKeyDown("e") && !handsFull) {
                        print("Picked up item");
                        handsFull = true;
                    }
                }
            }
            
        }

        if (Input.GetKeyDown("e") && handsFull)
        {
            handsFull = false;
            print("Let of item!");
        }
    }
}
