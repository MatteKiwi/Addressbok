namespace Adressbok.Classes
{
    public class FileManager
    {
        private string _filePath; //Instansvariabel 
        private StreamWriter _writer; //Kapslar in streamwriter
        private StreamReader _reader; //Kapslar in streamreader

        //Konstruktor med "filepath" som inparameter
        public FileManager(string filePath)
        {
            _filePath = filePath;
        }

        //Metod som använder sig av StreamWriter för att skriva till "txt" fil
        public void WriteFile(List<Person> person, string row)
        {
            using (_writer = new StreamWriter(_filePath, true))
            {

                for (int i = 0; i < person.Count; i++)
                {
                    _writer.WriteLine(person[i].FirstName + "," + person[i].LastName + "," +
                                      person[i].Address + "," + person[i].ZipCode + "," +
                                      person[i].City + "," + person[i].Phone + "," + person[i].Email);
                }

            }
        }
        public void ReadFile(List<Person> people, string condition, ListBox list)
        {
            using (_reader = new StreamReader(_filePath))
            {
                string row;
                Person person = new Person();
                list.Items.Clear();
                while ((row = _reader.ReadLine()) != null)
                {
                    if (row.ToLower().Contains(condition.ToLower()))
                    {
                        list.Items.Add(row);
                    }
                }
            }
        }
    }
}
