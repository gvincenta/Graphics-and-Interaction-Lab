using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { 

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
        m.name = "Pyramid";

        // Define the vertices. These are the "points" in 3D space that allow us to
        // construct 3D geometry (by connecting groups of 3 points into triangles).
        m.vertices = new[] {
            new Vector3(0.0f, 1.0f, 0.0f), // Front
            new Vector3(-1.0f, 0.0f, -1.0f), // Front
            new Vector3(1.0f, 0.0f, -1.0f), // Front

   

            new Vector3(1.0f, 0.0f, 1.0f),
            new Vector3(0.0f, 1.0f, 0.0f), // Left
            new Vector3(1.0f, 0.0f, -1.0f),

             new Vector3(-1.0f, 0.0f, -1.0f),
            new Vector3(0.0f, 1.0f, 0.0f), // Right
            new Vector3(-1.0f, 0.0f, 1.0f),


             new Vector3(-1.0f, 0.0f, 1.0f),
            new Vector3(0.0f, 1.0f, 0.0f), // Back
            new Vector3(1.0f, 0.0f, 1.0f),


            new Vector3(1.0f, 0.0f, 1.0f),
            new Vector3(-1.0f, 0.0f, 1.0f), // Base1
             new Vector3(-1.0f, 0.0f, -1.0f),


             new Vector3(-1.0f, 0.0f, -1.0f),
            
            new Vector3(1.0f, 0.0f, -1.0f), // base2
             new Vector3(1.0f, 0.0f, 1.0f)



        };

        // Define the vertex colours
        m.colors = new[] {
            Color.red, // Top
            Color.red,
            Color.red,

            Color.red, // left
            Color.yellow,
            Color.blue,

            Color.blue, // right
            Color.blue,
            Color.blue,

            Color.yellow, // back
            Color.green,
            Color.black,


            Color.black, // base 1
            Color.green,
            Color.black,
            Color.red, // base2
            Color.yellow,
            Color.blue


            //Color.red,
            //Color.red,
            //Color.red,

            //Color.red, // Bottom
            //Color.red,
            //Color.red,
            //Color.red,
            //Color.red,
            //Color.red,

            //Color.yellow, // Left
            //Color.yellow,
            //Color.yellow,
            //Color.yellow,
            //Color.yellow,
            //Color.yellow,

            //Color.yellow, // Right
            //Color.yellow,
            //Color.yellow,
            //Color.yellow,
            //Color.yellow,
            //Color.yellow,

            //Color.blue, // Back
            //Color.blue,
            //Color.blue,
            //Color.red,
            //Color.yellow,
            //Color.blue,



            //Color.blue, // Front
            //Color.blue,
            //Color.blue,
            //Color.red,
            //Color.yellow,
            //Color.blue
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
