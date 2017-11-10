﻿namespace UglyToad.Pdf.Tokenization.Tokens
{
    using Cos;

    public class NameToken : IDataToken<CosName>
    {
        public CosName Data { get; }

        public NameToken(string text)
        {
            Data = CosName.Create(text);
        }
    }
}