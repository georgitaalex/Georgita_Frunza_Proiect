using System;
using Georgita_Frunza_Proiect.Data;
using System.IO;
	



namespace Georgita_Frunza_Proiect;

public partial class App : Application
{

    static SSListDatabase database;
    public static SSListDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               SSListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "SSList.db3"));
            }
            return database;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
