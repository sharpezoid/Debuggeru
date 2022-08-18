using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoDemo : MonoBehaviour
{
    public Transform G1;
    public Transform G2;

    public Texture Texture;

    public Mesh mesh;

    private void OnDrawGizmos()
    {
        Gizmos.DrawMesh(mesh);
    }
}
