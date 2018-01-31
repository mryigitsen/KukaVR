using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class J6Rotate : MonoBehaviour
{

	public Slider J6Slider;
	public GameObject A6;

	public float J6Angle;

	void Update ()
	{
		J6Angle = J6Slider.value;
		A6.transform.localEulerAngles = new Vector3(0, J6Angle,90 );

	}

}