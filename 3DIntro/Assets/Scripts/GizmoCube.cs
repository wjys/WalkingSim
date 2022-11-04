using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoCube : MonoBehaviour
{
    public Color _myColor;

    // Update is called once per frame
    private void OnDrawGizmos() {
        Gizmos.color = _myColor;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawCube(Vector3.zero, Vector3.one);
    }
}
