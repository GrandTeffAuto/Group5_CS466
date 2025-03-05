//This script is responsible for main bridge functions
//Responsible for moving bridges into complete-positions and others - Alex

//Imports
using UnityEngine;
using System.Collections;

public class BridgeController : MonoBehaviour
{
    public Vector3 targetPosition; // Final position of the bridge
    public float moveSpeed = 2f; // Speed of bridge raising

    private bool isRaised = false;

    public void RaiseBridge()
    {
        if (!isRaised)
        {
            Debug.Log(gameObject.name + " - Raising Bridge!");
            StartCoroutine(MoveBridgeUp());
            isRaised = true;
        }
        else
        {
            Debug.Log(gameObject.name + " - Bridge is already raised.");
        }
    }

    private IEnumerator MoveBridgeUp()
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            Debug.Log(gameObject.name + " - Moving bridge: " + transform.position);
            yield return null;
        }
        transform.position = targetPosition; // Ensure precise placement
        Debug.Log(gameObject.name + " - Bridge movement complete!");
    }
}
