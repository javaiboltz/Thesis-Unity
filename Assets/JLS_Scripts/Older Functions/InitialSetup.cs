﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InitialSetup : MonoBehaviour
{
    private Participant part;
    private int pNum, pAge, pGender, pIndType, pPitchType;
    //private string pGender = "Male";
    //public Dropdown ddGend;

    //public PersistentData persisData;


    public void SetParticipantNumber(string num)
    {
        pNum = int.Parse(num);
    }

    public void SetParticipantAge(string age)
    {
        pAge = int.Parse(age);
    }

    public void SetParticipantGender(string gender)
    {
        pGender = int.Parse(gender);
        //pGender = ddGend.options[gender].text;
        // male = 0; female = 1;
    }

    public void SetParticipantIndicatorTypeControl()
    {
        //pIndType = int.Parse(indType);
        // Control Attitude Indicator is 0;
        pIndType = 0;
    }

    public void SetParticipantIndicatorTypePHaptic()
    {
        //pIndType = int.Parse(indType);
        // Pseudo-Haptic Attitude Indicator is 1;
        pIndType = 1;
    }

    public void SetParticipantPitchTypeInverted()
    {
        // Inverted Pitch is 0
        pPitchType = 0;
    }

    public void SetParticipantPitchTypeNonInverted()
    {
        // Non-Inverted Pitch is 1
        pPitchType = 1;
    }


    public void CreateParticipant()
    {
        part = new Participant(pNum, pAge, pGender, pIndType, pPitchType);
        Debug.Log(part.ToString());
        //var file = SaveData.InitialSaveIntoJson(part);

        //persisData.participant = part;
        //persisData.setFileNamePath(file[0], file[1]);
    }
}