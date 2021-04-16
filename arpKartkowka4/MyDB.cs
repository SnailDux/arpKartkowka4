using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace arpKartkowka4
{

    public class MyDB : DbContext
    {
        public virtual DbSet<MojaEncja> MyTbl { get; set; }
    }

}
