using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Generic hangi tiple çalışacagını bilmio her metod kategori , kategori listesi döndürebilir bu yuzden generic
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
