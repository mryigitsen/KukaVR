using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class J2Rotate : MonoBehaviour
{

	public Slider J2Slider;
	public GameObject A2;

	public float J2Angle;

	void Update ()
	{
		J2Angle = J2Slider.value;
		A2.transform.localEulerAngles = new Vector3(90, J2Angle, 0);
	
	}

}