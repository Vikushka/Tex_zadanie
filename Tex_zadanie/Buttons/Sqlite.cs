using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tex_zadanie.Buttons
{
    internal class Sqlite : DatabaseContext
    {
        public object Product { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    
}