/*
* (Matt Kirchoff)
* (Animal.cs)
* (Assignment1)
* (Contains methods of each animal class.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment1
{

    public abstract class Animal
    {
        public abstract void Die();

    
    }
    public class AnimalDog : Animal, ICanSpeak
    {
        public override void Die()
        {
            Debug.Log("The dog dies.");         
        }

        public void ISpeak()
        {
            Debug.Log("The dog barks.");
        }
    }

    public class AnimalCat : Animal, ICanSpeak
    {
        public override void Die()
        {
            Debug.Log("The cat dies.");
        }

        public void ISpeak()
        {
            Debug.Log("The cat meows.");
        }

    }

}
