using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionCollection : ScriptableObject
{

    public string description;
    public Condition[] requiredConditions = new Condition[0];
   // public ReactionCollection reactionCollection;

    




    public bool CheckAndReact()
    {
        for(int i = 0; i < requiredConditions.Length; i++)
        {
            if (!AllConditions.CheckCondition(requiredConditions[i]))
            {
                return false;
            }
        }


        // need to do a reaction collection script for these to work
        //if (reactionCollection)
        //{
        //    reactionCollection.React();
        //}

        return true;
    }


}
