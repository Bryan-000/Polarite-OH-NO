using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace Polarite
{
    // just for softlock doors so they can't enable
    public class ForceOff : MonoBehaviour
    {
        public void Update()
        {
            gameObject.SetActive(false);
        }
    }
}
