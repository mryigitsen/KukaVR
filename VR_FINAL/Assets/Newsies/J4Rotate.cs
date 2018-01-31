using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class J4Rotate : MonoBehaviour
{

	public Slider J4Slider;
	public GameObject A4;

	public float J4Angle;

	void Update ()
	{
		J4Angle = J4Slider.value;
		A4.transform.localEulerAngles = new Vector3(0, J4Angle,90 );

	}

}