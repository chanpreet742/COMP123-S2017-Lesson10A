using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_Lesson10A
{/*
 * Name: Chanpreet Mudhar
 * Date: July 11, 2017
 * Description: This Interface lists the signature for any superhero subclass
 * Version: 0.1 - Declared the klarma property
 */

    public interface IHasKarma
    {
        // PUBLIC PROPRTIES
        int Karma { get; set; }
    }
}