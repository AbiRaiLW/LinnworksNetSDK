using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Basic stock item information 
    /// </summary>
    public class StockItemInfo
	{
        /// <summary>
        /// Item SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Item unique id 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// Item Title 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// Barcode number on the item header 
        /// </summary>
		public String Barcode;

        /// <summary>
        /// Image URL 
        /// </summary>
		public String PrimaryImageURL;

        /// <summary>
        /// Product identifiers 
        /// </summary>
		public List<StockItemIdentifier> Identifiers;
	} 
}