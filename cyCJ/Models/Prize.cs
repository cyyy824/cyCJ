using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using SQLite;

namespace cyCJ.Models
{
    public class Prize : ICloneable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Num { get; set; }

        public Prize()
        {
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Prize p = obj as Prize;
            if (p.Name == this.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
