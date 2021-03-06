﻿using System;
using System.Collections.Generic;

namespace Ocuco.DataModel.Catalog.Entities
{
    public partial class CatalogueFormat
    {
        public CatalogueFormat()
        {
            Catalogue = new HashSet<Catalogue>();
        }

        public int Id { get; set; }
        public string CatalogueFormatName { get; set; }

        public ICollection<Catalogue> Catalogue { get; set; }
    }
}
