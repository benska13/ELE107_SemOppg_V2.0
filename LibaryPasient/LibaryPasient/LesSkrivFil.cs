using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

namespace LibaryPasient
{
    public class LesSkrivFil
    {
        public static BindingList<ListPasient> LesFraFil(string filnav)
        {
            BindingList<ListPasient> _p = null;
            
            
            try
            {
                var serilazer = new JavaScriptSerializer();
                string data = File.ReadAllText(filnav);

                _p = serilazer.Deserialize<BindingList<ListPasient>>(data);

            }
            catch (SerializationException e)
            {
               
                throw;
            }

            return _p;
        }

        public static void SkrivTilFil(BindingList<ListPasient> _p, string filnav)
        {
            try
            {
                var serilazer = new  JavaScriptSerializer();
                string data = serilazer.Serialize(_p);
                File.WriteAllText(filnav,data);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}