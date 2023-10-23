using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.TryGetComponent(out Wall wall))
        {
            Destroy(wall.gameObject);
        }
    }
}
