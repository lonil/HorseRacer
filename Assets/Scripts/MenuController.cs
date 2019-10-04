using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private float horseSpeed;
    public GameObject optionsMenu;
    public Slider speed;
    public Text text1;
    public Text placeHolderText1;
    public Text text2;
    public Text placeHolderText2;
    public Text text3;
    public Text placeHolderText3;
    public Text text4;
    public Text placeHolderText4;
    public Text text5;
    public Text placeHolderText5;


    // Start is called before the first frame update
    void Start()
    {

        ActiveMenu(optionsMenu);
        speed.value = PlayerPrefs.GetFloat("Speed");
        GetHorseName1();
        GetHorseName2();
        GetHorseName3();
        GetHorseName4();
        GetHorseName5();
    }

    public void SpeedGet ()
    {

        PlayerPrefs.SetFloat("Speed", speed.value);

    }

    public static void ActiveMenu(GameObject gameObject) => gameObject.SetActive(true);

    public void Quit() => GameController.ExitAplication();

    public void HideMenu(GameObject menu) => menu.SetActive(false);

    public void StartRun()
    {

        horseSpeed = speed.value;
        TransformeRunners.StartRun(horseSpeed);

    }

    public void ResetRun()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GetHorseName1(){
        placeHolderText1.text = PlayerPrefs.GetString("horse1", "Cavalo1");
            }
    public void SetHorseName1(Text horseName) {
        PlayerPrefs.SetString("horse1", horseName.text);
    }
    public void GetHorseName2( ){
        placeHolderText2.text = PlayerPrefs.GetString("horse2", "Cavalo2");
            }
    public void SetHorseName2(Text horseName) {
        PlayerPrefs.SetString("horse2", horseName.text);
    }
    public void GetHorseName3( ){
        placeHolderText3.text = PlayerPrefs.GetString("horse3", "Cavalo3");
            }
    public void SetHorseName3(Text horseName) {
        PlayerPrefs.SetString("horse3", horseName.text);
    }
    public void GetHorseName4( ){
        placeHolderText4.text = PlayerPrefs.GetString("horse4", "Cavalo4");
            }
    public void SetHorseName4(Text horseName) {
        PlayerPrefs.SetString("horse4", horseName.text);
    }
    public void GetHorseName5( ){
        placeHolderText5.text = PlayerPrefs.GetString("horse5", "Cavalo5");
            }
    public void SetHorseName5(Text horseName) {
        PlayerPrefs.SetString("horse5", horseName.text);
    }
}