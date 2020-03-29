/*
* (Matt Kirchoff)
* (Speak.cs)
* (Assignment1)
* (Implements methods of each animal class. using alpha keys 1 and 2)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment1
{

    public class Speak : MonoBehaviour
    {
        public Animal dog;

        public Animal[] animals = new Animal[5];

        public List<Animal> animalsList = new List<Animal>();

        public List<ICanSpeak> canSpeakList = new List<ICanSpeak>();

        // Start is called before the first frame update
        void Start()
        { 
            for (int i = 0; i < 2; i++)
            {
                canSpeakList.Add(new AnimalDog());
                canSpeakList.Add(new AnimalCat());
            }
            for (int i = 0; i < 2; i++)
            {
                animalsList.Add(new AnimalDog());
                animalsList.Add(new AnimalCat());
            }

        }

        void SpeakOne()
        {
            foreach (ICanSpeak canSpeak in canSpeakList)
            {
                if (canSpeak == null) { break; }
                canSpeak.ISpeak();
            }    
        }
        void KillOne()
        {
            foreach (Animal animal in animalsList)
            {
                if (animal == null) { break; }
                animal.Die();
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SpeakOne();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                KillOne();
            }
        }
        
    }

}