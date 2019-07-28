using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteBookProject
{
    class CommonClass
    {
        //public string connStr = "Data Source=WISSEN318; Initial Catalog=NotebookDB; uid=sa; pwd=12345";

        public string connStr = "Data source=.\\SQLSERVERCYLN; database=NotebookDB; integrated security=true";

        public static int userNo;  //kullanıcı giriş yaptıktan sonra bu değişkene id'si atanıyor, program içerisinde kullanıcıya ait bilgileri getirmek istersek 'CommonClass.userNo' ile bu id'ye her yerden ulaşabiliriz.

   //Örn: Kullanıcıya ait günlük bilgilerini formdan çağırırken => GetDiaryByUserId(CommonClass.userNo)

        public static DateTime noteDateTime;
    }
}
