using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;



public class CarPartsSelect : MonoBehaviour {

	[SerializeField]  private GameObject body, cluster, frame, frontBumper, frontLeftFender,
		frontRightFender, glass, hood, interior, leftFrontdoor, leftHeadlight, leftSideskirt,
		leftTaillight, lod, rearBumper, rearDoorLeft, rearDoorRight, rearLeftFender,
		rearRightFender, rightFrontDoor, rightHeadlight, rightSideskirt, rightTaillight,
		rollcage, spacer, spoiler, trunk, wheels;

	public void ClickSelection()
	{
        EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.yellow;
        PlayerPrefs.SetString("PartsSelected", PlayerPrefs.GetString("PartsSelected") + EventSystem.current.currentSelectedGameObject.name + ";");
        switch (EventSystem.current.currentSelectedGameObject.name)                   
		{                                                                             
			case "Body": body.gameObject.tag = "Selected";
            break;
			case "Cluster": cluster.gameObject.tag = "Selected";
            break;
			case "Frame": frame.gameObject.tag = "Selected";
            break;
			case "Front Bumper": frontBumper.gameObject.tag = "Selected";
            break;
			case "Front Left Fender": frontLeftFender.gameObject.tag = "Selected";
            break;
			case "Front Right Fender": frontRightFender.gameObject.tag = "Selected";
            break;
			case "Glass": glass.gameObject.tag = "Selected";
            break;
			case "Hood": hood.gameObject.tag = "Selected";
            break;
			case "Interior": interior.gameObject.tag = "Selected";
            break;
			case "Left Front Door": leftFrontdoor.gameObject.tag = "Selected";
            break;
			case "Left Headlight": leftHeadlight.gameObject.tag = "Selected";
            break;
			case "Left Sideskirt": leftSideskirt.gameObject.tag = "Selected";
            break;
			case "Left Taillight":leftTaillight.gameObject.tag = "Selected";
            break;
			case "LOD": lod.gameObject.tag = "Selected";
            break;
			case "Rear Bumper": rearBumper.gameObject.tag = "Selected";
            break;
			case "Rear Door Left": rearDoorLeft.gameObject.tag = "Selected";
            break;
			case "Rear Door Right": rearDoorRight.gameObject.tag = "Selected";
            break;
			case "Rear Left Fender": rearLeftFender.gameObject.tag = "Selected";
            break;
			case "Rear Right Fender": rearRightFender.gameObject.tag = "Selected";
            break;
			case "Right Front Door": rightFrontDoor.gameObject.tag = "Selected";
            break;
			case "Right Headlight": rightHeadlight.gameObject.tag = "Selected";
            break;
			case "Right Sideskirt": rightSideskirt.gameObject.tag = "Selected";
            break;
			case "Right Taillight": rightTaillight.gameObject.tag = "Selected";
            break;
			case "Rollcage": rollcage.gameObject.tag = "Selected";
            break;
			case "Spacer": spacer.gameObject.tag = "Selected";
            break;
			case "Spoiler": spoiler.gameObject.tag = "Selected";
            break;
			case "Trunk": trunk.gameObject.tag = "Selected";
            break;
			case "Wheels": wheels.gameObject.tag = "Selected";
            break;
		}
	}
}
