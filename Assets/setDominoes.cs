using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setDominoes : MonoBehaviour {
    public GameObject dominoesPrefab;
    public GameObject dominoesend;
    public GameObject dominoesstart;
    public int NumCenterDom = 25;
    // Use this for initialization
    void Start() {
        Vector3 dir = dominoesend.transform.position - dominoesstart.transform.position;
        float interval = dir.magnitude / (NumCenterDom + 1);
        dir.Normalize();
        for (int i = 1; i <= NumCenterDom; i++)
        {
            GameObject newDom = (GameObject)Instantiate(dominoesPrefab);
            newDom.transform.position = dominoesstart.transform.position + dir * interval * i;
            newDom.transform.rotation = dominoesstart.transform.rotation;
        }
    }
    public float force = 4.0f;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            dominoesstart.GetComponent<Rigidbody>().AddForce(force, 0, 0, ForceMode.Impulse);

        }
    }
}


