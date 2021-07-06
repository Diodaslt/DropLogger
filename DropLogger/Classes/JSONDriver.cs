using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
namespace DropLogger
{
    public class JSONDriver
    {
        public static string jsonpath = Directory.GetParent("Save").Parent.Parent.FullName + @"\Save\data.json";
        public JSONDriver()
        {

        }
        /// <summary>
        /// Write data to a json file
        /// </summary>
        /// <param name="observableCollection"></param>
        public static void WriteJson(ObservableCollection<ProfileModel> observableCollection)
        {
            string jsondata = JsonConvert.SerializeObject(observableCollection);
            WriteLineDebug.Write(jsondata);

            File.WriteAllText(jsonpath, jsondata);
        }
        /// <summary>
        /// Read json file
        /// </summary>
        public static void ReadJson()
        {
            if (!File.Exists(jsonpath))
                return;

            using (StreamReader r = new StreamReader(jsonpath))
            {
                string json = r.ReadToEnd();
                ProfileViewModel.ProfileList = JsonConvert.DeserializeObject<ObservableCollection<ProfileModel>>(json);
            }
        }
        /// <summary>
        /// Get the path of the folder in the app
        /// </summary>
        /// <returns></returns>
        public string GetDataPath()
        {
            return Directory.GetParent("Save").Parent.Parent.FullName + @"\Save\";
        }
    }
}
