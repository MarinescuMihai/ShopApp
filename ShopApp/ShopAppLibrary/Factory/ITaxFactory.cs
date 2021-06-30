using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAppLibrary.Factory
{
    public interface ITaxFactory
    {
        ITax GetTaxObject();
    }
}
