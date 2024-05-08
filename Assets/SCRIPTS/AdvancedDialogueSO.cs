using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu]

public class AdvancedDialogueSO : ScriptableObject
{
   //public DialogueActors[] actors;
   [Header("Narrator")]
   public string narratorName;
   private bool dialogueActivated;

   private GameObject dialogueCanvas;
   private Text actor;
   private Image portrait;
   private Text dialogueText;
  
   [Header("Dialogue")]
   [TextArea]
   public string[] dialogue;
   public string[] optionText;

   public AdvancedDialogueSO option0;
   public AdvancedDialogueSO option1;
   public AdvancedDialogueSO option2;

   void Start()
   {
	   dialogueCanvas = GameObject.Find("DialogueCanvas");
	   actor = GameObject.Find("ActorText").GetComponent<Text>();
	   portrait = GameObject.Find("Portrait").GetComponent<Image>();
	   dialogueText = GameObject.Find("DialogueText").GetComponent<Text>();

	   dialogueActivated = true;
	   dialogueCanvas.SetActive(true);


   }
}
