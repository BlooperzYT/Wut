
();  ModAPI.Register()
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"),
        NameOverride = "BlooperzMan",
        DescriptionOverride = "It'sa me!",
        CategoryOverride = ModAPI.FindCategory("Entities"),
        ThumbnailOverride = ModAPI.LoadSprite("bruhhhThumb.png"),
        AfterSpawn = (Instance) =>
        {
            var skin = ModAPI.LoadTexture("ExampleSkinHuman.png");// textures
            var flesh = ModAPI.LoadTexture("ExampleFlesh.png");// textures
            var bone = ModAPI.LoadTexture("ExampleBone.png");// textures
            var person = Instance.GetComponent<PersonBehaviour>(); //dont change
            person.SetBodyTextures(skin, flesh, bone, 1); //dont change
            person.SetBruiseColor(86, 62, 130);//colors'n'stuff
            person.SetSecondBruiseColor(154, 0, 7);//colors'n'stuff
            person.SetThirdBruiseColor(207, 206, 120);//colors'n'stuff
            person.SetRottenColour(202, 199, 104);//colors'n'stuff
            person.SetBloodColour(108, 0, 4);//colors'n'stuff
        }
    }
     


using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System.Linq;

namespace Mod

    public class Mod
      public static void Main()
  

();  ModAPI.Register()
    new Modification()
    {