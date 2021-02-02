using Projekt1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt1.Interface
{
    public interface IDirectorRepository
    {
        Director Get(int directorId);
        IEnumerable<Director> GetAll();
        Director Post(Director newDirector);
        Director Put(Director updatedDirector);
        Director Delete(int directorId);
    }
}
