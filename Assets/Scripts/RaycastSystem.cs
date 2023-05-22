using UnityEngine;

public class RaycastSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if left click is pressed. Should convert to taps on mobile
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out rayHit))
            {
                GameObject obj = rayHit.collider.gameObject;

                Debug.Log("Clicked the " + obj.name);

                Raycastable rc = rayHit.collider.gameObject.GetComponent<Raycastable>();
                rc.Interact();
            }
        }
    }
}
