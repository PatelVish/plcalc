using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plcalc.Common.Entities;

namespace plcalc.DataAccess.Model
{
    public abstract class ModelBase : IEntityBase
    {
        public ModelBase()
        {
            InitializeDefaults();
        }

        public virtual string ToXml()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A short string representing this class that is understandable by the support team.
        /// </summary>
        /// <returns></returns>
        public virtual string ToLabelForSupport()
        {
            return null;
        }

        public virtual void InitializeDefaults()
        {

        }
    }
}