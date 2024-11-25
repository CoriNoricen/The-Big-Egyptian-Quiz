using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace The_Big_Egyptian_Quiz
{
    internal class Serializer
    {
        public static bool SerializePlayer(Player objectToSerialize)
        {
            try
            {
                Stream stream = File.Open("data.bin", FileMode.Create);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, objectToSerialize);
                stream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Player DeserializePlayer()
        {
            try
            {
                Stream stream = File.Open("data.bin", FileMode.Open);
                BinaryFormatter bFormatter = new BinaryFormatter();
                Player objectDeserialized = (Player)bFormatter.Deserialize(stream);
                stream.Close();
                return objectDeserialized;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
