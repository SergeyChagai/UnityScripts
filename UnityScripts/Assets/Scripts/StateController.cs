using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateController : MonoBehaviour
{
    private GameObject currentState;

    public void ChangeState(GameObject reactor)
    {
        currentState?.SetActive(false);
        reactor.SetActive(true);
        currentState = reactor;
    }

}
