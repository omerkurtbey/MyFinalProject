using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } // Yapılan işlemin yapılıp yapılmadığını okumak için
        string Message { get; } // Yapılan işlemin mesajını okumak için
    }
}
