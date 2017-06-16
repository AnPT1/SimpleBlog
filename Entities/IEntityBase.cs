using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog2.Entities
{
    /// <summary>
    /// Base interface for database/domain Entities
    /// </summary>
    public interface IEntityBase
    {
        /// <summary>
        /// Primary key
        /// </summary>
        int Id { get; set; }
    }
}
