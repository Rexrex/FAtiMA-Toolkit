﻿using System;
using System.Linq;
using AssetManagerPackage;
using EmotionalAppraisal;
using EmotionalAppraisal.DTOs;
using GAIPS.Rage;
using AutobiographicMemory;
using WellFormedNames;
using EmotionalAppraisal.AppraisalRules;

namespace EmotionalAppraisalTutorial
{
    class Program
    {
        //This is a small console program to exemplify the main functionality of the Emotional Appraisal Asset
        static void Main(string[] args)
        {
			AssetManager.Instance.Bridge = new BasicIOBridge();
			var kickEvent = (Name)"Event(Action-End, John, Kick, Player)";

            // To create a new asset it is required to tell the name of the agent which will correpond to the perspective of the "SELF" 
            EmotionalAppraisalAsset ea = new EmotionalAppraisalAsset("John");

            //The following lines add an appraisal rule that will make the kickEvent be perceived as undesirable
            //Normally, these rules should be authored using the AuthoringTool provided with the asset but they can also be added dynamically
            var rule = new AppraisalRuleDTO {
                EventMatchingTemplate = (Name)"Event(Action-End, *, Kick, *)",
                Praiseworthiness = -9f };
            ea.AddOrUpdateAppraisalRule(rule);

            var am = new AM();
            var emotionalState = new ConcreteEmotionalState();

            //Emotions are generated by the appraisal of the events that occur in the game world 
            ea.AppraiseEvents(new[] { kickEvent }, emotionalState, am);           
            Console.WriteLine("\nMood on tick '" + am.Tick + "': " + emotionalState.Mood);
            Console.WriteLine("Active Emotions: " + string.Concat(emotionalState.GetAllEmotions().Select(e => e.EmotionType + "-" + e.Intensity + " ")));

            //Each event that is appraised will be stored in the autobiographical memory that was passed as a parameter
            Console.WriteLine("\nEvents occured so far: " + string.Concat(am.RecallAllEvents().Select(e => "\nId: " + e.Id + " Event: " + e.EventName.ToString())));
            
            //The update function will increase the current tick by 1. Each active emotion will decay to 0 and the mood will slowly return to 0
            for (int i = 0; i < 3; i++)
            {
                am.Tick++;
                emotionalState.Decay(am.Tick);
                Console.WriteLine("\nMood on tick '" + am.Tick + "': " + emotionalState.Mood);
                Console.WriteLine("Active Emotions: " + string.Concat(emotionalState.GetAllEmotions().Select(e => e.EmotionType + "-" + e.Intensity + " ")));
            }

            //The asset can also be loaded from an existing file using the following method:
            
            ea = EmotionalAppraisalAsset.LoadFromFile("../../../Examples/EATest.ea");
            
            Console.ReadKey();
        }
    }
}

