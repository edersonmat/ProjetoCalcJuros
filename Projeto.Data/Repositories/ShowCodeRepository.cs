using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Contracts;

namespace Projeto.Data.Repositories
{
    public class ShowCodeRepository : ICodePresents
    {
        public string ShowTheCode(string url)
        {
            return url;
        }
    }
}
