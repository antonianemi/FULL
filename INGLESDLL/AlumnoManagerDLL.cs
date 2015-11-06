using BaseAcces;
using InglesEntity;
using System.Collections.Generic;
using System.Data;


namespace InglesDLL
{
    public class AlumnoManagerDLL : BaseLayerDLL
    {
        public AlumnoManagerDLL(string pstrConn, TypeDataBase pTypeDB) : base(pstrConn, pTypeDB)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Alumno> getAlumnos()
        {

            /*

            Ejemplo de lectura de excel con linq.
            public class ArtistAlbum
{
    public string Name { get; set; }
    public string Title { get; set; }
}
 
void PrintArtistAlbums()
{
    string pathToExcelFile = ""
    + @"D:\Code\Blog Projects\BlogSandbox\ArtistAlbums.xlsx";
 
    string sheetName = "Sheet1";
 
    var excelFile = new ExcelQueryFactory(pathToExcelFile);
    var artistAlbums = from a in excelFile.Worksheet<ArtistAlbum>(sheetName) select a; 
 
    foreach (var a in artistAlbums)
    {
        string artistInfo = "Artist Name: {0}; Album: {1}";
        Console.WriteLine(artistInfo, a.Name, a.Title);
    }
}
            
            
            */



            IDataReader reader = new HelperFileManager().ExecuteReader();

            while (reader.Read())
            {

            }


            return new List<Alumno>();
        }



    }
}
