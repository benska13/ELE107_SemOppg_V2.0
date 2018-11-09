using System.Web.Script.Serialization;

namespace LibaryPasient
{
    public class Serialize
    {
        public static Pasient StringTPasient(string s)
        {
            return new JavaScriptSerializer().Deserialize<Pasient>(s);
        }

        public static string PasientTString(Pasient p)
        {
            return  new JavaScriptSerializer().Serialize(p);
        }
    }
}