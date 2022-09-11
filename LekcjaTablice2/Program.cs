using System.Data;

namespace LekcjaTablice2
{
    class program
    {
        public static void Main(string[] args)
        {
            DataTable dt = new DataTable(); // nowa klasa tablica
            dt.Clear();
            dt.Columns.Add("Name"); // utworzenie kolumny
            dt.Columns.Add("Marks");
            DataRow _ravi = dt.NewRow(); // utworzenie nowego rzedu w kolumniw
            _ravi["Name"] = "Tomasz";    //
            _ravi["Marks"] = "367";
            dt.Rows.Add(_ravi);
            Console.WriteLine("Hello  " + _ravi["Name"]);
            Console.WriteLine(_ravi["Marks"]);
        }

    }

}