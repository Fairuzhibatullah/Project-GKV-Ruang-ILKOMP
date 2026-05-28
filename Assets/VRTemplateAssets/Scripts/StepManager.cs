using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Unity.VRTemplate
{
    /// <summary>
    /// Controls the steps in the in coaching card.
    /// </summary>
    public class StepManager : MonoBehaviour
    {
        [Serializable]
        class Step
        {
            [SerializeField]
            public GameObject stepObject;

            [SerializeField]
            public string buttonText;
        }

        [SerializeField]
        public TextMeshProUGUI m_StepButtonTextField;

        [SerializeField]
        List<Step> m_StepList = new List<Step>();

        int m_CurrentStepIndex = 0;

        public void Next()
        {
            if (m_StepList == null || m_StepList.Count == 0)
            {
                Debug.LogError("Step List is empty or null in StepManager!", this);
                return;
            }

            // Deactivate the current step object if it exists
            Step currentStep = m_StepList[m_CurrentStepIndex];
            if (currentStep != null && currentStep.stepObject != null)
            {
                currentStep.stepObject.SetActive(false);
            }
            else
            {
                Debug.LogWarning($"Current step object at index {m_CurrentStepIndex} is null or missing!", this);
            }

            // Move to the next step index
            m_CurrentStepIndex = (m_CurrentStepIndex + 1) % m_StepList.Count;

            // Activate the new current step object if it exists
            Step newStep = m_StepList[m_CurrentStepIndex];
            if (newStep != null && newStep.stepObject != null)
            {
                newStep.stepObject.SetActive(true);
            }
            else
            {
                Debug.LogError($"Cannot activate next step object: step at index {m_CurrentStepIndex} is null or missing in StepManager list! Check the inspector.", this);
            }

            // Update button text field if assigned
            if (m_StepButtonTextField != null)
            {
                m_StepButtonTextField.text = newStep != null ? newStep.buttonText : string.Empty;
            }
            else
            {
                Debug.LogWarning("m_StepButtonTextField is not assigned in StepManager!", this);
            }
        }
    }
}
