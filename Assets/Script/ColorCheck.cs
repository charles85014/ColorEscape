using UnityEngine;
using System.Collections;

public class ColorCheck : MonoBehaviour {
    public bool ColorHide = false;
	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerEnter(Collider other) {

        if (other.renderer.material.name.Contains(this.renderer.material.name))
        {
            ColorHide = true;
        }
        else
            ColorHide = false;
        
    }
	// Update is called once per frame
	void Update () {
        print(ColorHide);
        if (Input.GetKey(KeyCode.A))
            this.renderer.material = GameObject.Find("PlaneMaterialControl").GetComponent<BGMaterialControl>().PlaneMaterial[0];
        if (Input.GetKey(KeyCode.S))
            this.renderer.material = GameObject.Find("PlaneMaterialControl").GetComponent<BGMaterialControl>().PlaneMaterial[1];
        if (Input.GetKey(KeyCode.D))
            this.renderer.material = GameObject.Find("PlaneMaterialControl").GetComponent<BGMaterialControl>().PlaneMaterial[2];
        if (Input.GetKey(KeyCode.F))
            this.renderer.material = GameObject.Find("PlaneMaterialControl").GetComponent<BGMaterialControl>().PlaneMaterial[3];
        if (Input.GetKey(KeyCode.G))
            this.renderer.material = GameObject.Find("PlaneMaterialControl").GetComponent<BGMaterialControl>().PlaneMaterial[4];
        if (Input.GetKey(KeyCode.H))
            this.renderer.material = GameObject.Find("PlaneMaterialControl").GetComponent<BGMaterialControl>().PlaneMaterial[5];
	}
}
