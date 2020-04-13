using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCollider : MonoBehaviour {

    IEnumerator SimulateColliderToggle()
    {
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(1);
        GetComponent<Collider>().enabled = true;
    }
}
