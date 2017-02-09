using UnityEngine;
public class Pulse : MonoBehaviour {
	private Light myLight;
	public float maxIntensity = 3.91f;
	public float minIntensity = 0f;
	public float pulseSpeed = 1f; //.5 = 2s and 2s = .5
	private float targetIntensity = 1f;
	private float currentIntensity;    


	void Start(){
		myLight = GetComponent<Light>();
	}    
	void Update(){
		currentIntensity = Mathf.MoveTowards(myLight.intensity,targetIntensity, Time.deltaTime*pulseSpeed);
		if(currentIntensity >= maxIntensity){
			currentIntensity = maxIntensity;
			targetIntensity = minIntensity;
		}else if(currentIntensity <= minIntensity){
			currentIntensity = minIntensity;
			targetIntensity = maxIntensity;
		}
		myLight.intensity = currentIntensity;
	}
}