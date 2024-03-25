namespace MyWeb.Models;

public class SaModel
{
        public int Id; // for system (DB)
        public string Username;  //學號
        public string Name;
        public bool Paid;//已繳費
}

public static class SaModelFakeDb
{
        public static Dictionary<string, SaModel> _dictionary = new Dictionary<string, SaModel>();

        static SaModelFakeDb()
        {
                _dictionary.Add("p10941",new SaModel(){Id=1234,
                        Username =  "p10941",
                        Name="吳柏瀧",
                        Paid =  false,});
                
                _dictionary.Add("p10942",new SaModel(){Id=8787,
                        Username =  "p10942",
                        Name="金城武",
                        Paid =  true,});
        } 
        
        
}