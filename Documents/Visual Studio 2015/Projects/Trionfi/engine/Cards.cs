using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace engine
{
    public class Cards : Items
    {
              
        public int PointForSahasrara { get; set;}
        public int PointForAjna { get; set; }
        public int PointForVishuddha { get; set; }
        public int PointForAnahata { get; set; }
        public int PointForManipura { get; set; }
        public int PointForSvadhishthana { get; set; }
        public int PointForMuladhara { get; set; }
        //====
        public int Tree_Number { get; set; }
        public string Ruled_By { get; set; }
        public string Hebrew_Letter { get; set; }
        public int Numerical_Value { get; set; }
        public string Description { get; set; }

        public Cards(int id,string name, int tree_Number, string ruled_By, string hebrew_Letter, int numerical_Value, string description) : base(id, name, description)
        {
            Id = id;
            Name = name;
            Tree_Number = tree_Number;
            Ruled_By = ruled_By;
            Hebrew_Letter = hebrew_Letter;
            Numerical_Value = numerical_Value;
            Description = description;

        //String JSONstring = File.ReadAllText("Cards_Description.json");
        //JavaScriptSerializer ser = new JavaScriptSerializer();
        //Cards p1 = ser.Deserialize<Cards>(JSONstring);
        }
        
    }
}
