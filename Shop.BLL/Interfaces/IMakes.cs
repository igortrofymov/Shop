using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using Shop.BLL.DTO;

namespace Shop.BLL.Interfaces
{
    public interface IMakes
    {
        IEnumerable<MakeDTO> GetMakes();
    }
}
