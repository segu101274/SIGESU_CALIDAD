using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace SIGESU.Helpers
{
    public class ConvertToXML
    {
        public static string Registrar_XML(object o)
        {

            System.IO.StringWriter _oStringWriter = default(System.IO.StringWriter);
            string _listaSerializada = string.Empty;
            System.Xml.Serialization.XmlSerializer _oSerialization = default(System.Xml.Serialization.XmlSerializer);
            try
            {
                _oStringWriter = new System.IO.StringWriter();
                _oSerialization = new System.Xml.Serialization.XmlSerializer(o.GetType());
                _oSerialization.Serialize(_oStringWriter, o);
                _listaSerializada = _oStringWriter.ToString();

                return _listaSerializada;

            }
            catch (Exception ex)
            {
                return "";

            }
        }
    }
}
