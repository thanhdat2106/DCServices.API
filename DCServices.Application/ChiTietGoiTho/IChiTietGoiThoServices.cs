using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.ChiTietGoiTho
{
    public interface IChiTietGoiThoServices
    {
        Task<ActionResult<Data.Models.ChiTietGoiTho>> Post(Data.Models.ChiTietGoiTho data);

        Task<IEnumerable<Data.Models.ChiTietGoiTho>> getByMaGT(int maGT);
        //Task<IEnumerable<Data.Models.ChiTietGoiTho>> getByMaTho(int maGT, int maTho);
    }
}
