using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KonsolProjekt.FolderForTextFile
{
    class Contacts
    {
        private string _teacherEmail;

        public string teachermail
        {
            get
            {

            try
                {
                    if (_teacherEmail == null)
                    {
                        string envirnt = Environment.CurrentDirectory + @"\Files\Contacts.txt";
                        _teacherEmail = System.IO.File.ReadAllText(envirnt);
                    }
                }
                catch (Exception exc)
                    {
                        _teacherEmail = exc.Message;

                    }
                    return _teacherEmail;
               
            }
        }

        
    }

        
}
       














        
       
       
       
    

