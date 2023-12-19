using RootMotion.FinalIK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyController : MonoBehaviour
{
    [SerializeField] private FullBodyBipedIK fullBody;

    // Start is called before the first frame update
    void Start()
    {
        //fullBody.solver.leftHandEffector.positionWeight = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
            //fullBody.solver.leftHandEffector.positionWeight = .5f;

        //if (Input.GetMouseButtonDown(1))
            //Debug.Log("Pressed right-click.");

    }
}
