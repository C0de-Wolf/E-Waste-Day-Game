using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Dialogue1 : MonoBehaviour
{
    public Text textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    private int a;

    public GameObject continuebutton;
    void Start()

    {
        
        StartCoroutine(Type());
    }
   
    void Update()
    {
        if(textDisplay.text == sentences[index]){
            continuebutton.SetActive(true);
            
        }
    }
    // Update is called once per frame
    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence(){
        continuebutton.SetActive(false);
        
        if(index < sentences.Length -1) {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }else{
            
            textDisplay.text = "";
            continuebutton.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
