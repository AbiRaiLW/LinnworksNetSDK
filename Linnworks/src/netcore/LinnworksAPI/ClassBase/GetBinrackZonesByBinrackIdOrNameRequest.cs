using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetBinrackZonesByBinrackIdOrNameRequest
	{
        /// <summary>
        /// Binrack Ids, StockLocationIntId optional, if different to supplied binrack ids, zones will still be returned. 
        /// </summary>
		public List<Int32> BinrackIds;

        /// <summary>
        /// Binrack names, StockLocationIntId required. 
        /// </summary>
		public List<String> BinrackNames;

        /// <summary>
        /// Stock Location interger id. 
        /// </summary>
		public Int32 StockLocationIntId;
	} 
}