using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class XYCoords
{
    public float x;
    public float y;

    public XYCoords(float x, float y)
    {
        this.x = x;
        this.y = y;
    }



}

public static class Functions
{
    public static XYCoords[] circlePts(XYCoords center, float radius, int quantity)
    {
        XYCoords[] pts = new XYCoords[quantity + 1];

        double angleConst = 2 * System.Math.PI / quantity;

        for (int i = 0; i <= quantity; i++)
        {
            float x = System.Convert.ToSingle(center.x + radius * System.Math.Sin(angleConst * i));

            float y = System.Convert.ToSingle(center.y + radius * System.Math.Cos(angleConst * i));

            pts[i] = new XYCoords(x, y);
        }

        return pts;
    }
}

public class ConeScript : MonoBehaviour

{
    public static int NUM_TRIANGLE = 3;

    // Start is called before the first frame update
    void Start()
    {

        // Add a MeshFilter component to this entity. This essentially comprises of a
        // mesh definition, which in this example is a collection of vertices, colours 
        // and triangles (groups of three vertices). 
        MeshFilter cubeMesh = this.gameObject.AddComponent<MeshFilter>();
        cubeMesh.mesh = this.CreateCubeMesh();


        // Add a MeshRenderer component. This component actually renders the mesh that
        // is defined by the MeshFilter component.
        MeshRenderer renderer = this.gameObject.AddComponent<MeshRenderer>();
        renderer.material.shader = Shader.Find("Unlit/VertexColorShader");
    }


    // Method to create a cube mesh with coloured vertices
    Mesh CreateCubeMesh()
    {
        Mesh m = new Mesh();
        m.name = "Cone";

        // Define the vertices. These are the "points" in 3D space that allow us to
        // construct 3D geometry (by connecting groups of 3 points into triangles).
        m.vertices = new [] { new Vector3(1.0f, -1.0f, 1.0f),
   new Vector3(1.0f, 1.0f, 1.0f),
        m.vertices[2] = new Vector3(-1.0f, 1.0f, 1.0f)};


        // Define the vertex colours
        m.colors = new [] {Color.black,
        Color.red,
       Color.red
        };

        


        // Automatically define the triangles based on the number of vertices
        // Task 4: Modify this code to show the interior of the cube instead of the exterior
        // when back-face culling is on.
        int[] triangles = new int[m.vertices.Length];
        for (int i = 0; i < m.vertices.Length; i++)
            triangles[i] = i;

        m.triangles = triangles;

        return m;
    }


}
