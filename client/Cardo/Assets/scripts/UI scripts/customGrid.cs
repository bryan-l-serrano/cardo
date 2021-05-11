using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customGrid : MonoBehaviour
{
    public GameObject target;
    public GameObject structure;
    Vector3 truePos;
    public float gridSizeX;
    public float offSetX;

    public float gridSizeZ;
    public float offSetZ;
    // Start is called before the first frame update

    // Update at end of frame
    void LateUpdate()
    {
        truePos.x = Mathf.Floor(target.transform.position.x /gridSizeX) *gridSizeX - offSetX;
        truePos.y = 0;
        truePos.z = Mathf.Floor(target.transform.position.z /gridSizeZ) *gridSizeZ - offSetZ;
        structure.transform.position = truePos; 
    }
}
