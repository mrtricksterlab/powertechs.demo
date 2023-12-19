using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{

    private Vector3 prevPosition;

    // Start is called before the first frame update
    void Start()
    {
        prevPosition = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        var deltaPos = mousePos - prevPosition;
        this.transform.localPosition += deltaPos * Time.smoothDeltaTime;
        prevPosition = Input.mousePosition;
    }
}
