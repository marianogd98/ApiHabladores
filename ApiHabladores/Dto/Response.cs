using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHabladores.Dto
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }

        public Response(T data)
        {
            Success = true;
            Data = data;
        }

        public Response(string message)
        {
            Success = false;
            Message = message;
        }

        public Response(bool status, T data, string message)
        {
            Success = status;
            Data = data;
            Message = message;
        }


    }

    public class DataPaginationDto<T>
    {
        public T Data { get; set; }
        public int Page { get; set; }
        public int TotalItem { get; set; }
        public DataPaginationDto(T data, int page, int totalItem)
        {
            Data = data;
            Page = page;
            TotalItem = totalItem;
        }
    }
}
