using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

namespace Dma.UI
{
    [ExecuteInEditMode]
    public class ProgressBar : MonoBehaviour
    {
        public float Maximum = 100;
        public float Current = 50;

        [SerializeField]
        private Image m_Mask;

        private void Update()
        {
            GetCurrentFillAmount();
        }

        private void GetCurrentFillAmount()
        {
            var fillamount = Current / Maximum;
            m_Mask.fillAmount = fillamount;
        }
    }
}


