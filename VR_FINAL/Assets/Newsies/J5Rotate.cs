using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class J5Rotate : MonoBehaviour
{

	public Slider J5Slider;
	public GameObject A5;

	public float J5Angle;

	void Update ()
	{
		J5Angle = J5Slider.value;
		A5.transform.localEulerAngles = new Vector3(0, 0, J5Angle);

	}

}