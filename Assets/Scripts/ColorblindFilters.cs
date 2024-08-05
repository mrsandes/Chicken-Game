using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorblindFilters : MonoBehaviour {
    public Toggle ToggleNone;
    public Toggle ToggleProtanopia;
    public Toggle ToggleDeuteranotopia;
    public CameraController Cam;

    void Start() {
        Cam = Camera.main.GetComponent<CameraController>();

        if (PlayerPrefs.GetInt("ToggleBool") == 1) {
            ToggleNone.isOn = true;
        }

        else {
            ToggleNone.isOn = false;
        }

        if (PlayerPrefs.GetInt("ToggleBool2") == 1) {
            ToggleProtanopia.isOn = true;
        }

        else {
            ToggleProtanopia.isOn = false;
        }

        if (PlayerPrefs.GetInt("ToggleBool3") == 1) {
            ToggleDeuteranotopia.isOn = true;
        }

        else {
            ToggleDeuteranotopia.isOn = false;
        }
    }

    void Update() {
        if (ToggleNone.isOn == true) {
            PlayerPrefs.SetInt("ToggleBool", 1);
            Cam.Filter.mode = ColorBlindMode.Normal;
        }

        else {
            PlayerPrefs.SetInt("ToggleBool", 0);
        }

        if (ToggleProtanopia.isOn == true) {
            PlayerPrefs.SetInt("ToggleBool2", 1);
            Cam.Filter.mode = ColorBlindMode.Protanopia;
        }

        else {
            PlayerPrefs.SetInt("ToggleBool2", 0);
        }

        if (ToggleDeuteranotopia.isOn == true) {
            PlayerPrefs.SetInt("ToggleBool3", 1);
            Cam.Filter.mode = ColorBlindMode.Deuteranopia;
        }

        else {
            PlayerPrefs.SetInt("ToggleBool3", 0);
        }
    }
}
