using Magicodes.ExporterAndImporter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   
    internal class TestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [ExportImageField(Width = 200, Height = 120)]
        [ExporterHeader("图片")]
        public string ImageUrl { set; get; }

    }
}
