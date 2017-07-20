using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson10A
{
    /*
 * Name: Chanpreet Mudhar
 * Date: July 20, 2017
 * Description: This is the AntiHero class.
 * Version: 0.1 - Created the AntiHro class.
 */
    public class AntiHero : SuperHuman , IHasKarma, IHasMalice
    {//Private instance variables
        private int _karma;
        private int _malice;
        //PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }
            public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }
        
        //CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the AntiHero class
        /// It ttakes three arguments- name(string) -karma(int) -malice(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        /// <param name="malice"></param>
        public AntiHero(string name,int karma,int malice)
            : base(name)
        {
            this.Karma = karma;
            this.Malice = malice;
        }
    }
    
}
