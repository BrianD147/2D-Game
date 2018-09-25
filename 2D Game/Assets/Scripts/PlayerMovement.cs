using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Update is called once per frame
    void Update () {
        if (Input.touchCount > 0)
        {
            //Test touch input
            Debug.Log(Input.GetTouch(0).position);
        }
	}
	
}
