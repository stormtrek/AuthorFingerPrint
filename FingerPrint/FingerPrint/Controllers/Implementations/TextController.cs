﻿using FingerPrint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FingerPrint.Models.Interfaces.TypeInterfaces;
using System.IO;
using FingerPrint;

namespace FingerPrint.Controllers.Implementations
{
    public class TextController : ITextController<ISingleWordCountModel, File>
    {
        public void CreateText(string name, TextReader input, int length, string author = null)
        {
            throw new NotImplementedException();
        }

        public void DeleteText(Func<File, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public List<ITextViewModel<ISingleWordCountModel>> GetTextModels(Func<File, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public bool TextExists(Func<File, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public void UpdateText(ITextViewModel<ISingleWordCountModel> model, string name = null, string author = null, bool? quotesOn = default(bool?))
        {
            throw new NotImplementedException();
        }
    }
}
