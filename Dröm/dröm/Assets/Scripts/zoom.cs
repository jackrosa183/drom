using UnityEngine;
using System.Collections;

public class zoom : MonoBehaviour 
{
	public int zoomNo = 20;
    public int normal = 60;
	public float smooth = 5;

	private bool isZoomed = false;

	void Update() 
	{
		if (Input.GetMouseButtonDown (1)) {
			
			isZoomed = !isZoomed;
		}

		if(isZoomed)
		{
			GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoomNo, Time.deltaTime * smooth);
		}

		else
		{
			GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
		}
	}
}